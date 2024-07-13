using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PicMe
{
    public partial class FormVerify : Form
    {
        private readonly string nextAction;
        private string currentOTP;
        private int timeLeft = 30;
        public FormVerify(string nextAction, string email)
        {
            this.nextAction = nextAction;
            InitializeComponent();
            lblEmail.Text = email;
            init();
        }

        private void init()
        {
            this.Shown += FormVerify_Shown;
            tb1.KeyDown += tb1_KeyDown;
        }

        private void FormVerify_Load(object sender, EventArgs e)
        {
            StartCountdown();
            lbl1.AutoSize = true;
            lbl2.AutoSize = true;
            lblEmail.AutoSize = true;
            lblResend.AutoSize = true;
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            string enteredOTP = tb1.Text + tb2.Text + tb3.Text + tb4.Text + tb5.Text + tb6.Text;
            if (enteredOTP == currentOTP)
            {
                if (nextAction == "Register")
                {
                    this.Hide();
                    FormLogin form = new FormLogin();
                    form.Show();
                }
                else if (nextAction == "Forgot")
                {
                    this.Hide();
                    FormSetNewPassword form = new FormSetNewPassword();
                    form.Show();
                }
                else if (nextAction == "Change")
                {
                    this.Hide();
                    FormLogin form = new FormLogin();
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Incorrect OTP, please try again.");
            }       
        }

        private void timerResend_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblResend.Text = $"Resend OTP within {timeLeft} S";
            }
            else
            {
                timerResend.Stop();
                lblResend.Text = "Click here to resend OTP";
                lblResend.Font = new Font(lblResend.Font, FontStyle.Underline);
                lblResend.Cursor = Cursors.Hand;
            }
        }

        private void lblResend_Click(object sender, EventArgs e)
        {
            if (timeLeft == 0)
            {
                SendVerification();
                StartCountdown();
            }
        }

        private void FormVerify_Shown(object sender, EventArgs e)
        {
            SendVerification();
            StartCountdown(); 
        }

        private void SendVerification()
        {
            currentOTP = GenerateOTP();
            SendOTPNotification(currentOTP);
        }


        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void SendOTPNotification(string otp)
        {
            notifyIconOTP.Icon = SystemIcons.Application;
            notifyIconOTP.BalloonTipTitle = "Verification Code";
            notifyIconOTP.BalloonTipText = $"Your OTP is: {otp}";
            notifyIconOTP.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconOTP.Visible = true;
            notifyIconOTP.ShowBalloonTip(30000); 
        }

        private void StartCountdown()
        {
            timeLeft = 30;
            timerResend.Start();
        } 

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (nextAction == "Register")
            {
                this.Hide();
                FormRegister form = new FormRegister();
                form.Show();
            }
            else if (nextAction == "Forgot")
            {
                this.Hide();
                FormForgot form = new FormForgot();
                form.Show();
            }
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.BackHover;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.Back;
        }

        private void buttonVerify_MouseEnter(object sender, EventArgs e)
        {
            buttonVerify.Image = Properties.Resources.ButtonVerifyHover;
        }

        private void buttonVerify_MouseLeave(object sender, EventArgs e)
        {
            buttonVerify.Image = Properties.Resources.ButtonVerify;
        }

        private void TxtOtp_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            if (currentTextBox.Text.Length == 1)
            {
                Control nextControl = GetNextControl(currentTextBox, true);
                if (nextControl != null && nextControl is TextBox)
                {
                    nextControl.Focus();
                }
            }
        }

        private void FillOtpTextBoxes(string otp)
        {           
            tb1.Text = otp[0].ToString();
            tb2.Text = otp[1].ToString();
            tb3.Text = otp[2].ToString();
            tb4.Text = otp[3].ToString();
            tb5.Text = otp[4].ToString();
            tb6.Text = otp[5].ToString();
            tb6.Focus();
        }

        private void tb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                this.BeginInvoke(new Action(() =>
                {
                    string otp = Clipboard.GetText().Trim();
                    if (otp.Length == 6)
                    {
                        FillOtpTextBoxes(otp);
                    }
                }));
            }
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if (tb1.Text.Length == 1)
            {
                tb2.Focus();
            }
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            if (tb2.Text.Length == 1)
            {
                tb3.Focus();
            }
        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {
            if (tb3.Text.Length == 1)
            {
                tb4.Focus();
            }
        }

        private void tb4_TextChanged(object sender, EventArgs e)
        {
            if (tb4.Text.Length == 1)
            {
                tb5.Focus();
            }
        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {
            if (tb5.Text.Length == 1)
            {
                tb6.Focus();
            }
        }

        private void tb6_TextChanged(object sender, EventArgs e)
        {
            if (tb6.Text.Length == 1)
            {
                tb6.Focus();
            }
        }
    }
}
