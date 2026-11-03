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
            //if (txtAd.Text.Trim() == String.Empty || txtSoyad.Text.Trim() == String.Empty)
            //{
            //    MessageBox.Show("Tüm Alanlar Zorunludur");
            //    return;
            //}

            foreach (Control item in this.Controls["grpKullanici"].Controls)
            {
                if (item is TextBox && item.Tag != null && item.Tag.ToString() == "Z" && item.Text == String.Empty)
                {
                    MessageBox.Show("Tüm alanlar zorunludur");
                    //item.BackColor = Color.Red;
                    return;
                }
            }

            var frm = new frmKacanButon(txtAd.Text, txtSoyad.Text);
            //frm.lblKullanici.Text = $"{txtAd.Text} {txtSoyad.Text}";
            frm.Show();
        }
    }
}
