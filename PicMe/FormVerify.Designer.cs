namespace PicMe
{
    partial class FormVerify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerify));
            this.timerResend = new System.Windows.Forms.Timer(this.components);
            this.lblResend = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblEmail = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuPanel5 = new Bunifu.UI.WinForms.BunifuPanel();
            this.tb6 = new ZBobb.AlphaBlendTextBox();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.tb5 = new ZBobb.AlphaBlendTextBox();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.tb4 = new ZBobb.AlphaBlendTextBox();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.tb3 = new ZBobb.AlphaBlendTextBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanelPhone = new Bunifu.UI.WinForms.BunifuPanel();
            this.tb2 = new ZBobb.AlphaBlendTextBox();
            this.tb1 = new ZBobb.AlphaBlendTextBox();
            this.buttonVerify = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gradientPanelLogin = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.notifyIconOTP = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVerify)).BeginInit();
            this.gradientPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // timerResend
            // 
            this.timerResend.Interval = 1000;
            this.timerResend.Tick += new System.EventHandler(this.timerResend_Tick);
            // 
            // lblResend
            // 
            this.lblResend.AllowParentOverrides = false;
            this.lblResend.AutoEllipsis = false;
            this.lblResend.CursorType = null;
            this.lblResend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResend.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblResend.Location = new System.Drawing.Point(183, 606);
            this.lblResend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblResend.Name = "lblResend";
            this.lblResend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResend.Size = new System.Drawing.Size(261, 30);
            this.lblResend.TabIndex = 45;
            this.lblResend.Text = "Resend OTP within 30s";
            this.lblResend.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblResend.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblResend.Click += new System.EventHandler(this.lblResend_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AllowParentOverrides = false;
            this.lblEmail.AutoEllipsis = false;
            this.lblEmail.CursorType = null;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.Location = new System.Drawing.Point(201, 358);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(250, 30);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "www@example.com";
            this.lblEmail.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblEmail.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl2
            // 
            this.lbl2.AllowParentOverrides = false;
            this.lbl2.AutoEllipsis = false;
            this.lbl2.CursorType = null;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl2.Location = new System.Drawing.Point(134, 318);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl2.Name = "lbl2";
            this.lbl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl2.Size = new System.Drawing.Size(413, 30);
            this.lbl2.TabIndex = 43;
            this.lbl2.Text = "Verification code has been sent to";
            this.lbl2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl1
            // 
            this.lbl1.AllowParentOverrides = false;
            this.lbl1.AutoEllipsis = false;
            this.lbl1.CursorType = null;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(234, 266);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl1.Name = "lbl1";
            this.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl1.Size = new System.Drawing.Size(200, 30);
            this.lbl1.TabIndex = 42;
            this.lbl1.Text = "Verify Your Email";
            this.lbl1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(272, 108);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuPanel5
            // 
            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel5.BackgroundImage")));
            this.bunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel5.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel5.BorderRadius = 3;
            this.bunifuPanel5.BorderThickness = 1;
            this.bunifuPanel5.Location = new System.Drawing.Point(477, 502);
            this.bunifuPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuPanel5.Name = "bunifuPanel5";
            this.bunifuPanel5.ShowBorders = true;
            this.bunifuPanel5.Size = new System.Drawing.Size(64, 5);
            this.bunifuPanel5.TabIndex = 40;
            // 
            // tb6
            // 
            this.tb6.BackAlpha = 0;
            this.tb6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb6.ForeColor = System.Drawing.Color.White;
            this.tb6.Location = new System.Drawing.Point(495, 462);
            this.tb6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb6.MaxLength = 1;
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(64, 35);
            this.tb6.TabIndex = 39;
            this.tb6.Text = "X";
            this.tb6.TextChanged += new System.EventHandler(this.tb6_TextChanged);
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel4.BorderRadius = 3;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Location = new System.Drawing.Point(404, 502);
            this.bunifuPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(64, 5);
            this.bunifuPanel4.TabIndex = 38;
            // 
            // tb5
            // 
            this.tb5.BackAlpha = 0;
            this.tb5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb5.ForeColor = System.Drawing.Color.White;
            this.tb5.Location = new System.Drawing.Point(422, 462);
            this.tb5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb5.MaxLength = 1;
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(64, 35);
            this.tb5.TabIndex = 37;
            this.tb5.Text = "X";
            this.tb5.TextChanged += new System.EventHandler(this.tb5_TextChanged);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Location = new System.Drawing.Point(330, 502);
            this.bunifuPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(64, 5);
            this.bunifuPanel3.TabIndex = 36;
            // 
            // tb4
            // 
            this.tb4.BackAlpha = 0;
            this.tb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb4.ForeColor = System.Drawing.Color.White;
            this.tb4.Location = new System.Drawing.Point(348, 462);
            this.tb4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb4.MaxLength = 1;
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(64, 35);
            this.tb4.TabIndex = 35;
            this.tb4.Text = "X";
            this.tb4.TextChanged += new System.EventHandler(this.tb4_TextChanged);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Location = new System.Drawing.Point(256, 502);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(64, 5);
            this.bunifuPanel2.TabIndex = 34;
            // 
            // tb3
            // 
            this.tb3.BackAlpha = 0;
            this.tb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.ForeColor = System.Drawing.Color.White;
            this.tb3.Location = new System.Drawing.Point(274, 462);
            this.tb3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb3.MaxLength = 1;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(64, 35);
            this.tb3.TabIndex = 33;
            this.tb3.Text = "X";
            this.tb3.TextChanged += new System.EventHandler(this.tb3_TextChanged);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Location = new System.Drawing.Point(183, 502);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(64, 5);
            this.bunifuPanel1.TabIndex = 32;
            // 
            // bunifuPanelPhone
            // 
            this.bunifuPanelPhone.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanelPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanelPhone.BackgroundImage")));
            this.bunifuPanelPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanelPhone.BorderColor = System.Drawing.Color.White;
            this.bunifuPanelPhone.BorderRadius = 3;
            this.bunifuPanelPhone.BorderThickness = 1;
            this.bunifuPanelPhone.Location = new System.Drawing.Point(110, 502);
            this.bunifuPanelPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuPanelPhone.Name = "bunifuPanelPhone";
            this.bunifuPanelPhone.ShowBorders = true;
            this.bunifuPanelPhone.Size = new System.Drawing.Size(64, 5);
            this.bunifuPanelPhone.TabIndex = 30;
            // 
            // tb2
            // 
            this.tb2.BackAlpha = 0;
            this.tb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.ForeColor = System.Drawing.Color.White;
            this.tb2.Location = new System.Drawing.Point(201, 462);
            this.tb2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb2.MaxLength = 1;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(64, 35);
            this.tb2.TabIndex = 31;
            this.tb2.Text = "X";
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            // 
            // tb1
            // 
            this.tb1.BackAlpha = 0;
            this.tb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.ForeColor = System.Drawing.Color.White;
            this.tb1.Location = new System.Drawing.Point(128, 462);
            this.tb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb1.MaxLength = 1;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(64, 35);
            this.tb1.TabIndex = 29;
            this.tb1.Text = "X";
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            this.tb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb1_KeyDown);
            // 
            // buttonVerify
            // 
            this.buttonVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVerify.Image = ((System.Drawing.Image)(resources.GetObject("buttonVerify.Image")));
            this.buttonVerify.Location = new System.Drawing.Point(166, 665);
            this.buttonVerify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(320, 151);
            this.buttonVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonVerify.TabIndex = 28;
            this.buttonVerify.TabStop = false;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            this.buttonVerify.MouseEnter += new System.EventHandler(this.buttonVerify_MouseEnter);
            this.buttonVerify.MouseLeave += new System.EventHandler(this.buttonVerify_MouseLeave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gradientPanelLogin
            // 
            this.gradientPanelLogin.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanelLogin.BackgroundImage")));
            this.gradientPanelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanelLogin.BorderRadius = 1;
            this.gradientPanelLogin.Controls.Add(this.btnBack);
            this.gradientPanelLogin.Controls.Add(this.lblResend);
            this.gradientPanelLogin.Controls.Add(this.lblEmail);
            this.gradientPanelLogin.Controls.Add(this.lbl2);
            this.gradientPanelLogin.Controls.Add(this.lbl1);
            this.gradientPanelLogin.Controls.Add(this.pictureBox2);
            this.gradientPanelLogin.Controls.Add(this.bunifuPanel5);
            this.gradientPanelLogin.Controls.Add(this.tb6);
            this.gradientPanelLogin.Controls.Add(this.bunifuPanel4);
            this.gradientPanelLogin.Controls.Add(this.tb5);
            this.gradientPanelLogin.Controls.Add(this.bunifuPanel3);
            this.gradientPanelLogin.Controls.Add(this.tb4);
            this.gradientPanelLogin.Controls.Add(this.bunifuPanel2);
            this.gradientPanelLogin.Controls.Add(this.tb3);
            this.gradientPanelLogin.Controls.Add(this.bunifuPanel1);
            this.gradientPanelLogin.Controls.Add(this.bunifuPanelPhone);
            this.gradientPanelLogin.Controls.Add(this.tb2);
            this.gradientPanelLogin.Controls.Add(this.tb1);
            this.gradientPanelLogin.Controls.Add(this.buttonVerify);
            this.gradientPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelLogin.GradientBottomLeft = System.Drawing.Color.LightCoral;
            this.gradientPanelLogin.GradientBottomRight = System.Drawing.Color.PaleVioletRed;
            this.gradientPanelLogin.GradientTopLeft = System.Drawing.Color.HotPink;
            this.gradientPanelLogin.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gradientPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gradientPanelLogin.Name = "gradientPanelLogin";
            this.gradientPanelLogin.Quality = 10;
            this.gradientPanelLogin.Size = new System.Drawing.Size(662, 960);
            this.gradientPanelLogin.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::PicMe.Properties.Resources.Back;
            this.btnBack.Location = new System.Drawing.Point(4, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 72);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 46;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // notifyIconOTP
            // 
            this.notifyIconOTP.Text = "notifyIcon1";
            this.notifyIconOTP.Visible = true;
            // 
            // FormVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 960);
            this.Controls.Add(this.gradientPanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVerify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVerify";
            this.Load += new System.EventHandler(this.FormVerify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVerify)).EndInit();
            this.gradientPanelLogin.ResumeLayout(false);
            this.gradientPanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerResend;
        private Bunifu.UI.WinForms.BunifuLabel lblResend;
        private Bunifu.UI.WinForms.BunifuLabel lblEmail;
        private Bunifu.UI.WinForms.BunifuLabel lbl2;
        private Bunifu.UI.WinForms.BunifuLabel lbl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel5;
        private ZBobb.AlphaBlendTextBox tb6;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private ZBobb.AlphaBlendTextBox tb5;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private ZBobb.AlphaBlendTextBox tb4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private ZBobb.AlphaBlendTextBox tb3;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelPhone;
        private ZBobb.AlphaBlendTextBox tb2;
        private ZBobb.AlphaBlendTextBox tb1;
        private System.Windows.Forms.PictureBox buttonVerify;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuGradientPanel gradientPanelLogin;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.NotifyIcon notifyIconOTP;
    }
}