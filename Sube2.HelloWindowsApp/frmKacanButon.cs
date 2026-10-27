using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sube2.HelloWindowsApp
{
    public partial class frmKacanButon : Form
    {
        int skor = 0;

        public frmKacanButon()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            var rnd = new Random();
            int x = rnd.Next(this.ClientSize.Width - btnKac.Width - pnlinfo.Width);
            int y = rnd.Next(this.ClientSize.Height - btnKac.Height);
            btnKac.Location = new Point(x, y);
            skor++;
            lblSkor.Text = skor.ToString();
        }

        private void frmKacanButon_SizeChanged(object sender, EventArgs e)
        {
            pnlinfo.Location = new Point(this.ClientSize.Width - pnlinfo.Width, 0);
            pnlinfo.Height = this.ClientSize.Height;
        }
    }
}
