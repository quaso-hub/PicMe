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
    public partial class Search : UserControl
    {
        public event EventHandler<string> SearchTypeChanged;
        public Search()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            SearchTypeChanged?.Invoke(this, "foto");
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            SearchTypeChanged?.Invoke(this, "people");
        }

        private void btnHastag_Click(object sender, EventArgs e)
        {
            SearchTypeChanged?.Invoke(this, "hashtag");
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.Image = Properties.Resources.newSearchBold;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.Image = Properties.Resources.newSearch;
        }
    }
}
