using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sube2.HelloWindowsApp
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {


            if (!BoslukVarMi(this.Controls["grpKullanici"].Controls, "Z"))
            {
                var frm = new frmKacanButon(txtAd.Text, txtSoyad.Text);
                if (rdKolay.Checked)
                {
                    frm.Size = new Size(300, 300);
                }
                else if (rdOrta.Checked)
                {
                    frm.Size = new Size(500, 500);
                }
                else if(rdZor.Checked)
                {
                    frm.Size = new Size(800, 800);
                }
                else
                {
                    MessageBox.Show("Seviye Seçiniz!");
                    return;
                }
                frm.Show();
            }
            else
            {
                MessageBox.Show("Tüm Alanlar Zorunludur!");
            }
        }
        bool BoslukVarMi(Control.ControlCollection controls, string karakter)
        {
            bool sonuc = false;
            foreach (Control item in controls)
            {
                if (item is TextBox && item.Tag != null && item.Tag.ToString() == karakter && item.Text == String.Empty)
                {
                    item.BackColor = Color.Red;
                    sonuc = true;
                }
            }
            //if (sonuc)
            //{
            //    MessageBox.Show("Tüm alanlar zorunludur");
            //}
            return sonuc;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            //if (txt.Text == String.Empty)
            //{
            //    txt.BackColor = Color.White;
            //}
            //else
            //{
            //    txt.BackColor = Color.Red;
            //}

            txt.BackColor = txt.Text == String.Empty ? Color.Red : Color.White;

        }
    }
}
