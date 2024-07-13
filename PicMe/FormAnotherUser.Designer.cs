namespace PicMe
{
    partial class FormAnotherUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnotherUser));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelPost = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFollow = new System.Windows.Forms.PictureBox();
            this.lblEmail = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPosting = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPost = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblFolw = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblFollowers = new Bunifu.UI.WinForms.BunifuLabel();
            this.logoProfile = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblFolin = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.lblFollowing = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.gradientPanelLogin = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblFol = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblFoling = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnFollow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoProfile)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.gradientPanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelPost
            // 
            this.panelPost.AutoScroll = true;
            this.panelPost.Location = new System.Drawing.Point(63, 342);
            this.panelPost.Name = "panelPost";
            this.panelPost.Size = new System.Drawing.Size(836, 646);
            this.panelPost.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(63, 324);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 2);
            this.panel1.TabIndex = 15;
            // 
            // btnFollow
            // 
            this.btnFollow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFollow.Image = global::PicMe.Properties.Resources.addUser;
            this.btnFollow.Location = new System.Drawing.Point(732, 93);
            this.btnFollow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(63, 67);
            this.btnFollow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFollow.TabIndex = 14;
            this.btnFollow.TabStop = false;
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AllowParentOverrides = false;
            this.lblEmail.AutoEllipsis = false;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEmail.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(284, 123);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(299, 37);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "www@example.com";
            this.lblEmail.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblEmail.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblName
            // 
            this.lblName.AllowParentOverrides = false;
            this.lblName.AutoEllipsis = false;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(284, 93);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(216, 37);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "@Accumalaca";
            this.lblName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPosting
            // 
            this.lblPosting.AllowParentOverrides = false;
            this.lblPosting.AutoEllipsis = false;
            this.lblPosting.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPosting.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPosting.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosting.ForeColor = System.Drawing.Color.Silver;
            this.lblPosting.Location = new System.Drawing.Point(249, 79);
            this.lblPosting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblPosting.Name = "lblPosting";
            this.lblPosting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPosting.Size = new System.Drawing.Size(60, 37);
            this.lblPosting.TabIndex = 14;
            this.lblPosting.Text = "Post";
            this.lblPosting.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPosting.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPost
            // 
            this.lblPost.AllowParentOverrides = false;
            this.lblPost.AutoEllipsis = false;
            this.lblPost.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPost.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPost.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost.ForeColor = System.Drawing.Color.Black;
            this.lblPost.Location = new System.Drawing.Point(249, 35);
            this.lblPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblPost.Name = "lblPost";
            this.lblPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPost.Size = new System.Drawing.Size(51, 37);
            this.lblPost.TabIndex = 13;
            this.lblPost.Text = "100";
            this.lblPost.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPost.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblFolw
            // 
            this.lblFolw.AllowParentOverrides = false;
            this.lblFolw.AutoEllipsis = false;
            this.lblFolw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFolw.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblFolw.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolw.ForeColor = System.Drawing.Color.Silver;
            this.lblFolw.Location = new System.Drawing.Point(33, 79);
            this.lblFolw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblFolw.Name = "lblFolw";
            this.lblFolw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFolw.Size = new System.Drawing.Size(131, 37);
            this.lblFolw.TabIndex = 12;
            this.lblFolw.Text = "Followers";
            this.lblFolw.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFolw.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblFolw.Click += new System.EventHandler(this.lblFolw_Click);
            this.lblFolw.MouseLeave += new System.EventHandler(this.lblFolw_MouseLeave);
            this.lblFolw.MouseHover += new System.EventHandler(this.lblFolw_MouseHover);
            // 
            // lblFollowers
            // 
            this.lblFollowers.AllowParentOverrides = false;
            this.lblFollowers.AutoEllipsis = false;
            this.lblFollowers.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFollowers.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFollowers.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowers.ForeColor = System.Drawing.Color.Black;
            this.lblFollowers.Location = new System.Drawing.Point(56, 35);
            this.lblFollowers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFollowers.Size = new System.Drawing.Size(76, 37);
            this.lblFollowers.TabIndex = 11;
            this.lblFollowers.Text = "1,500";
            this.lblFollowers.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFollowers.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // logoProfile
            // 
            this.logoProfile.AllowFocused = false;
            this.logoProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoProfile.AutoSizeHeight = true;
            this.logoProfile.BorderRadius = 77;
            this.logoProfile.Image = ((System.Drawing.Image)(resources.GetObject("logoProfile.Image")));
            this.logoProfile.IsCircle = true;
            this.logoProfile.Location = new System.Drawing.Point(80, 123);
            this.logoProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoProfile.Name = "logoProfile";
            this.logoProfile.Size = new System.Drawing.Size(154, 154);
            this.logoProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoProfile.TabIndex = 8;
            this.logoProfile.TabStop = false;
            this.logoProfile.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblFolin
            // 
            this.lblFolin.AllowParentOverrides = false;
            this.lblFolin.AutoEllipsis = false;
            this.lblFolin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFolin.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblFolin.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolin.ForeColor = System.Drawing.Color.Silver;
            this.lblFolin.Location = new System.Drawing.Point(425, 79);
            this.lblFolin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblFolin.Name = "lblFolin";
            this.lblFolin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFolin.Size = new System.Drawing.Size(136, 37);
            this.lblFolin.TabIndex = 16;
            this.lblFolin.Text = "Following";
            this.lblFolin.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFolin.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblFolin.Click += new System.EventHandler(this.lblFolin_Click);
            this.lblFolin.MouseLeave += new System.EventHandler(this.lblFolin_MouseLeave);
            this.lblFolin.MouseHover += new System.EventHandler(this.lblFolin_MouseHover);
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 10;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.lblFolin);
            this.bunifuShadowPanel1.Controls.Add(this.lblFollowing);
            this.bunifuShadowPanel1.Controls.Add(this.lblPosting);
            this.bunifuShadowPanel1.Controls.Add(this.lblPost);
            this.bunifuShadowPanel1.Controls.Add(this.lblFolw);
            this.bunifuShadowPanel1.Controls.Add(this.lblFollowers);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(275, 170);
            this.bunifuShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(584, 143);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 7;
            // 
            // lblFollowing
            // 
            this.lblFollowing.AllowParentOverrides = false;
            this.lblFollowing.AutoEllipsis = false;
            this.lblFollowing.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFollowing.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFollowing.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowing.ForeColor = System.Drawing.Color.Black;
            this.lblFollowing.Location = new System.Drawing.Point(447, 35);
            this.lblFollowing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblFollowing.Name = "lblFollowing";
            this.lblFollowing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFollowing.Size = new System.Drawing.Size(76, 37);
            this.lblFollowing.TabIndex = 15;
            this.lblFollowing.Text = "1,500";
            this.lblFollowing.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFollowing.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(13, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 49);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 6;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // gradientPanelLogin
            // 
            this.gradientPanelLogin.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanelLogin.BackgroundImage")));
            this.gradientPanelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanelLogin.BorderRadius = 1;
            this.gradientPanelLogin.Controls.Add(this.lblFol);
            this.gradientPanelLogin.Controls.Add(this.panelPost);
            this.gradientPanelLogin.Controls.Add(this.panel1);
            this.gradientPanelLogin.Controls.Add(this.btnFollow);
            this.gradientPanelLogin.Controls.Add(this.lblEmail);
            this.gradientPanelLogin.Controls.Add(this.lblName);
            this.gradientPanelLogin.Controls.Add(this.logoProfile);
            this.gradientPanelLogin.Controls.Add(this.bunifuShadowPanel1);
            this.gradientPanelLogin.Controls.Add(this.btnBack);
            this.gradientPanelLogin.Controls.Add(this.lblFoling);
            this.gradientPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gradientPanelLogin.GradientBottomLeft = System.Drawing.Color.MintCream;
            this.gradientPanelLogin.GradientBottomRight = System.Drawing.Color.Plum;
            this.gradientPanelLogin.GradientTopLeft = System.Drawing.Color.Thistle;
            this.gradientPanelLogin.GradientTopRight = System.Drawing.Color.Moccasin;
            this.gradientPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gradientPanelLogin.Name = "gradientPanelLogin";
            this.gradientPanelLogin.Quality = 10;
            this.gradientPanelLogin.Size = new System.Drawing.Size(957, 1000);
            this.gradientPanelLogin.TabIndex = 6;
            // 
            // lblFol
            // 
            this.lblFol.AllowParentOverrides = false;
            this.lblFol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFol.AutoEllipsis = false;
            this.lblFol.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFol.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFol.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFol.ForeColor = System.Drawing.Color.White;
            this.lblFol.Location = new System.Drawing.Point(437, 20);
            this.lblFol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblFol.Name = "lblFol";
            this.lblFol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFol.Size = new System.Drawing.Size(123, 47);
            this.lblFol.TabIndex = 20;
            this.lblFol.Text = "Follow";
            this.lblFol.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblFol.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblFoling
            // 
            this.lblFoling.AllowParentOverrides = false;
            this.lblFoling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFoling.AutoEllipsis = false;
            this.lblFoling.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFoling.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFoling.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoling.ForeColor = System.Drawing.Color.DeepPink;
            this.lblFoling.Location = new System.Drawing.Point(410, 22);
            this.lblFoling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblFoling.Name = "lblFoling";
            this.lblFoling.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFoling.Size = new System.Drawing.Size(183, 47);
            this.lblFoling.TabIndex = 21;
            this.lblFoling.Text = "Following";
            this.lblFoling.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblFoling.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FormAnotherUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 1000);
            this.Controls.Add(this.gradientPanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnotherUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnotherUser";
            this.Load += new System.EventHandler(this.FormAnotherUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnFollow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoProfile)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.gradientPanelLogin.ResumeLayout(false);
            this.gradientPanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuGradientPanel gradientPanelLogin;
        private System.Windows.Forms.FlowLayoutPanel panelPost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnFollow;
        private Bunifu.UI.WinForms.BunifuLabel lblEmail;
        private Bunifu.UI.WinForms.BunifuLabel lblName;
        private Bunifu.UI.WinForms.BunifuPictureBox logoProfile;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblFolin;
        private Bunifu.UI.WinForms.BunifuLabel lblFollowing;
        private Bunifu.UI.WinForms.BunifuLabel lblPosting;
        private Bunifu.UI.WinForms.BunifuLabel lblPost;
        private Bunifu.UI.WinForms.BunifuLabel lblFolw;
        private Bunifu.UI.WinForms.BunifuLabel lblFollowers;
        private System.Windows.Forms.PictureBox btnBack;
        private Bunifu.UI.WinForms.BunifuLabel lblFol;
        private Bunifu.UI.WinForms.BunifuLabel lblFoling;
    }
}