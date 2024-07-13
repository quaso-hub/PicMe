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
    public partial class BannerNotif : UserControl
    {
        public BannerNotif()
        {
            InitializeComponent();
        }

        private void BannerNotif_Load(object sender, EventArgs e)
        {
            lblNotif.AutoSize = true;
            lblNotif2.AutoSize = true;
        }
    }
}
