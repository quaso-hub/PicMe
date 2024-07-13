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
    public partial class _NewUser : UserControl
    {
        private User user;
        private User currentUser;

        public _NewUser(User user, User currentUser)
        {
            InitializeComponent();
            this.user = user;
            this.currentUser = currentUser;
            lblUser.Text = user.Username;
            lblBio.Text = user.Email;
        }

        private void _User_Load(object sender, EventArgs e)
        {
            lblBio.AutoSize = true;
            lblUser.AutoSize = true;
        }

        private void panelUser_Click(object sender, EventArgs e)
        {
            OpenAnotherUser();
        }

        public void OpenAnotherUser()
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

                using (FormAnotherUser userDialog = new FormAnotherUser(user, currentUser))
                {
                    userDialog.TopMost = true;
                    if (userDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Handle jika pengguna meng-klik OK, misal update UI atau database
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

        private void panelUser_MouseHover(object sender, EventArgs e)
        {
            pbUser.Image = Properties.Resources.newUserBold;
            panelUser.BackColor = Color.Thistle;
        }

        private void panelUser_MouseLeave(object sender, EventArgs e)
        {
            pbUser.Image = Properties.Resources.newUser;
            panelUser.BackColor = Color.LavenderBlush;
        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
