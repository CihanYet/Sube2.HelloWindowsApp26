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
        public frmKacanButon()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            var rnd = new Random();
            int x = rnd.Next(this.ClientSize.Width - btnKac.Width);
            int y = rnd.Next(this.ClientSize.Height - btnKac.Height);
            btnKac.Location = new Point(x, y);
        }
    }
}
