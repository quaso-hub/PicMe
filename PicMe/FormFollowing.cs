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
    public partial class FormFollowing : Form
    {

        private User viewedUser;
        private bool isFollowersView;
        private List<User> allUsers;

        public FormFollowing(User viewedUser, bool isFollowersView)
        {
            InitializeComponent();
            this.viewedUser = viewedUser;
            this.isFollowersView = isFollowersView;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.closeBold;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.close;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text.ToLower();
            List<User> filteredUsers = allUsers.Where(user => user.Username.ToLower().Contains(searchTerm)).ToList();
            DisplayUsers(filteredUsers);
        }
        private void LoadUsers()
        {
            if (isFollowersView)
            {
                allUsers = Friend.GetFollowers(viewedUser.Id);
                lbl1.Text = "Followers";
            }
            else
            {
                allUsers = Friend.GetFollowing(viewedUser.Id);
                lbl1.Text = "Following";
            }

            DisplayUsers(allUsers);
        }

        private void DisplayUsers(List<User> users)
        {
            panelFol.Controls.Clear();
            foreach (var user in users)
            {
                var userControl = new Following(user, viewedUser);
                if (user.Id == viewedUser.Id)
                {
                    userControl.DisableFollowButton();
                }
                panelFol.Controls.Add(userControl);
            }
        }

        private void FormFollow2_Load(object sender, EventArgs e)
        {
            lbl1.AutoSize = true;
            LoadUsers();
        }
    }
}
