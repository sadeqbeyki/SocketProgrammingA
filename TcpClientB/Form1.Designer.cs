namespace TcpClientB
{
    partial class Form1
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
            btnConnect = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(304, 262);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 0;
            btnSend.Text = "&Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Server :";
            // 
            // tbIP
            // 
            tbIP.Location = new Point(78, 34);
            tbIP.Name = "tbIP";
            tbIP.Size = new Size(382, 23);
            tbIP.TabIndex = 2;
            tbIP.Text = "127.0.0.1:9000";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(78, 65);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.ReadOnly = true;
            tbInfo.ScrollBars = ScrollBars.Both;
            tbInfo.Size = new Size(382, 162);
            tbInfo.TabIndex = 3;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(78, 233);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(382, 23);
            tbMessage.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(385, 262);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "&Connect";
            btnConnect.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 233);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 6;
            label2.Text = "Message :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 305);
            Controls.Add(label2);
            Controls.Add(btnConnect);
            Controls.Add(tbMessage);
            Controls.Add(tbInfo);
            Controls.Add(tbIP);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label label1;
        private TextBox tbIP;
        private TextBox tbInfo;
        private TextBox tbMessage;
        private Button btnConnect;
        private Label label2;
    }
}