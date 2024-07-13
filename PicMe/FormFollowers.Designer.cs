namespace PicMe
{
    partial class FormFollowers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFollowers));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gradientPanelLogin = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new ZBobb.AlphaBlendTextBox();
            this.panelFol = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.gradientPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
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
            this.gradientPanelLogin.Controls.Add(this.pb1);
            this.gradientPanelLogin.Controls.Add(this.panel1);
            this.gradientPanelLogin.Controls.Add(this.tbSearch);
            this.gradientPanelLogin.Controls.Add(this.panelFol);
            this.gradientPanelLogin.Controls.Add(this.lbl1);
            this.gradientPanelLogin.Controls.Add(this.btnClose);
            this.gradientPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelLogin.GradientBottomLeft = System.Drawing.SystemColors.MenuBar;
            this.gradientPanelLogin.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.gradientPanelLogin.GradientTopLeft = System.Drawing.Color.PowderBlue;
            this.gradientPanelLogin.GradientTopRight = System.Drawing.Color.Plum;
            this.gradientPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gradientPanelLogin.Name = "gradientPanelLogin";
            this.gradientPanelLogin.Quality = 10;
            this.gradientPanelLogin.Size = new System.Drawing.Size(580, 758);
            this.gradientPanelLogin.TabIndex = 8;
            // 
            // pb1
            // 
            this.pb1.Image = global::PicMe.Properties.Resources.Search_Client;
            this.pb1.Location = new System.Drawing.Point(517, 110);
            this.pb1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(50, 53);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 79;
            this.pb1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 1);
            this.panel1.TabIndex = 61;
            // 
            // tbSearch
            // 
            this.tbSearch.BackAlpha = 0;
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.Location = new System.Drawing.Point(13, 120);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(496, 43);
            this.tbSearch.TabIndex = 78;
            this.tbSearch.Text = "Search.......";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // panelFol
            // 
            this.panelFol.AutoScroll = true;
            this.panelFol.Location = new System.Drawing.Point(12, 191);
            this.panelFol.Name = "panelFol";
            this.panelFol.Size = new System.Drawing.Size(555, 545);
            this.panelFol.TabIndex = 77;
            // 
            // lbl1
            // 
            this.lbl1.AllowParentOverrides = false;
            this.lbl1.AutoEllipsis = false;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl1.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(209, 15);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl1.Name = "lbl1";
            this.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl1.Size = new System.Drawing.Size(141, 39);
            this.lbl1.TabIndex = 76;
            this.lbl1.Text = "Followers";
            this.lbl1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PicMe.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(524, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 53);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 64;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // FormFollow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 758);
            this.Controls.Add(this.gradientPanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFollow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Following";
            this.Load += new System.EventHandler(this.FormFollow_Load);
            this.gradientPanelLogin.ResumeLayout(false);
            this.gradientPanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuGradientPanel gradientPanelLogin;
        private System.Windows.Forms.PictureBox btnClose;
        private Bunifu.UI.WinForms.BunifuLabel lbl1;
        private System.Windows.Forms.FlowLayoutPanel panelFol;
        private ZBobb.AlphaBlendTextBox tbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb1;
    }
}