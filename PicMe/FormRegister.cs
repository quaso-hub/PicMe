using MyPics_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicMe
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string email = tbEmail.Text; 
            string password = tbPass.Text; 
            string confirmPassword = tbPass2.Text;

            lblSamaUser.Visible = false;
            lblSamaEmail.Visible = false;
            lblBedaPass.Visible = false;

            if (password != confirmPassword)
            {
                lblBedaPass.Text = "Passwords do not match!";
                lblBedaPass.Visible = true;
                return;
            }
            if (User.IsUsernameOrEmailExists(username, email))
            {
                if (User.IsUsernameExists(username))
                {
                    lblSamaUser.Text = "Username already taken!";
                    lblSamaUser.Visible = true;
                }
                if (User.IsEmailExists(email))
                {
                    lblSamaEmail.Text = "Email already used!";
                    lblSamaEmail.Visible = true;
                }
                return;
            }

            User newUser = new User(0, username, email, password);
            User.Register(newUser);

            FormVerify frm = new FormVerify("Register", email);
            frm.Show();
            this.Hide();
        }

        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.Blue;
            lblLogin.Font = new Font(lblLogin.Font, lblLogin.Font.Style | FontStyle.Underline);
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.Black;
            lblLogin.Font = new Font(lblLogin.Font, lblLogin.Font.Style & ~FontStyle.Underline);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '●';
            btnHide.Visible = true;
            btnShow.Visible = false;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '\0';
            btnShow.Visible = true;
            btnHide.Visible = false;
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            tbPass2.PasswordChar = '●';
            btnHide2.Visible = true;
            btnShow2.Visible = false;
        }

        private void btnHide2_Click(object sender, EventArgs e)
        {
            tbPass2.PasswordChar = '\0';
            btnShow2.Visible = true;
            btnHide2.Visible = false;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            lbl1.AutoSize = true;
            lbl2.AutoSize = true;
            lblSamaUser.AutoSize = true;
            lblSamaEmail.AutoSize = true;
            lblBedaPass.AutoSize = true;
            lblLogin.AutoSize = true;

            lblSamaUser.Visible = false;
            lblSamaEmail.Visible = false;
            lblBedaPass.Visible = false;
        }
    }
}
