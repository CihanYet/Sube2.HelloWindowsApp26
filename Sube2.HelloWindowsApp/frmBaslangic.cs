using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sube2.HelloWindowsApp
{
    public partial class frmBaslangic : Form
    {
        public frmBaslangic()
        {
            InitializeComponent();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            var frm = new frmAcilan(this);
            frm.Show(); 
        }
    }
}
