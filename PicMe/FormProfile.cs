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
    public partial class FormProfile : Form
    {
        private bool isNotif = false;
        private User currentUser;
        private bool notificationsEnabled = true;
        private FormHome formHome;
        public FormProfile(User user)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            currentUser = user;
            lblName.Text = user.Username;
            lblEmail.Text = user.Email;
            LoadUserPosts();
            UpdateUserStats();

        }

        private void LoadUserPosts()
        {
            var userPosts = Picture.GetUserPosts(currentUser.Id);
            lblPost.Text = userPosts.Count.ToString();

            panelPost.Controls.Clear();
            foreach (var post in userPosts)
            {
                var listItem = new ListPosts
                {
                    PicturePosts = Image.FromFile(post.Filename),
                    Caption = post.Caption,
                    Username = currentUser.Username,
                    PostDate = post.InputDate
                };

                panelPost.Controls.Add(listItem);
            }
        }
        public void UpdatePostCount()
        {
            int postCount = Picture.GetUserPosts(currentUser.Id).Count;
            lblPost.Text = $"{postCount} Post";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome(currentUser);
            formHome.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormChange formChange = new FormChange(currentUser);
            formChange.Show();
            this.Hide();
            UpdateUserStats();
            UpdatePostCount();
        }

        private void SetButtonHoverEffects(PictureBox btn, Image hoverImage, Image normalImage)
        {
            btn.MouseHover += (sender, e) => {
                btn.Image = hoverImage;
            };

            btn.MouseLeave += (sender, e) => {
                btn.Image = normalImage;
            };
        }
        private void HoverLeaverButtons()
        {
            SetButtonHoverEffects(btnBack, Properties.Resources.BackHover, Properties.Resources.Back);
            SetButtonHoverEffects(btnEdit, Properties.Resources.EditHover, Properties.Resources.EditWhite);
            SetButtonHoverEffects(btnLogout, Properties.Resources.Sign_in___btn, Properties.Resources.Sign_in___btn50_);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form = new FormLogin();
            form.Show();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            //populateSmallPost();
            HoverLeaverButtons();
            lblFolw.AutoSize = true;
            lblPosting.AutoSize = true;
            lblFolin.AutoSize = true;
            lbl4.AutoSize = true;
            lblName.AutoSize = true;
            lblEmail.AutoSize = true;
            lblFollowers.AutoSize = true;
            lblPost.AutoSize = true;
            lblFollowing.AutoSize = true;
            lblNotif.AutoSize = true;
            lblSetNotif.AutoSize = true;

            lblName.Text = currentUser.Username;
            lblEmail.Text = currentUser.Email;
            UpdateUserStats();
        }
        private void UpdateUserStats()
        {
            lblFollowers.Text = Friend.GetFollowers(currentUser.Id).Count.ToString();
            lblFollowing.Text = Friend.GetFollowing(currentUser.Id).Count.ToString();
        }

        private void btnNotif_Click(object sender, EventArgs e)
        {
            isNotif = !isNotif;
            btnNotif.Image = isNotif ? Properties.Resources.onBold : Properties.Resources.off;
            lblSetNotif.Text = isNotif ? "on" : "off";

            notificationsEnabled = !notificationsEnabled;
            btnNotif.Text = notificationsEnabled ? "Turn off notifications" : "Turn on notifications";

            formHome.ToggleNotifications(notificationsEnabled);
        }

        private void lblFolw_Click(object sender, EventArgs e)
        {
            Form fmovrelay = new Form();

            try
            {
                using (FormFollowers frm = new FormFollowers(currentUser))
                {
                    fmovrelay.StartPosition = FormStartPosition.Manual;
                    fmovrelay.FormBorderStyle = FormBorderStyle.None;
                    fmovrelay.Opacity = 0.8d;
                    fmovrelay.BackColor = Color.Black;
                    fmovrelay.Size = this.Size;
                    fmovrelay.Location = this.Location;
                    fmovrelay.TopMost = false;
                    fmovrelay.ShowInTaskbar = false;
                    fmovrelay.Show();

                    frm.TopMost = true;
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fmovrelay.Dispose();
            }
        }

        private void lblFolin_Click(object sender, EventArgs e)
        {
            Form fmovrelay = new Form();

            try
            {
                using (FormFollowing frm = new FormFollowing(currentUser,false))
                {
                    fmovrelay.StartPosition = FormStartPosition.Manual;
                    fmovrelay.FormBorderStyle = FormBorderStyle.None;
                    fmovrelay.Opacity = 0.8d;
                    fmovrelay.BackColor = Color.Black;
                    fmovrelay.Size = this.Size;
                    fmovrelay.Location = this.Location;
                    fmovrelay.TopMost = false;
                    fmovrelay.ShowInTaskbar = false;
                    fmovrelay.Show();

                    frm.TopMost = true;
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fmovrelay.Dispose();
            }
        }

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
    }
}
