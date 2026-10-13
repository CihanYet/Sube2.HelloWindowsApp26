namespace Sube2.HelloWindowsApp
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
            btnHello = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.Location = new Point(332, 164);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(131, 65);
            btnHello.TabIndex = 0;
            btnHello.Text = "Hello Windows!";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += MyButtonClick;
            btnHello.Move += button1_Move;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(399, 96);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnHello);
            Name = "Form1";
            Text = "Form1";
            SizeChanged += Form1_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHello;
        private Label label1;
    }
}
