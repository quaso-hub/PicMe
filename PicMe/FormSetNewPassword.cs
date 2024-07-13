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
    public partial class FormSetNewPassword : Form
    {
        public FormSetNewPassword()
        {
            InitializeComponent();
        }

        private void FormForgot_Load(object sender, EventArgs e)
        {
            lbl1.AutoSize = true;
            lbl2.AutoSize = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '\0';
            btnShow.Visible = true;
            btnHide.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '●';
            btnHide.Visible = true;
            btnShow.Visible = false;
        }

        private void btnHideRetry_Click(object sender, EventArgs e)
        {
            tbPassRetry.PasswordChar = '\0';
            btnShowRetry.Visible = true;
            btnHideRetry.Visible = false;
        }

        private void btnShowRetry_Click(object sender, EventArgs e)
        {
            tbPassRetry.PasswordChar = '●';
            btnShowRetry.Visible = true;
            btnHideRetry.Visible = false;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }

        private void buttonSet_MouseHover(object sender, EventArgs e)
        {
            buttonSet.Image = Properties.Resources.ButtonSetHover;
        }

        private void buttonSet_MouseEnter(object sender, EventArgs e)
        {
            buttonSet.Image = Properties.Resources.ButtonSet;
        }
    }
}
