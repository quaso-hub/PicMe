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
    public partial class Post : UserControl
    {

        public Post()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);

        }

        public void OpenCommentDialog()
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

                using (CommentDialog commentDialog = new CommentDialog())
                {
                    commentDialog.TopMost = true; 
                    if (commentDialog.ShowDialog() == DialogResult.OK)
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
                overlayForm.Dispose(); // Pastikan untuk menghapus overlay
            }
        }


        private void pbPost_Click(object sender, EventArgs e)
        {
            OpenCommentDialog();
        }

        private void pbPost_MouseHover(object sender, EventArgs e)
        {
            pbPost.BorderStyle = BorderStyle.FixedSingle;
            pbPost.BackColor = Color.LightGray;
        }

        private void pbPost_MouseLeave(object sender, EventArgs e)
        {
            pbPost.BorderStyle = BorderStyle.None;
            pbPost.BackColor = Color.Transparent;
        }

        private void Post_Load(object sender, EventArgs e)
        {
            lblShow.AutoSize = true;
        }
    }
}
