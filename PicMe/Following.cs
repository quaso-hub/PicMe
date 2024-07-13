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
    public partial class Following : UserControl
    {
        private User follower;
        private User currentUser;

        public Following(User follower, User currentUser)
        {
            InitializeComponent();
            this.follower = follower;
            this.currentUser = currentUser;
            lblUser.Text = follower.Username;
            lblCap.Text = "Hari yang indah";
            CheckFriendshipStatus();
        }

        private void CheckFriendshipStatus()
        {
            if (Friend.AreFriends(currentUser.Id, follower.Id))
            {
                btnFollow.Text = "Following";
                btnFollow.IdleFillColor = Color.Gray;
                btnFollow.OnIdleState.FillColor = Color.Gray;
                btnFollow.OnPressedState.FillColor = Color.Gray;
                pbFollowing.Image = Properties.Resources.alreadyUserBold;
            }
            else
            {
                btnFollow.Text = "Follow";
                btnFollow.IdleFillColor = Color.DodgerBlue;
                btnFollow.OnIdleState.FillColor = Color.DodgerBlue;
                btnFollow.OnPressedState.FillColor = Color.DodgerBlue;
                pbFollowing.Image = Properties.Resources.addUserBold;
            }
        }

        private void Following_Load(object sender, EventArgs e)
        {
            lblUser.AutoSize = true;
            lblCap.AutoSize = true;
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            if (btnFollow.Text == "Following")
            {
                var result = MessageBox.Show("Are you sure you want to Unfollow?", "Confirm Unfollow", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Friend.RemoveFriend(currentUser.Id, follower.Id);
                    btnFollow.Text = "Follow";
                    btnFollow.IdleFillColor = Color.DodgerBlue;
                    btnFollow.OnIdleState.FillColor = Color.DodgerBlue;
                    btnFollow.OnPressedState.FillColor = Color.DodgerBlue;
                    pbFollowing.Image = Properties.Resources.addUserBold;
                }
            }
            else if (btnFollow.Text == "Follow")
            {
                var result = MessageBox.Show("Are you sure you want to Follow?", "Confirm Follow", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Friend.SendFriendRequest(currentUser.Id, follower.Id);
                    btnFollow.Text = "Following";
                    btnFollow.IdleFillColor = Color.Gray;
                    btnFollow.OnIdleState.FillColor = Color.Gray;
                    btnFollow.OnPressedState.FillColor = Color.Gray;
                    pbFollowing.Image = Properties.Resources.alreadyUserBold;
                }
            }
        }

        public void DisableFollowButton()
        {
            btnFollow.Enabled = false;
        }
    }
}
