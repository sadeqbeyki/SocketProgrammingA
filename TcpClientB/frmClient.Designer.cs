namespace TcpClientB
{
    partial class frmClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSend = new Button();
            lblServer = new Label();
            tbIP = new TextBox();
            tbInfo = new TextBox();
            tbMessage = new TextBox();
            btnConnect = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(388, 231);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(84, 50);
            btnSend.TabIndex = 0;
            btnSend.Text = "&Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(22, 15);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(45, 15);
            lblServer.TabIndex = 1;
            lblServer.Text = "Server :";
            // 
            // tbIP
            // 
            tbIP.Location = new Point(73, 15);
            tbIP.Name = "tbIP";
            tbIP.Size = new Size(250, 23);
            tbIP.TabIndex = 2;
            tbIP.Text = "127.0.0.1:9000";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(22, 46);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.ReadOnly = true;
            tbInfo.ScrollBars = ScrollBars.Both;
            tbInfo.Size = new Size(450, 162);
            tbInfo.TabIndex = 3;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(22, 231);
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(369, 50);
            tbMessage.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(329, 15);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(143, 23);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "&Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(22, 213);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(59, 15);
            lblMessage.TabIndex = 6;
            lblMessage.Text = "Message :";
            // 
            // frmClient
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(484, 296);
            Controls.Add(lblMessage);
            Controls.Add(btnConnect);
            Controls.Add(tbMessage);
            Controls.Add(tbInfo);
            Controls.Add(tbIP);
            Controls.Add(lblServer);
            Controls.Add(btnSend);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label lblServer;
        private TextBox tbIP;
        private TextBox tbInfo;
        private TextBox tbMessage;
        private Button btnConnect;
        private Label lblMessage;
    }
}