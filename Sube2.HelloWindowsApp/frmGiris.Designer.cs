namespace Sube2.HelloWindowsApp
{
    partial class frmGiris
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
            grpKullanici = new GroupBox();
            btnGiris = new Button();
            lblSoyad = new Label();
            lblAd = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            grpSeviye = new GroupBox();
            rdKolay = new RadioButton();
            rdOrta = new RadioButton();
            rdZor = new RadioButton();
            grpKullanici.SuspendLayout();
            grpSeviye.SuspendLayout();
            SuspendLayout();
            // 
            // grpKullanici
            // 
            grpKullanici.Controls.Add(lblSoyad);
            grpKullanici.Controls.Add(lblAd);
            grpKullanici.Controls.Add(txtSoyad);
            grpKullanici.Controls.Add(txtAd);
            grpKullanici.Location = new Point(35, 29);
            grpKullanici.Name = "grpKullanici";
            grpKullanici.Size = new Size(247, 123);
            grpKullanici.TabIndex = 0;
            grpKullanici.TabStop = false;
            grpKullanici.Text = "Kullanıcı Bilgileri";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(35, 268);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(247, 49);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(49, 79);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(39, 15);
            lblSoyad.TabIndex = 3;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(49, 49);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(22, 15);
            lblAd.TabIndex = 2;
            lblAd.Text = "Ad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(93, 71);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 1;
            txtSoyad.Tag = "Z";
            txtSoyad.TextChanged += txt_TextChanged;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(93, 41);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 0;
            txtAd.Tag = "Z";
            txtAd.TextChanged += txt_TextChanged;
            // 
            // grpSeviye
            // 
            grpSeviye.Controls.Add(rdZor);
            grpSeviye.Controls.Add(rdOrta);
            grpSeviye.Controls.Add(rdKolay);
            grpSeviye.Location = new Point(35, 169);
            grpSeviye.Name = "grpSeviye";
            grpSeviye.Size = new Size(247, 82);
            grpSeviye.TabIndex = 1;
            grpSeviye.TabStop = false;
            grpSeviye.Text = "Seviye Seçiniz";
            // 
            // rdKolay
            // 
            rdKolay.AutoSize = true;
            rdKolay.Location = new Point(35, 37);
            rdKolay.Name = "rdKolay";
            rdKolay.Size = new Size(54, 19);
            rdKolay.TabIndex = 0;
            rdKolay.TabStop = true;
            rdKolay.Text = "Kolay";
            rdKolay.UseVisualStyleBackColor = true;
            // 
            // rdOrta
            // 
            rdOrta.AutoSize = true;
            rdOrta.Location = new Point(101, 37);
            rdOrta.Name = "rdOrta";
            rdOrta.Size = new Size(48, 19);
            rdOrta.TabIndex = 1;
            rdOrta.TabStop = true;
            rdOrta.Text = "Orta";
            rdOrta.UseVisualStyleBackColor = true;
            // 
            // rdZor
            // 
            rdZor.AutoSize = true;
            rdZor.Location = new Point(166, 37);
            rdZor.Name = "rdZor";
            rdZor.Size = new Size(43, 19);
            rdZor.TabIndex = 2;
            rdZor.TabStop = true;
            rdZor.Text = "Zor";
            rdZor.UseVisualStyleBackColor = true;
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 349);
            Controls.Add(btnGiris);
            Controls.Add(grpSeviye);
            Controls.Add(grpKullanici);
            Name = "frmGiris";
            Text = "frmGiris";
            grpKullanici.ResumeLayout(false);
            grpKullanici.PerformLayout();
            grpSeviye.ResumeLayout(false);
            grpSeviye.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpKullanici;
        private Label lblSoyad;
        private Label lblAd;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Button btnGiris;
        private GroupBox grpSeviye;
        private RadioButton rdZor;
        private RadioButton rdOrta;
        private RadioButton rdKolay;
    }
}