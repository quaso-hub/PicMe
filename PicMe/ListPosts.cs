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
    public partial class ListPosts : UserControl
    {
        private bool isLiked = false;
        private bool isReposted = false;
        private int likesCount;
        private int repostsCount;
        public event EventHandler CloseRequested;

        public ListPosts()
        {
            InitializeComponent();
            InitializeButtonImages();
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }

        private void InitializeButtonImages()
        {
            //btnClose.Image = Properties.Resources.close; 
            btnKomen.Image = Properties.Resources.send;
        }

        private void ListPosts_Load(object sender, EventArgs e)
        {
            likesCount = 0;
            repostsCount = 0;
        }

        private Image _picture;

        [Category("Custom Props")]
        public Image PicturePosts
        {
            get { return _picture; }
            set { _picture = value; pbPicture.Image = value; }
        }

        private string _caption;
        [Category("Custom Props")]
        public string Caption
        {
            get { return _caption; }
            set { _caption = value; lblCap.Text = value; }
        }

        private string _username;
        [Category("Custom Props")]
        public string Username
        {
            get { return _username; }
            set { _username = value; lblUser.Text = value; }
        }

        private DateTime _postDate;
        [Category("Custom Props")]
        public DateTime PostDate
        {
            get { return _postDate; }
            set { _postDate = value; lblSubmit.Text = value.ToString("dd/MM/yyyy"); }
        }

        private void btnKomen_Click(object sender, EventArgs e)
        {
            
            btnKomen.Image = Properties.Resources.sendBold;
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            isLiked = !isLiked;
            likesCount += isLiked ? 1 : -1;
            UpdateLikeButtonImage();
        }

        private void btnRepost_Click(object sender, EventArgs e)
        {
            string message = isReposted ? "Do you want to undo the repost of this item?" : "Are you sure you want to repost this item?";
            string caption = isReposted ? "Undo Repost" : "Repost";
            var buttons = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(message, caption, buttons, icon);

            if (result == DialogResult.Yes)
            {
                isReposted = !isReposted;
                repostsCount += isReposted ? 1 : -1;
                UpdateRepostButtonImage();
            }
        }

        private void btnLike_MouseHover(object sender, EventArgs e)
        {
            btnLike.Image = isLiked ? Properties.Resources.heart : Properties.Resources.likebold;
        }

        private void btnRepost_MouseHover(object sender, EventArgs e)
        {
            btnRepost.Image = isReposted ? Properties.Resources.rebold : Properties.Resources.re;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            //btnClose.Image = Properties.Resources.closeBold;
        }

        private void btnKomen_MouseHover(object sender, EventArgs e)
        {
            btnKomen.Image = Properties.Resources.send;
        }

        private void UpdateLikeButtonImage()
        {
            lblLike.Text = $"{likesCount}";
            btnLike.Image = isLiked ? Properties.Resources.likebold : Properties.Resources.heart;
        }

        private void UpdateRepostButtonImage()
        {
            lblRepost.Text = $"{repostsCount}";
            btnRepost.Image = isReposted ? Properties.Resources.rebold : Properties.Resources.re;
        }
    }
}
