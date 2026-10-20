namespace Sube2.HelloWindowsApp
{
    partial class frmKacanButon
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
            btnKac = new Button();
            SuspendLayout();
            // 
            // btnKac
            // 
            btnKac.Location = new Point(337, 145);
            btnKac.Name = "btnKac";
            btnKac.Size = new Size(94, 82);
            btnKac.TabIndex = 0;
            btnKac.Text = "button1";
            btnKac.UseVisualStyleBackColor = true;
            btnKac.MouseMove += button1_MouseMove;
            // 
            // frmKacanButon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(btnKac);
            Name = "frmKacanButon";
            Text = "frmKacanButon";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKac;
    }
}