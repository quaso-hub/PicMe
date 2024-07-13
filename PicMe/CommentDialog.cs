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
    public partial class CommentDialog : Form
    {
        public int NewCommentsCount { get; private set; }

        public CommentDialog()
        {
            InitializeComponent();
        }

        private void handlePosts()
        {
            ListPosts listPosts = new ListPosts();
            listPosts.CloseRequested += (sender, args) =>
            {
                listPosts.Visible = false;
            };

            this.Controls.Add(listPosts);

        }

        private void posts_Paint(object sender, PaintEventArgs e)
        {
            handlePosts();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            btnClose.Image = Properties.Resources.closeBold;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.closeBold;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.close;
        }
    }
}
