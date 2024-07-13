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
    public partial class ListItem : UserControl
    {
        private bool isLiked = false;
        private bool isLikes = false;
        private bool isKomen = false;
        private bool isRepost = false;
        private bool isReposted = false;
        private int likesCount;
        private int repostsCount;
        private int commentsCount;

        public ListItem()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            likesCount = 0;
            repostsCount = 0;
            commentsCount = 0;
            UpdateUI();
        }

        private void btnLike_MouseEnter(object sender, EventArgs e)
        {
            //isLiked = !isLiked;
            //if (isLiked)
            //{
            //    btnLike.Image = Properties.Resources.likebold;
            //}
            //else
            //{
            //    btnLike.Image = Properties.Resources.heart;
            //}
            //btnLike.Image = isLikes ? Properties.Resources.heart : Properties.Resources.likebold;
            btnLike.Image = isLiked ? Properties.Resources.heart : Properties.Resources.likebold;
        }

        private void btnKomen_MouseEnter(object sender, EventArgs e)
        {
            //isKomen = !isKomen;
            //if (isKomen)
            //{
            //    btnKomen.Image = Properties.Resources.komen2;
            //}
            //else
            //{
            //    btnKomen.Image = Properties.Resources.komenbold;
            //}
            //btnRepost.Image = isReposted ? Properties.Resources.re : Properties.Resources.rebold;
        }

        private void btnRepost_MouseEnter(object sender, EventArgs e)
        {
            //isRepost = !isRepost;
            //if (isRepost)
            //{
            //    btnRepost.Image = Properties.Resources.re;
            //}
            //else
            //{
            //    btnRepost.Image = Properties.Resources.rebold;
            //}
        }

        private string _username;
        private string _time;
        private int _likes;
        private int _comments;
        private int _reposts;
        private Image _postImage;

        [Category("Custom Props")]
        public string Username
        {
            get { return _username; }
            set { _username = value; lblUsername.Text = value; }
        }

        [Category("Custom Props")]
        public string Time
        {
            get { return _time; }
            set { _time = value; lblDate.Text = value; }
        }

        [Category("Custom Props")]
        public int Likes
        {
            get { return _likes; }
            set { _likes = value; lblLike.Text = value.ToString("N0"); }
        }

        [Category("Custom Props")]
        public int Comments
        {
            get { return _comments; }
            set { _comments = value; lblKomen.Text = value.ToString("N0"); }
        }

        [Category("Custom Props")]
        public int Reposts
        {
            get { return _reposts; }
            set { _reposts = value; lblRepost.Text = value.ToString("N0"); }
        }

        [Category("Custom Props")]
        public Image PostImage
        {
            get { return _postImage; }
            set { _postImage = value; pbPosting.Image = value; }
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



        public void btnLike_Click(object sender, EventArgs e)
        {
            //bool originallyLiked = isLikes;
            //isLikes = !isLikes;

            //if (originallyLiked != isLikes)
            //{
            //    likesCount += isLikes ? 1 : -1;
            //    UpdateLikeButtonImage();
            //    lblLike.Text = $"{likesCount}";
            //}

            isLiked = !isLiked;
            likesCount += isLiked ? 1 : -1;
            UpdateLikeButtonImage();
        }

        public void btnRepost_Click(object sender, EventArgs e)
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

        public void btnKomen_Click(object sender, EventArgs e)
        {
            //ShowCommentDialog();
            OpenCommentDialog();
        }

        private void UpdateUI()
        {
            //btnLike.Image = isLiked ? Properties.Resources.likebold : Properties.Resources.heart;
            //btnRepost.Image = isReposted ? Properties.Resources.rebold : Properties.Resources.re;
            lblLike.Text = likesCount.ToString();
            lblRepost.Text = repostsCount.ToString();
        }
        private void UpdateCommentsDisplay()
        {
            lblKomen.Text = $"{commentsCount}";  
        }

        private void ListItem_Load(object sender, EventArgs e)
        {
            lblStatus.AutoSize = true;
        }

        private void panelInteraktif_Paint(object sender, PaintEventArgs e)
        {

        }


        //private void ShowCommentDialog()
        //{
        //    using (CommentDialog commentDialog = new CommentDialog())
        //    {
        //        if (commentDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            commentsCount++;
        //            lblKomen.Text = commentsCount.ToString();
        //            btnKomen.Image = Properties.Resources.komenbold;
        //        }
        //        else
        //        {
        //            btnKomen.Image = Properties.Resources.komen2;
        //        }
        //    }
        //}

        // Ini adalah event handler atau method yang memanggil CommentDialog
        public void OpenCommentDialog()
        {
            Form overlayForm = new Form();
            try
            {
                overlayForm.StartPosition = FormStartPosition.Manual;
                overlayForm.FormBorderStyle = FormBorderStyle.None;
                overlayForm.Opacity = 0.5d;
                overlayForm.BackColor = Color.Black;
                overlayForm.Size = this.ParentForm.Size;
                overlayForm.Location = this.ParentForm.Location;
                overlayForm.TopMost = true;
                overlayForm.ShowInTaskbar = false;
                overlayForm.Show();

                using (CommentDialog commentDialog = new CommentDialog())
                {
                    commentDialog.TopMost = true;
                    if (commentDialog.ShowDialog() == DialogResult.OK)
                    {
                        commentsCount++;
                        lblKomen.Text = commentsCount.ToString();
                        btnKomen.Image = Properties.Resources.komenbold;
                    }
                    else
                    {
                        btnKomen.Image = Properties.Resources.komen2;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                overlayForm.Dispose();
            }
        }

    }
}
