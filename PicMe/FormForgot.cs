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
    public partial class FormForgot : Form
    {
        public FormForgot()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string userEmail = "@email";
            FormVerify frm = new FormVerify("Forgot", userEmail);
            frm.Show();
            this.Hide();
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.BackHover;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.Back;
        }

        private void buttonSend_MouseEnter(object sender, EventArgs e)
        {
            buttonSend.Image = Properties.Resources.ButtonSendHover;
        }

        private void buttonSend_MouseLeave(object sender, EventArgs e)
        {
            buttonSend.Image = Properties.Resources.ButtonSend;
        }

        private void FormForgot_Load(object sender, EventArgs e)
        {
            lbl1.AutoSize = true;
            lbl2.AutoSize = true;
            lbl3.AutoSize = true;
            lbl4.AutoSize = true;
        }
    }
}
