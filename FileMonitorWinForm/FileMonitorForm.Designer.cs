namespace FileMonitorWinForm
{
    partial class FileMonitorForm
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
            textBoxLog = new TextBox();
            btnInstall = new Button();
            btnUninstall = new Button();
            btnStart = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(12, 12);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(866, 503);
            textBoxLog.TabIndex = 0;
            // 
            // btnInstall
            // 
            btnInstall.Location = new Point(923, 30);
            btnInstall.Name = "btnInstall";
            btnInstall.Size = new Size(259, 29);
            btnInstall.TabIndex = 1;
            btnInstall.Text = "Install Service";
            btnInstall.UseVisualStyleBackColor = true;
            btnInstall.Click += btnInstall_Click;
            // 
            // btnUninstall
            // 
            btnUninstall.Location = new Point(923, 96);
            btnUninstall.Name = "btnUninstall";
            btnUninstall.Size = new Size(259, 46);
            btnUninstall.TabIndex = 2;
            btnUninstall.Text = "Uninstall Service";
            btnUninstall.UseVisualStyleBackColor = true;
            btnUninstall.Click += btnUninstall_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(923, 188);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(259, 44);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start Service";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(923, 301);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(259, 58);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop Service";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 527);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(btnUninstall);
            Controls.Add(btnInstall);
            Controls.Add(textBoxLog);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLog;
        private Button btnInstall;
        private Button btnUninstall;
        private Button btnStart;
        private Button btnStop;
    }
}
