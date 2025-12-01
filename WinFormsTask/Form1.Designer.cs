namespace WinFormsTask
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            button_Connect_DB = new Button();
            button_Disconnect_DB = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 27);
            textBox1.TabIndex = 0;
            // 
            // button_Connect_DB
            // 
            button_Connect_DB.Location = new Point(102, 137);
            button_Connect_DB.Name = "button_Connect_DB";
            button_Connect_DB.Size = new Size(165, 29);
            button_Connect_DB.TabIndex = 1;
            button_Connect_DB.Text = "Connect DB";
            button_Connect_DB.UseVisualStyleBackColor = true;
            button_Connect_DB.Click += button_Connect_DB_Click;
            // 
            // button_Disconnect_DB
            // 
            button_Disconnect_DB.Location = new Point(102, 219);
            button_Disconnect_DB.Name = "button_Disconnect_DB";
            button_Disconnect_DB.Size = new Size(165, 29);
            button_Disconnect_DB.TabIndex = 2;
            button_Disconnect_DB.Text = "Disconnect DB";
            button_Disconnect_DB.UseVisualStyleBackColor = true;
            button_Disconnect_DB.Click += button_Disconnect_DB_Click;
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Disconnect_DB);
            Controls.Add(button_Connect_DB);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button_Connect_DB;
        private Button button_Disconnect_DB;
        private System.Windows.Forms.Timer timer1;
    }
}
