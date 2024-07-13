namespace PicMe
{
    partial class CommentDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentDialog));
            this.posts = new System.Windows.Forms.FlowLayoutPanel();
            this.listPosts1 = new PicMe.ListPosts();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.posts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // posts
            // 
            this.posts.Controls.Add(this.listPosts1);
            this.posts.Controls.Add(this.btnClose);
            this.posts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posts.Location = new System.Drawing.Point(0, 0);
            this.posts.Name = "posts";
            this.posts.Size = new System.Drawing.Size(1506, 896);
            this.posts.TabIndex = 0;
            this.posts.Paint += new System.Windows.Forms.PaintEventHandler(this.posts_Paint);
            // 
            // listPosts1
            // 
            this.listPosts1.BackColor = System.Drawing.Color.LightGray;
            this.listPosts1.Location = new System.Drawing.Point(3, 3);
            this.listPosts1.Name = "listPosts1";
            this.listPosts1.PicturePosts = ((System.Drawing.Image)(resources.GetObject("listPosts1.PicturePosts")));
            this.listPosts1.Size = new System.Drawing.Size(1446, 893);
            this.listPosts1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PicMe.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1456, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 53);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 58;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // CommentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1506, 896);
            this.Controls.Add(this.posts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommentDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommentDialog";
            this.posts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel posts;
        private ListPosts listPosts1;
        private System.Windows.Forms.PictureBox btnClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}