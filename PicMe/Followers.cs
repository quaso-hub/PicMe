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
    public partial class Followers : UserControl
    {
        private User follower;
        private User currentUser;

        public Followers(User follower, User currentUser)
        {
            InitializeComponent();
            this.follower = follower;
            this.currentUser = currentUser;
            lblUser.Text = follower.Username;
            lblCap.Text = "Hari yang indah";
        }

        private void Followers_Load(object sender, EventArgs e)
        {
            lblUser.AutoSize = true;
            lblCap.AutoSize = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to remove?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Friend.RemoveFriend(currentUser.Id, follower.Id);
                btnRemove.Text = "Removed";
                btnRemove.ForeColor = Color.Gray;
                btnRemove.Enabled = false;
            }

        }
        public void DisableRemoveButton()
        {
            btnRemove.Enabled = false;
        }
    }
}
