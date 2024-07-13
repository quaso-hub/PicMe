namespace PicMe
{
    partial class Notifikasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifikasi));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pbLonceng = new System.Windows.Forms.PictureBox();
            this.lblNotif = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLonceng)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pbLonceng
            // 
            this.pbLonceng.Image = global::PicMe.Properties.Resources.lonceng;
            this.pbLonceng.Location = new System.Drawing.Point(9, 9);
            this.pbLonceng.Name = "pbLonceng";
            this.pbLonceng.Size = new System.Drawing.Size(77, 66);
            this.pbLonceng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLonceng.TabIndex = 0;
            this.pbLonceng.TabStop = false;
            this.pbLonceng.MouseLeave += new System.EventHandler(this.pbLonceng_MouseLeave);
            this.pbLonceng.MouseHover += new System.EventHandler(this.pbLonceng_MouseHover);
            // 
            // lblNotif
            // 
            this.lblNotif.AllowParentOverrides = false;
            this.lblNotif.AutoEllipsis = false;
            this.lblNotif.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNotif.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNotif.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif.ForeColor = System.Drawing.Color.Black;
            this.lblNotif.Location = new System.Drawing.Point(106, 28);
            this.lblNotif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNotif.Size = new System.Drawing.Size(564, 30);
            this.lblNotif.TabIndex = 23;
            this.lblNotif.Text = "Pengguna @Accumalca telah mengikuti anda!";
            this.lblNotif.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNotif.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Notifikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.lblNotif);
            this.Controls.Add(this.pbLonceng);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Notifikasi";
            this.Size = new System.Drawing.Size(810, 86);
            this.Load += new System.EventHandler(this.Notifikasi_Load);
            this.MouseLeave += new System.EventHandler(this.Notifikasi_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Notifikasi_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pbLonceng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pbLonceng;
        private Bunifu.UI.WinForms.BunifuLabel lblNotif;
    }
}
