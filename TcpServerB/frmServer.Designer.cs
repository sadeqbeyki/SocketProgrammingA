namespace TcpServerB
{
    partial class frmServer
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
            label1 = new Label();
            tbIP = new TextBox();
            tbInfo = new TextBox();
            tbMessage = new TextBox();
            btnStart = new Button();
            label2 = new Label();
            lstClientIp = new ListBox();
            label3 = new Label();
            gbSettings = new GroupBox();
            gbChatBox = new GroupBox();
            gbSettings.SuspendLayout();
            gbChatBox.SuspendLayout();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(314, 287);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 50);
            btnSend.TabIndex = 0;
            btnSend.Text = "&Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Server :";
            // 
            // tbIP
            // 
            tbIP.Location = new Point(6, 57);
            tbIP.Name = "tbIP";
            tbIP.Size = new Size(175, 23);
            tbIP.TabIndex = 2;
            tbIP.Text = "127.0.0.1:9000";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(6, 27);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.ReadOnly = true;
            tbInfo.ScrollBars = ScrollBars.Both;
            tbInfo.Size = new Size(382, 225);
            tbInfo.TabIndex = 3;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(6, 287);
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(309, 50);
            tbMessage.TabIndex = 4;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(6, 86);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(175, 23);
            btnStart.TabIndex = 5;
            btnStart.Text = "S&tart Listening";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 269);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 6;
            label2.Text = "Message :";
            // 
            // lstClientIp
            // 
            lstClientIp.FormattingEnabled = true;
            lstClientIp.ItemHeight = 15;
            lstClientIp.Location = new Point(6, 153);
            lstClientIp.Name = "lstClientIp";
            lstClientIp.Size = new Size(175, 184);
            lstClientIp.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 135);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 8;
            label3.Text = "Clients :";
            // 
            // gbSettings
            // 
            gbSettings.Controls.Add(label3);
            gbSettings.Controls.Add(btnStart);
            gbSettings.Controls.Add(lstClientIp);
            gbSettings.Controls.Add(tbIP);
            gbSettings.Controls.Add(label1);
            gbSettings.Location = new Point(12, 12);
            gbSettings.Name = "gbSettings";
            gbSettings.Size = new Size(195, 352);
            gbSettings.TabIndex = 9;
            gbSettings.TabStop = false;
            gbSettings.Text = "Configuration";
            // 
            // gbChatBox
            // 
            gbChatBox.Controls.Add(btnSend);
            gbChatBox.Controls.Add(label2);
            gbChatBox.Controls.Add(tbInfo);
            gbChatBox.Controls.Add(tbMessage);
            gbChatBox.Location = new Point(213, 12);
            gbChatBox.Name = "gbChatBox";
            gbChatBox.Size = new Size(395, 352);
            gbChatBox.TabIndex = 10;
            gbChatBox.TabStop = false;
            gbChatBox.Text = "Chat Box";
            // 
            // frmServer
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(617, 370);
            Controls.Add(gbSettings);
            Controls.Add(gbChatBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmServer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server";
            Load += Form1_Load;
            gbSettings.ResumeLayout(false);
            gbSettings.PerformLayout();
            gbChatBox.ResumeLayout(false);
            gbChatBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSend;
        private Label label1;
        private TextBox tbIP;
        private TextBox tbInfo;
        private TextBox tbMessage;
        private Button btnStart;
        private Label label2;
        private ListBox lstClientIp;
        private Label label3;
        private GroupBox gbSettings;
        private GroupBox gbChatBox;
    }
}