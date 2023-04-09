namespace TcpClientA
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
            tbConsole = new TextBox();
            tbServerIp = new TextBox();
            tbServerPort = new TextBox();
            tbPayload = new TextBox();
            btnConnect = new Button();
            btnSend = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // tbConsole
            // 
            tbConsole.Location = new Point(12, 12);
            tbConsole.Multiline = true;
            tbConsole.Name = "tbConsole";
            tbConsole.Size = new Size(860, 344);
            tbConsole.TabIndex = 0;
            // 
            // tbServerIp
            // 
            tbServerIp.Location = new Point(85, 362);
            tbServerIp.Name = "tbServerIp";
            tbServerIp.Size = new Size(223, 23);
            tbServerIp.TabIndex = 1;
            // 
            // tbServerPort
            // 
            tbServerPort.Location = new Point(85, 391);
            tbServerPort.Name = "tbServerPort";
            tbServerPort.Size = new Size(127, 23);
            tbServerPort.TabIndex = 2;
            // 
            // tbPayload
            // 
            tbPayload.Location = new Point(772, 362);
            tbPayload.Name = "tbPayload";
            tbPayload.Size = new Size(100, 23);
            tbPayload.TabIndex = 3;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(218, 390);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(90, 23);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "&Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(772, 391);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 23);
            btnSend.TabIndex = 5;
            btnSend.Text = "&Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 362);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 6;
            label1.Text = "Server IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(708, 365);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 7;
            label2.Text = "Payload";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 391);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 8;
            label3.Text = "Server Port";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Controls.Add(tbPayload);
            Controls.Add(tbServerPort);
            Controls.Add(tbServerIp);
            Controls.Add(tbConsole);
            Name = "Form1";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbConsole;
        private TextBox tbServerIp;
        private TextBox tbServerPort;
        private TextBox tbPayload;
        private Button btnConnect;
        private Button btnSend;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}