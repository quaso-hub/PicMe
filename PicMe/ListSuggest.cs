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
    public partial class ListSuggest : UserControl
    {
        public ListSuggest()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }

        private string _trends;
        private string _posts;
        private Color _iconBack;

        [Category("Custom Props")]
        public string Trends
        {
            get { return _trends; }
            set { _trends = value; btnTrends.Text = value; }
        }

        [Category("Custom Props")]
        public string Posts
        {
            get { return _posts; }
            set { _posts = value; lblPosts.Text = value; }
        }

        [Category("Custom Props")]
        public Color IconBack
        {
            get { return _iconBack; }
            set { _iconBack = value; panelSuggest.BackColor = value; }
        }

        private void panelSuggest_Click(object sender, EventArgs e)
        {

        }

        private void ListSuggest_Load(object sender, EventArgs e)
        {
            lblPosts.AutoSize = true;
            lblfu.AutoSize = true;
        }

        private void btnTrends_Click(object sender, EventArgs e)
        {

        }
    }
}
