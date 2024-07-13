using MyPics_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicMe
{
    public partial class AddPost : Form
    {
        private bool imageUploaded = false;
        private bool isPublic = false;
        private bool isCommentingOff = false;
        private bool isDateOff = false;
        private User currentUser;
        private List<User> friendsList;

        public AddPost(User user)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            currentUser = user;
            LoadFriends();
            InitializeDatePicker();
        }

        private void InitializeDatePicker()
        {
            dateTimePicker.MinDate = DateTime.Now;
            dateTimePicker.MaxDate = DateTime.Now;
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.Enabled = false;
        }

        private void LoadFriends()
        {
            var friendsList = Friend.GetFriends(currentUser.Id);
            cbTag.DataSource = friendsList;
            cbTag.DisplayMember = "Username";
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            if (imageUploaded)
            {
                var result = MessageBox.Show("Do you want to discard this image?", "Confirm Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    pbPost.Image = null;
                    btnUp.BringToFront();
                    imageUploaded = false;
                }
            }
            else
            {
                this.Close();
            }
        }


        private void btnUp_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a picture";
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbPost.Image = new Bitmap(openFileDialog.FileName);
                    pbPost.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbPost.ImageLocation = openFileDialog.FileName;
                    pbPost.BringToFront();
                    imageUploaded = true;
                }
            }
        }

        private void btnUp_MouseHover(object sender, EventArgs e)
        {
            btnUp.Image = Properties.Resources.imageHover;
        }

        private void btnUp_MouseLeave(object sender, EventArgs e)
        {
            btnUp.Image = Properties.Resources.image;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.closeBold;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.close;
        }

        private void AddPost_Load(object sender, EventArgs e)
        {
            lbl2.AutoSize = true;
            lblUser.AutoSize = true;
            lblPrivasi.AutoSize = true;
            lblSetPrivasi.AutoSize = true;
            lblKomen.AutoSize = true;
            lblSetKomen.AutoSize = true;
            lbl5.AutoSize = true;
            lblsetdate.AutoSize = true;
            lb7.AutoSize = true;   
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imageUploaded)
            {
                var filename = pbPost.ImageLocation;
                var inputDate = DateTime.Now;
                var eventTime = isDateOff ? DateTime.Now : dateTimePicker.Value;
                var status = isPublic ? statusPost.public_status : statusPost.private_status;
                var caption = tbCaps.Text;

                var picture = new Picture(0, filename, inputDate, eventTime, currentUser, status, caption);
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                Picture.uploadFoto(picture, projectDirectory);

                var hashtags = cbTag.Text.Split(' ')
                    .Where(tag => tag.StartsWith("#"))
                    .Select(tag => new Hashtag(tag, picture))
                    .ToList();
                foreach (var hashtag in hashtags)
                {
                    Hashtag.insertHashtag(hashtag);
                }

    
                var selectedFriends = cbTag.Items.Cast<User>().ToList();
                foreach (var friend in selectedFriends)
                {
                    var tagging = new Tagging(picture, friend, repost.no);
                    Tagging.insertTagging(tagging);
                }

                MessageBox.Show("Post sent successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please upload an image first.");
            }
        }



        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            btnNext.Image = Properties.Resources.sendBold;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.Image = Properties.Resources.send;
        }

        private void btnPrivasi_Click(object sender, EventArgs e)
        {
            isPublic = !isPublic;
            btnPrivasi.Image = isPublic ? Properties.Resources.onBold : Properties.Resources.off;
            lblSetPrivasi.Text = isPublic ? "public" : "private";
        }

        private void btnKomen_Click(object sender, EventArgs e)
        {
            isCommentingOff = !isCommentingOff;
            btnKomen.Image = isCommentingOff ? Properties.Resources.onBold : Properties.Resources.off;
            lblSetKomen.Text = isCommentingOff ? "on" : "off";
        }

        private void btnoffdate_Click(object sender, EventArgs e)
        {
            isDateOff = !isDateOff;
            btnoffdate.Image = isDateOff? Properties.Resources.onBold : Properties.Resources.off;
            lblsetdate.Text = isDateOff ? "on" : "off";
            dateTimePicker.Enabled = !isDateOff;
        }

        private void cbTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTag.SelectedItem != null)
            {
                var selectedFriend = cbTag.SelectedItem as User;
                if (!string.IsNullOrEmpty(tbTag.Text))
                {
                    tbTag.AppendText(" ");
                }
                tbTag.AppendText("@" + selectedFriend.Username);
            }
        }

        private void tbHastag_TextChanged(object sender, EventArgs e)
        {
            tbHastag.Focus();
        }

        private void tbCaps_TextChanged(object sender, EventArgs e)
        {
            tbCaps.Focus();
        }
    }
}