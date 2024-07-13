namespace PicMe
{
    partial class BannerNotif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BannerNotif));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblNotif = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNotif2 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblNotif
            // 
            this.lblNotif.AllowParentOverrides = false;
            this.lblNotif.AutoEllipsis = false;
            this.lblNotif.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNotif.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNotif.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNotif.Location = new System.Drawing.Point(34, 31);
            this.lblNotif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNotif.Size = new System.Drawing.Size(131, 70);
            this.lblNotif.TabIndex = 23;
            this.lblNotif.Text = "Notif";
            this.lblNotif.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNotif.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblNotif.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PicMe.Properties.Resources.lonceng;
            this.pictureBox1.Location = new System.Drawing.Point(639, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lblNotif2
            // 
            this.lblNotif2.AllowParentOverrides = false;
            this.lblNotif2.AutoEllipsis = false;
            this.lblNotif2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNotif2.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNotif2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif2.ForeColor = System.Drawing.Color.DeepPink;
            this.lblNotif2.Location = new System.Drawing.Point(167, 31);
            this.lblNotif2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblNotif2.Name = "lblNotif2";
            this.lblNotif2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNotif2.Size = new System.Drawing.Size(198, 70);
            this.lblNotif2.TabIndex = 25;
            this.lblNotif2.Text = "ication";
            this.lblNotif2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNotif2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblNotif2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            // 
            // BannerNotif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lblNotif2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNotif);
            this.Name = "BannerNotif";
            this.Size = new System.Drawing.Size(810, 138);
            this.Load += new System.EventHandler(this.BannerNotif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel lblNotif;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel lblNotif2;
    }
}
