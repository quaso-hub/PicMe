using MyPics_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PicMe
{
    public partial class FormFollowers : Form
    {
        private User currentUser;
        private List<User> allUsers;

        public FormFollowers(User user)
        {
            InitializeComponent();
            currentUser = user;
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
            allUsers = Friend.GetFollowers(currentUser.Id);
            DisplayUsers(allUsers);
        }

        private void DisplayUsers(List<User> users)
        {
            panelFol.Controls.Clear();
            foreach (var user in users)
            {
                var userControl = new Followers(user, currentUser);
                if (user.Id == currentUser.Id)
                {
                    userControl.DisableRemoveButton();
                }
                panelFol.Controls.Add(userControl);
            }
        }

        private void FormFollow_Load(object sender, EventArgs e)
        {
            lbl1.AutoSize = true;
            LoadUsers();
        }
    }
}
