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
    public partial class BeforeSearch : UserControl
    {
        public event EventHandler OpenSearchFormRequested;
        public BeforeSearch()
        {
            InitializeComponent();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTekan_Click(object sender, EventArgs e)
        {
            OpenSearchFormRequested?.Invoke(this, EventArgs.Empty);
            
        }
    }
}
