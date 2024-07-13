namespace PicMe
{
    partial class NewHastag
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewHastag));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelHastag = new System.Windows.Forms.Panel();
            this.lblPosts = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblHashtag = new Bunifu.UI.WinForms.BunifuLabel();
            this.pbHastag = new System.Windows.Forms.PictureBox();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelHastag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHastag)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panelHastag
            // 
            this.panelHastag.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelHastag.Controls.Add(this.lblPosts);
            this.panelHastag.Controls.Add(this.lblHashtag);
            this.panelHastag.Controls.Add(this.pbHastag);
            this.panelHastag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHastag.Location = new System.Drawing.Point(0, 0);
            this.panelHastag.Name = "panelHastag";
            this.panelHastag.Size = new System.Drawing.Size(810, 98);
            this.panelHastag.TabIndex = 0;
            this.panelHastag.Click += new System.EventHandler(this.panelHastag_Click);
            this.panelHastag.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHastag_Paint);
            this.panelHastag.MouseLeave += new System.EventHandler(this.panelHastag_MouseLeave);
            this.panelHastag.MouseHover += new System.EventHandler(this.panelHastag_MouseHover);
            // 
            // lblPosts
            // 
            this.lblPosts.AllowParentOverrides = false;
            this.lblPosts.AutoEllipsis = false;
            this.lblPosts.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPosts.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosts.ForeColor = System.Drawing.Color.DeepPink;
            this.lblPosts.Location = new System.Drawing.Point(113, 51);
            this.lblPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblPosts.Name = "lblPosts";
            this.lblPosts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPosts.Size = new System.Drawing.Size(133, 30);
            this.lblPosts.TabIndex = 26;
            this.lblPosts.Text = "5000K posts";
            this.lblPosts.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPosts.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblHashtag
            // 
            this.lblHashtag.AllowParentOverrides = false;
            this.lblHashtag.AutoEllipsis = false;
            this.lblHashtag.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHashtag.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblHashtag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHashtag.ForeColor = System.Drawing.Color.Black;
            this.lblHashtag.Location = new System.Drawing.Point(113, 24);
            this.lblHashtag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblHashtag.Name = "lblHashtag";
            this.lblHashtag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHashtag.Size = new System.Drawing.Size(198, 28);
            this.lblHashtag.TabIndex = 25;
            this.lblHashtag.Text = "#OkegasOkegas";
            this.lblHashtag.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblHashtag.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pbHastag
            // 
            this.pbHastag.Image = global::PicMe.Properties.Resources.hastag;
            this.pbHastag.Location = new System.Drawing.Point(18, 15);
            this.pbHastag.Name = "pbHastag";
            this.pbHastag.Size = new System.Drawing.Size(77, 66);
            this.pbHastag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHastag.TabIndex = 24;
            this.pbHastag.TabStop = false;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this;
            // 
            // Hastag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHastag);
            this.Name = "Hastag";
            this.Size = new System.Drawing.Size(810, 98);
            this.Load += new System.EventHandler(this.Hastag_Load);
            this.panelHastag.ResumeLayout(false);
            this.panelHastag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHastag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelHastag;
        private Bunifu.UI.WinForms.BunifuLabel lblHashtag;
        private System.Windows.Forms.PictureBox pbHastag;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.UI.WinForms.BunifuLabel lblPosts;
    }
}
