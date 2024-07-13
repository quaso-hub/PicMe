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
    public partial class FormAnotherUser : Form
    {
        private User user;
        private User currentUser;
        private bool isFollow = false;

        public FormAnotherUser(User user, User currentUser)
        {
            InitializeComponent();
            this.user = user;
            this.currentUser = currentUser;
            lblName.Text = user.Username;
            lblEmail.Text = user.Email;
            CheckFriendshipStatus();
        }

        private void UpdateUserStats()
        {
            lblFollowers.Text = Friend.GetFollowers(user.Id).Count.ToString();
            lblFollowing.Text = Friend.GetFollowing(user.Id).Count.ToString();
        }
        private void CheckFriendshipStatus()
        {
            isFollow = Friend.AreFriends(currentUser.Id, user.Id);
            btnFollow.Image = isFollow ? Properties.Resources.alreadyUserBold : Properties.Resources.addUser;
            lblFol.Visible = !isFollow;
            lblFoling.Visible = isFollow;
            UpdateUserStats();
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            if (isFollow)
            {
                Friend.RemoveFriend(currentUser.Id, user.Id);
                MessageBox.Show("Pertemanan telah dibatalkan.");
            }
            else
            {
                Friend.SendFriendRequest(currentUser.Id, user.Id);
                MessageBox.Show("Permintaan pertemanan telah dikirim.");
            }
            CheckFriendshipStatus();
            UpdateUserStats();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.BackHover;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.Back;
        }

        private void FormAnotherUser_Load(object sender, EventArgs e)
        {
            lblFolw.AutoSize = true;
            lblPosting.AutoSize = true;
            lblFolin.AutoSize = true;
            lblName.AutoSize = true;
            lblEmail.AutoSize = true;
            lblFollowers.AutoSize = true;
            lblPost.AutoSize = true;
            lblFollowing.AutoSize = true;
            lblFol.AutoSize = true;
            lblFoling.AutoSize = true;

            //populateSmallPost();
            CheckFriendshipStatus();
            lblName.Text = user.Username;
            lblEmail.Text = user.Email;
            lblFol.Visible = !isFollow;
            lblFoling.Visible = isFollow;
        }

        private void lblFolw_Click(object sender, EventArgs e)
        {
            OpenFormWithOverlay(new FormFollowing(user, true));
        }

        private void lblFolin_Click(object sender, EventArgs e)
        {
            OpenFormWithOverlay(new FormFollowing(user, false));
        }

        private void OpenFormWithOverlay(Form formToDisplay)
        {
            Form overlayForm = new Form();

            try
            {
                overlayForm.StartPosition = FormStartPosition.Manual;
                overlayForm.FormBorderStyle = FormBorderStyle.None;
                overlayForm.Opacity = 0.8d;
                overlayForm.BackColor = Color.Black;
                overlayForm.Size = this.Size;
                overlayForm.Location = this.Location;
                overlayForm.TopMost = false;
                overlayForm.ShowInTaskbar = false;

                overlayForm.Show(this);
                overlayForm.BringToFront();

                formToDisplay.TopMost = true;
                formToDisplay.StartPosition = FormStartPosition.CenterParent;

                formToDisplay.ShowDialog();

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

        //private void populateSmallPost()
        //{
        //    panelPost.SuspendLayout();
        //    Post[] listItem = new Post[32];

        //    for (int i = 0; i < listItem.Length; i++)
        //    {
        //        listItem[i] = new Post();
        //    }

        //    if (panelPost.Controls.Count < 0)
        //    {
        //        panelPost.Controls.Clear();
        //    }
        //    else
        //    {
        //        foreach (var item in listItem)
        //        {
        //            panelPost.Controls.Add(item);
        //        }
        //    }
        //    panelPost.ResumeLayout();
        //}

        private void lblFolw_MouseHover(object sender, EventArgs e)
        {
            lblFolw.ForeColor = Color.Blue;
        }

        private void lblFolw_MouseLeave(object sender, EventArgs e)
        {
            lblFolw.ForeColor = Color.Silver;
        }

        private void lblFolin_MouseHover(object sender, EventArgs e)
        {
            lblFolin.ForeColor = Color.Blue;
        }

        private void lblFolin_MouseLeave(object sender, EventArgs e)
        {
            lblFolin.ForeColor = Color.Silver;
        }
    }
}
