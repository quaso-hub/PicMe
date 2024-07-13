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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PicMe
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string password = tbPass.Text;

            try
            {
                User loggedInUser = User.CekLogin(username, password);
                if (loggedInUser != null)
                {
                   
                    FormHome frmHome = new FormHome(loggedInUser);
                    frmHome.Show();
                    this.Hide();
                    MessageBox.Show($"Welcome Back, {username}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void lblForgot_Click(object sender, EventArgs e)
        {
            FormForgot frm = new FormForgot();
            frm.Show();
            this.Hide();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            FormRegister frm = new FormRegister();
            frm.Show();
            this.Hide();
        }

        private void lblForgot_MouseEnter(object sender, EventArgs e)
        {
            lblForgot.ForeColor = Color.Blue;
            lblForgot.Font = new Font(lblForgot.Font, lblForgot.Font.Style | FontStyle.Underline);

        }

        private void lblForgot_MouseLeave(object sender, EventArgs e)
        {
            lblForgot.ForeColor = Color.Black;
            lblForgot.Font = new Font(lblForgot.Font, lblForgot.Font.Style & ~FontStyle.Underline);
        }

        private void lblSignUp_MouseEnter(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.Blue;
            lblSignUp.Font = new Font(lblSignUp.Font, lblSignUp.Font.Style | FontStyle.Underline);
        }

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.Black;
            lblSignUp.Font = new Font(lblSignUp.Font, lblSignUp.Font.Style & ~FontStyle.Underline);
        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.Image = Properties.Resources.ButtonLoginHover;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.Image = Properties.Resources.ButtonLogin;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lbl1.AutoSize = true;
            lbl2.AutoSize = true;
            lbl3.AutoSize = true;
            lblForgot.AutoSize = true;
            lblSignUp.AutoSize = true;
        }
    }
}
