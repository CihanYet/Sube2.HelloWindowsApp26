using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sube2.HelloWindowsApp
{
    public partial class frmAcilan : Form
    {
        frmBaslangic baslangic;
        public frmAcilan(frmBaslangic baslangic)
        {
            InitializeComponent();
            this.baslangic = baslangic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // baslangic.Text = txtBaslik.Text;
            Application.OpenForms["frmBaslangic"].Text = txtBaslik.Text;
        }
    }
}
