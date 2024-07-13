using MyPics_Library;
using PicMe.Properties;
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
    public partial class FormHome : Form
    {
        private bool notificationsEnabled = true;
        bool siderbarExpand;
        bool accountCollapsed = true;
        const int accountStep = 100;
        private User currentUser;
        string lblUser;

        public FormHome(User user)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            currentUser = user;
            LoadNotifications();
        }


        private void LoadNotifications()
        {
            if (!notificationsEnabled) return;

            var notifications = Notif.GetUserNotifications(currentUser.Id);
            scroll.Controls.Clear();

            foreach (var notif in notifications)
            {
                Notifikasi notifControl = new Notifikasi();
                notifControl.SetNotification(notif.Message);
                scroll.Controls.Add(notifControl);
            }
        }
        public void ToggleNotifications(bool enable)
        {
            notificationsEnabled = enable;
            LoadNotifications();
        }

        public void DisplayUsername()
        {
            string displayName = currentUser.Username;
            if (displayName.Length > 8)
            {
                displayName = displayName.Substring(0, 8) + "...";
            }
            lblUser = displayName;
            btnAccount.Text = displayName;
        }




        private void FormHome_Load(object sender, EventArgs e)
        {
            UpdateDateTimeAndGreeting();
            InitializeSidebar();
            btnHome_Click(sender, e);
            DisplayUsername();
        }

        private void InitializeSidebar()
        {
            lblfu.AutoSize = true;
            lblGreet.Visible = false;
            sidebar.Width = sidebar.MinimumSize.Width;
            panelAccount.Height = panelAccount.MinimumSize.Height;
            panelFlow();
            btnLogout.Enabled = false;
            btnProfile.Enabled = false;
            SetButtonsEnabled(false);
        }

        private void UpdateDateTimeAndGreeting()
        {
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("dddd, dd MMMM");
            labelDate.Text = formattedDate;

            string greeting;
            if (now.Hour >= 1 && now.Hour <= 12)
            {
                greeting = $"Selamat pagi, {lblUser}!";
            }
            else if (now.Hour >= 13 && now.Hour <= 15)
            {
                greeting = $"Selamat siang, {lblUser}!";
            }
            else if (now.Hour >= 16 && now.Hour <= 18)
            {
                greeting = $"Selamat sore, {lblUser}!";
            }
            else { greeting = $"Selamat malam, {lblUser}!"; }

            lblGreet.Text = greeting;
        }

        private void panelFlow()
        {
            int panelSpacing = siderbarExpand ? 10 : 70;

            int sidebarCurrentWidth = sidebar.Width;

            int availableWidth = this.Width - sidebarCurrentWidth - (panelSpacing * 3);

            int panelAWidth = (int)(2.0 / 3.0 * availableWidth);
            int panelBWidth = availableWidth - panelAWidth;

            scroll.Location = new Point(sidebarCurrentWidth + panelSpacing, scroll.Location.Y);
            scroll.Width = panelAWidth;

            suggest.Location = new Point(scroll.Right + panelSpacing, suggest.Location.Y);
            suggest.Width = panelBWidth;
        }

        private void ToggleSidebar()
        {
            timerSidebar.Start();
        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            const int step = 300;
            if (siderbarExpand)
            {
                sidebar.Width -= step;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    siderbarExpand = false;
                    timerSidebar.Stop();
                    SetButtonsEnabled(false);
                    lblGreet.Visible = false;

                    if (!accountCollapsed)
                    {
                        panelAccount.Height = panelAccount.MinimumSize.Height;
                        btnLogout.Enabled = false;
                        btnProfile.Enabled = false;
                        accountCollapsed = true;
                    }
                }
            }
            else
            {
                sidebar.Width += step;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    lblGreet.Visible = true;
                    siderbarExpand = true;
                    timerSidebar.Stop();
                    SetButtonsEnabled(true);
                }
            }
            panelFlow();
        }

        private void SetButtonsEnabled(bool enabled)
        {
            btnHome.Enabled = enabled;
            btnSearch.Enabled = enabled;
            btnNotif.Enabled = enabled;
            btnPost.Enabled = enabled;
            btnAccount.Enabled = enabled;          
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            timerAccount.Start();
        }

        private void timerAccount_Tick(object sender, EventArgs e)
        {
            if (accountCollapsed)
            {
                panelAccount.Height += accountStep;
                panelAccount.Location = new Point(panelAccount.Location.X, panelAccount.Location.Y - accountStep);
                if (panelAccount.Height >= panelAccount.MaximumSize.Height)
                {
                    panelAccount.Height = panelAccount.MaximumSize.Height;
                    panelAccount.Location = new Point(panelAccount.Location.X, btnAccount.Location.Y - panelAccount.Height);
                    btnLogout.Enabled = true;
                    btnProfile.Enabled = true;
                    accountCollapsed = false;
                    timerAccount.Stop();
                }
            }
            else
            {
                panelAccount.Height -= accountStep;
                panelAccount.Location = new Point(panelAccount.Location.X, panelAccount.Location.Y + accountStep);
                if (panelAccount.Height <= panelAccount.MinimumSize.Height)
                {
                    panelAccount.Height = panelAccount.MinimumSize.Height;
                    panelAccount.Location = new Point(panelAccount.Location.X, btnAccount.Location.Y - panelAccount.Height);
                    btnLogout.Enabled = false;
                    btnProfile.Enabled = false;
                    accountCollapsed = true;
                    timerAccount.Stop();
                }
            }
        }

        private void btnSide_Click(object sender, EventArgs e)
        {
            ToggleSidebar();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            lblfu.Text = "Trends for You";
            LoadContent("Home");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblfu.Text = "Who to Follow";
            LoadContent("Search");
        }

        private void btnNotif_Click(object sender, EventArgs e)
        {
            lblfu.Text = "Trends for You";
            LoadContent("Notifications");
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Form fmovrelay = new Form();

            try
            {
                using (AddPost frm = new AddPost(currentUser))
                {
                    fmovrelay.StartPosition = FormStartPosition.Manual;
                    fmovrelay.FormBorderStyle = FormBorderStyle.None;
                    fmovrelay.Opacity = 0.5d;
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



        private void btnProfile_Click(object sender, EventArgs e)
        {
            FormProfile profile = new FormProfile(currentUser);
            profile.Show(this);
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }

        private void populatePosts()
        {
            scroll.SuspendLayout();
            ListItem[] listItem = new ListItem[20];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new ListItem();
                listItem[i].PostImage = Resources.OIP;
                listItem[i].Username = "@Ubaya";
                listItem[i].Time = "1d";
                listItem[i].Likes = 50;
                listItem[i].Reposts = 60;
                listItem[i].Comments = 70;
                listItem[i].Margin = new Padding(10);
                //scroll.Padding = new Padding(5);
            }

            if (scroll.Controls.Count < 0)
            {
                scroll.Controls.Clear();
            }
            else
            {
                foreach (var item in listItem)
                {
                    scroll.Controls.Add(item);
                }
            }
            scroll.ResumeLayout();
        }

        private void populateSmallPost()
        {
            scroll.SuspendLayout();
            Post[] listItem = new Post[32];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new Post();
            }

            if (scroll.Controls.Count < 0)
            {
                scroll.Controls.Clear();
            }
            else
            {
                foreach (var item in listItem)
                {
                    scroll.Controls.Add(item);
                }
            }
            scroll.ResumeLayout();
        }

        private void PopulateTrends()
        {
            suggest.SuspendLayout();
            ListSuggest[] listItem = new ListSuggest[5];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new ListSuggest();
                listItem[i].Trends = "Summmer";
                listItem[i].Posts = "500K";
            }

            if (suggest.Controls.Count < 0)
            {
                suggest.Controls.Clear();
            }
            else
            {
                foreach (var item in listItem)
                {
                    suggest.Controls.Add(item);
                }
            }
            suggest.ResumeLayout();
        }

        private void PopulateFollow()
        {
            suggest.SuspendLayout();
            ListSuggest[] listItem = new ListSuggest[5];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new ListSuggest();
                listItem[i].Trends = "@user";
                listItem[i].Posts = "50K Folowers";
            }

            if (suggest.Controls.Count < 0)
            {
                suggest.Controls.Clear();
            }
            else
            {
                foreach (var item in listItem)
                {
                    suggest.Controls.Add(item);
                }
            }
            suggest.ResumeLayout();
        }

        private void PopulateNotif()
        {
            scroll.SuspendLayout();
            Notifikasi[] listItem = new Notifikasi[5];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new Notifikasi();
            }

            if (scroll.Controls.Count < 0)
            {
                scroll.Controls.Clear();
            }
            else
            {
                foreach (var item in listItem)
                {
                    scroll.Controls.Add(item);
                }
            }
            scroll.ResumeLayout();
        }

        private void PopulateBannerNotif()
        {
            scroll.SuspendLayout();
            BannerNotif[] listItem = new BannerNotif[1];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new BannerNotif();
            }

            if (scroll.Controls.Count < 0)
            {
                scroll.Controls.Clear();
            }
            else
            {
                foreach (var item in listItem)
                {
                    scroll.Controls.Add(item);
                }
            }
            scroll.ResumeLayout();
        }

        private void InitializeUserControl()
        {
            var searchControl = new BeforeSearch();
            searchControl.OpenSearchFormRequested += (sender, args) => OpenSearchForm();
            scroll.Controls.Add(searchControl);
        }

        private void OpenSearchForm()
        {
            Form fmovrelay = new Form();

            try
            {
                using (FormSearch frm = new FormSearch(currentUser))
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

        public void LoadPosts(int userId)
        {
            var posts = Picture.GetUserPosts(userId);
            foreach (var post in posts)
            {
                var pictureBox = new PictureBox
                {
                    ImageLocation = post.Filename,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(100, 100)
                };

                var captionLabel = new Label
                {
                    Text = post.Caption,
                    AutoSize = true
                };

                var postPanel = new Panel
                {
                    Size = new Size(100, 130)
                };

                postPanel.Controls.Add(pictureBox);
                postPanel.Controls.Add(captionLabel);
                scroll.Controls.Add(postPanel);
            }
        }

        //public void LoadPostUser(int userId)
        //{
        //    scroll.Controls.Clear();
        //    var posts = Picture.GetUserPosts(userId);
        //    var taggedPosts = Picture.GetTaggedPosts(userId);

        //    foreach (var post in posts.Concat(taggedPosts).OrderByDescending(p => p.InputDate).Take(32))
        //    {
        //        var postControl = new Post(post, currentUser);
        //        scroll.Controls.Add(postControl);
        //    }
        //}

        private void LoadContent(string contentType)
        {
            scroll.Controls.Clear();

            switch (contentType)
            {
                case "Home":
                    populatePosts();
                    PopulateTrends();
                    break;
                case "Search":
                    InitializeUserControl();
                    //LoadPostUser(32);
                    populateSmallPost();
                    PopulateFollow();
                    break;
                case "Notifications":
                    PopulateBannerNotif();
                    PopulateNotif();
                    PopulateTrends();
                    break;
                default:
                    break;
            }
        }


    }
}


