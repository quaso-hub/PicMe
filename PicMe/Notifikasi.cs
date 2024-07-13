using MyPics_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicMe
{
    public partial class Notifikasi : UserControl
    {

        public Notifikasi()
        {
            InitializeComponent();

        }
        public void SetNotification(string message)
        {
            lblNotif.Text = message;
        }
        private void Notifikasi_Load(object sender, EventArgs e)
        {
            lblNotif.AutoSize = true;
        }

        private void Notifikasi_MouseHover(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.DeepPink;
            pbLonceng_MouseHover(sender, e);
        }

        private void Notifikasi_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            this.BackColor = Color.LightBlue;
            pbLonceng_MouseLeave(sender, e);
        }

        private void pbLonceng_MouseHover(object sender, EventArgs e)
        {
            pbLonceng.Image = Properties.Resources.loncengBold;
        }

        private void pbLonceng_MouseLeave(object sender, EventArgs e)
        {
            pbLonceng.Image = Properties.Resources.lonceng;
        }
    }
}
