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
    public partial class FormSearch : Form
    {
        private User currentUser;
        public FormSearch(User user)
        {
            InitializeComponent();
            InitializeSearchControl();
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

        private void populateSmallPost()
        {
            panelSearch.SuspendLayout();
            Post[] listItem = new Post[32];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new Post();
            }

            if (panelSearch.Controls.Count < 0)
            {
                panelSearch.Controls.Clear();
            }
            else
            {
                foreach (var item in listItem)
                {
                    panelSearch.Controls.Add(item);
                }
            }
            panelSearch.ResumeLayout();
        }

        private void populateHastag()
        {
            panelSearch.SuspendLayout();
            NewHastag[] listItem = new NewHastag[32];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new NewHastag();
            }

            if (panelSearch.Controls.Count < 0)
            {
                panelSearch.Controls.Clear();
            }
            else
            {
                foreach (var item in listItem)
                {
                    panelSearch.Controls.Add(item);
                }
            }
            panelSearch.ResumeLayout();
        }

        private void populateUser()
        {
            panelSearch.SuspendLayout();
            List<User> users = User.GetAllUsersExcept(currentUser.Id);
            foreach (var user in users)
            {
                var newUserControl = new _NewUser(user, currentUser);
                panelSearch.Controls.Add(newUserControl);
            }
            panelSearch.ResumeLayout();
        }

        private void populateNotFound()
        {
            panelSearch.SuspendLayout();
            NotFound404[] listItem = new NotFound404[1];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new NotFound404();
            }

            if (panelSearch.Controls.Count < 0)
            {
                panelSearch.Controls.Clear();
            }
            else
            {
                foreach (var item in listItem)
                {
                    panelSearch.Controls.Add(item);
                }
            }
            panelSearch.ResumeLayout();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            populateSmallPost();
            populateUser();
        }

        private void InitializeSearchControl()
        {
            var searchControl = new Search();
            searchControl.SearchTypeChanged += SearchControl_SearchTypeChanged;
            panelIni.Controls.Add(searchControl);

        }

        private void SearchControl_SearchTypeChanged(object sender, string searchType)
        {
            UpdateSearchResults(searchType);
        }

        private void UpdateSearchResults(string searchType)
        {
            panelSearch.Controls.Clear();
            switch (searchType)
            {
                case "foto":
                    populateSmallPost();
                    break;
                case "people":
                    populateUser();
                    break;
                case "hashtag":
                    populateHastag();
                    break;
                default:
                    populateNotFound();
                    break;
            }
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
