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
    public partial class NewHastag : UserControl
    {
        public NewHastag()
        {
            InitializeComponent();
        }

        private void panelHastag_Click(object sender, EventArgs e)
        {

        }

        private void panelHastag_MouseHover(object sender, EventArgs e)
        {
            pbHastag.Image = Properties.Resources.hastagBold;
            panelHastag.BackColor = Color.Thistle;
        }

        private void panelHastag_MouseLeave(object sender, EventArgs e)
        {
            pbHastag.Image = Properties.Resources.hastag;
            panelHastag.BackColor = Color.LavenderBlush;
        }

        private void Hastag_Load(object sender, EventArgs e)
        {
            lblHashtag.AutoSize = true;
            lblPosts.AutoSize = true;
        }

        private void panelHastag_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
