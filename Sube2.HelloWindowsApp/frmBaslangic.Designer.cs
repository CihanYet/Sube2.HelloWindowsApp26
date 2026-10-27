namespace Sube2.HelloWindowsApp
{
    partial class frmBaslangic
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
            btnAc = new Button();
            SuspendLayout();
            // 
            // btnAc
            // 
            btnAc.Location = new Point(131, 96);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(149, 86);
            btnAc.TabIndex = 0;
            btnAc.Text = "Formu Aç";
            btnAc.UseVisualStyleBackColor = true;
            btnAc.Click += btnAc_Click;
            // 
            // frmBaslangic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 288);
            Controls.Add(btnAc);
            Name = "frmBaslangic";
            Text = "frmBaslangic";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAc;
    }
}