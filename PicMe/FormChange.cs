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
using System.Xml.Linq;

namespace PicMe
{
    public partial class FormChange : Form
    {
        private User currentUser;
        private string newUsername;

        public FormChange(User user)
        {
            InitializeComponent();
            currentUser = user;

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
            SetButtonHoverEffects(btnEditName, Properties.Resources.EditHover, Properties.Resources.EditWhite);        
            SetButtonHoverEffects(btnSave, Properties.Resources.ButtonSaveHover, Properties.Resources.ButtonSave);
        }

        private void FormChange_Load(object sender, EventArgs e)
        {
            HoverLeaverButtons();
            lbl1.AutoSize = true;
            lblEmail.AutoSize = true;
            lblName.AutoSize = true;

            tbUsername.Text = currentUser.Username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newUsername = tbUsername.Text;

            if (User.IsUsernameExists(newUsername) && newUsername != currentUser.Username)
            {
                MessageBox.Show("Username sudah digunakan, silakan gunakan yang lain.");
            }
            else
            {
                User.UpdateUsername(currentUser.Id, newUsername);
                MessageBox.Show("Username berhasil diperbarui.");
                currentUser.Username = newUsername;

                FormProfile profile = new FormProfile(currentUser);
                profile.Show();
                this.Close();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfile profile = new FormProfile(currentUser);
            profile.Show();
        }

    }
}
