namespace ChatSocket
{
    partial class frmChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNick = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.btnAddHost = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.rtbSend = new System.Windows.Forms.RichTextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.clbUsers = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(39, 27);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(55, 13);
            this.lblNick.TabIndex = 0;
            this.lblNick.Text = "Nickname";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(100, 27);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(192, 20);
            this.txtNick.TabIndex = 1;
            // 
            // btnAddHost
            // 
            this.btnAddHost.Location = new System.Drawing.Point(622, 76);
            this.btnAddHost.Name = "btnAddHost";
            this.btnAddHost.Size = new System.Drawing.Size(136, 23);
            this.btnAddHost.TabIndex = 2;
            this.btnAddHost.Text = "Add Host";
            this.btnAddHost.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(42, 408);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(17, 53);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(579, 186);
            this.rtbChat.TabIndex = 4;
            this.rtbChat.Text = "";
            // 
            // rtbSend
            // 
            this.rtbSend.Location = new System.Drawing.Point(17, 245);
            this.rtbSend.Name = "rtbSend";
            this.rtbSend.Size = new System.Drawing.Size(579, 157);
            this.rtbSend.TabIndex = 5;
            this.rtbSend.Text = "";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(622, 106);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(136, 20);
            this.txtHost.TabIndex = 6;
            // 
            // clbUsers
            // 
            this.clbUsers.FormattingEnabled = true;
            this.clbUsers.Location = new System.Drawing.Point(622, 133);
            this.clbUsers.Name = "clbUsers";
            this.clbUsers.Size = new System.Drawing.Size(136, 259);
            this.clbUsers.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clbUsers);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.rtbSend);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnAddHost);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.lblNick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Button btnAddHost;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.RichTextBox rtbSend;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.CheckedListBox clbUsers;
    }
}

