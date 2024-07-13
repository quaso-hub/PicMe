namespace PicMe
{
    partial class Post
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pbPost = new System.Windows.Forms.PictureBox();
            this.lblShow = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPost)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pbPost
            // 
            this.pbPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPost.Image = ((System.Drawing.Image)(resources.GetObject("pbPost.Image")));
            this.pbPost.Location = new System.Drawing.Point(0, 0);
            this.pbPost.Name = "pbPost";
            this.pbPost.Size = new System.Drawing.Size(270, 250);
            this.pbPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPost.TabIndex = 0;
            this.pbPost.TabStop = false;
            this.pbPost.Click += new System.EventHandler(this.pbPost_Click);
            this.pbPost.MouseLeave += new System.EventHandler(this.pbPost_MouseLeave);
            this.pbPost.MouseHover += new System.EventHandler(this.pbPost_MouseHover);
            // 
            // lblShow
            // 
            this.lblShow.AllowParentOverrides = false;
            this.lblShow.AutoEllipsis = false;
            this.lblShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblShow.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblShow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.ForeColor = System.Drawing.Color.Black;
            this.lblShow.Location = new System.Drawing.Point(4, 206);
            this.lblShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblShow.Name = "lblShow";
            this.lblShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblShow.Size = new System.Drawing.Size(73, 30);
            this.lblShow.TabIndex = 23;
            this.lblShow.Text = "Public";
            this.lblShow.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblShow.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.pbPost);
            this.Name = "Post";
            this.Size = new System.Drawing.Size(270, 250);
            this.Load += new System.EventHandler(this.Post_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pbPost;
        private Bunifu.UI.WinForms.BunifuLabel lblShow;
    }
}
