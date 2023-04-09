namespace TcpServerA
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
            tbConsoleOutput = new TextBox();
            tbIPAddress = new TextBox();
            tbPort = new TextBox();
            label1 = new Label();
            btnStartListening = new Button();
            btnSend = new Button();
            tbPayload = new TextBox();
            bntFindIpV4 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbConsoleOutput
            // 
            tbConsoleOutput.Location = new Point(12, 15);
            tbConsoleOutput.Multiline = true;
            tbConsoleOutput.Name = "tbConsoleOutput";
            tbConsoleOutput.Size = new Size(900, 400);
            tbConsoleOutput.TabIndex = 0;
            // 
            // tbIPAddress
            // 
            tbIPAddress.Location = new Point(74, 425);
            tbIPAddress.Name = "tbIPAddress";
            tbIPAddress.Size = new Size(171, 23);
            tbIPAddress.TabIndex = 1;
            tbIPAddress.Text = "172.24.112.1";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(255, 426);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(71, 23);
            tbPort.TabIndex = 2;
            tbPort.Text = "23000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 429);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "IP / Port :";
            // 
            // btnStartListening
            // 
            btnStartListening.Cursor = Cursors.Hand;
            btnStartListening.Location = new Point(74, 454);
            btnStartListening.Name = "btnStartListening";
            btnStartListening.Size = new Size(171, 23);
            btnStartListening.TabIndex = 4;
            btnStartListening.Text = "Start &Listening";
            btnStartListening.UseVisualStyleBackColor = true;
            btnStartListening.Click += btnStartListening_Click;
            // 
            // btnSend
            // 
            btnSend.Cursor = Cursors.Hand;
            btnSend.Location = new Point(669, 454);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(197, 23);
            btnSend.TabIndex = 6;
            btnSend.Text = "&Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // tbPayload
            // 
            tbPayload.Location = new Point(669, 425);
            tbPayload.Name = "tbPayload";
            tbPayload.Size = new Size(197, 23);
            tbPayload.TabIndex = 5;
            // 
            // bntFindIpV4
            // 
            bntFindIpV4.Cursor = Cursors.Hand;
            bntFindIpV4.Location = new Point(251, 455);
            bntFindIpV4.Name = "bntFindIpV4";
            bntFindIpV4.Size = new Size(75, 23);
            bntFindIpV4.TabIndex = 7;
            bntFindIpV4.Text = "&Find IP";
            bntFindIpV4.UseVisualStyleBackColor = true;
            bntFindIpV4.Click += bntFindIpV4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(599, 425);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "Payload :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 489);
            Controls.Add(label2);
            Controls.Add(bntFindIpV4);
            Controls.Add(btnSend);
            Controls.Add(tbPayload);
            Controls.Add(btnStartListening);
            Controls.Add(label1);
            Controls.Add(tbPort);
            Controls.Add(tbIPAddress);
            Controls.Add(tbConsoleOutput);
            Name = "Form1";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbConsoleOutput;
        private TextBox tbIPAddress;
        private TextBox tbPort;
        private Label label1;
        private Button btnStartListening;
        private Button btnSend;
        private TextBox tbPayload;
        private Button bntFindIpV4;
        private Label label2;
    }
}