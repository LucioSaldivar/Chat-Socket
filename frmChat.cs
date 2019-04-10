using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSocket
{
    public partial class frmChat : Form
    {
        public delegate void HandlerGeneric();
        public delegate void HandlerWaitingMessage(Socket s);
        public frmChat()
        {
            InitializeComponent();
        }

        private void frmChat_Load(object sender, EventArgs e)
        {
            this.Text = "Chat - " + Dns.GetHostAddresses(Dns.GetHostName())[0].ToString();
            HandlerGeneric init_server = new
                HandlerGeneric(this.StartServer);
            init_server.BeginInvoke(null, init_server);
        }
        private void StartServer()
        {
            IPAddress iPAddress = Dns.GetHostAddresses(
                Dns.GetHostName())[0];
            TcpListener list = new TcpListener(
                iPAddress, 3030);
            list.Start();

            HandlerWaitingMessage hndWaitingMessage = new
                HandlerWaitingMessage(this.WaitingMessage);
            while (true)
            {
                Socket s = list.AcceptSocket();
                hndWaitingMessage.BeginInvoke(s, null,
                    hndWaitingMessage);
            }
        }
        private void WaitingMessage(Socket s)
        {
            while (s.Connected)
            {
                if (s.Available != 0)
                {
                    byte[] buffer = new
                        byte[s.ReceiveBufferSize];
                    int read = s.Receive(buffer);
                    string cmd =
                        System.Text.Encoding.ASCII.GetString(buffer);
                    if (cmd.StartsWith("MSG"))
                    {
                        string[] msg = cmd.Split(new char[] { ':' });
                        ReceiverMSG(msg);
                    }
                }
                System.Threading.Thread.Sleep(250);
            }
        }
        private void SendMsg()
        {
            foreach (object user in clbUsers.CheckedItems)
            {
                if (!string.IsNullOrEmpty(user.ToString()))
                {
                    if (string.IsNullOrEmpty(rtbSend.Text))
                    {
                        MessageBox.Show("Message is required.");
                        return;
                    }
                    Socket tempSocket = new Socket(
                        AddressFamily.InterNetwork, SocketType.Stream,
                        ProtocolType.Tcp);
                    try
                    {
                        tempSocket.Connect(user.ToString(), 3030);
                    }
                    catch
                    {
                        clbUsers.Items.Remove(user);
                        MessageBox.Show(
                            "It is not possible to connect.");
                        return;
                    }
                    byte[] buffer =
                        System.Text.Encoding.ASCII.GetBytes(
                            "MSG:" + Dns.GetHostAddresses(
                                Dns.GetHostName())[0].ToString() + ":" +
                                txtNick.Text + ":" + rtbSend.Text);
                    tempSocket.Send(buffer);
                    tempSocket.Close();
                }
            }
            rtbChat.Text += "\r" + string.Format("{0:T}",
                DateTime.Now) + " <<" + txtNick.Text + ">> -" +
                rtbSend.Text;
            rtbSend.Text = "";
        }
        private void ReceiverMSG(string[] msg)
        {
            if (this.InvokeRequired)
            {
                HandlerReceiverMSG hndmsg = new
                    HandlerReceiverMSG(ReceiverMSG);
                this.Invoke(hndmsg, new object[] { msg });
            }
            else
            {
                rtbChat.Text += "\r" + string.Format("{0:T}",
                  DateTime.Now) + " <<" + msg[2] + ">> -" +
                  msg[3];
                if (!clbUsers.Items.Contains(msg[1]))
                {
                    clbUsers.Items.Add(msg[1]);
                }
            }
        }
        private void btnAddHost_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dns.GetHostAddresses(
                  txtHost.Text).Length != 0)
                {
                    if (!string.IsNullOrEmpty(txtHost.Text))
                    {
                        clbUsers.Items.Add(txtHost.Text);
                        txtHost.Text = "";
                    }
                }
            }
            catch
            {
                txtHost.Text = "";
                txtHost.Focus();
                MessageBox.Show("Invalid Host");
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNick.Text))
                SendMsg();
            else
            {
                MessageBox.Show("NickName is required");
                txtNick.Focus();
            }
        }
    }
}
