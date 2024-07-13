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
    public partial class NotFound404 : UserControl
    {
        public NotFound404()
        {
            InitializeComponent();
        }

        private void panel404_MouseHover(object sender, EventArgs e)
        {
            pb404.Image = Properties.Resources._Bold;
            panel404.BackColor = Color.Thistle;
        }

        private void panel404_MouseLeave(object sender, EventArgs e)
        {
            pb404.Image = Properties.Resources._;
            panel404.BackColor = Color.LavenderBlush;
        }

        private void NotFound404_Load(object sender, EventArgs e)
        {
            lbl404.AutoSize = true;
        }
    }
}
