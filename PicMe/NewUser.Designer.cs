namespace PicMe
{
    partial class _NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_NewUser));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelUser = new System.Windows.Forms.Panel();
            this.lblBio = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblUser = new Bunifu.UI.WinForms.BunifuLabel();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
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
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelUser.Controls.Add(this.lblBio);
            this.panelUser.Controls.Add(this.lblUser);
            this.panelUser.Controls.Add(this.pbUser);
            this.panelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(810, 98);
            this.panelUser.TabIndex = 1;
            this.panelUser.Click += new System.EventHandler(this.panelUser_Click);
            this.panelUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUser_Paint);
            this.panelUser.MouseLeave += new System.EventHandler(this.panelUser_MouseLeave);
            this.panelUser.MouseHover += new System.EventHandler(this.panelUser_MouseHover);
            // 
            // lblBio
            // 
            this.lblBio.AllowParentOverrides = false;
            this.lblBio.AutoEllipsis = false;
            this.lblBio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBio.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblBio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.ForeColor = System.Drawing.Color.DeepPink;
            this.lblBio.Location = new System.Drawing.Point(113, 51);
            this.lblBio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblBio.Name = "lblBio";
            this.lblBio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBio.Size = new System.Drawing.Size(200, 30);
            this.lblBio.TabIndex = 26;
            this.lblBio.Text = "punyanya_si-DOI";
            this.lblBio.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblBio.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblUser
            // 
            this.lblUser.AllowParentOverrides = false;
            this.lblUser.AutoEllipsis = false;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUser.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(113, 24);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUser.Size = new System.Drawing.Size(106, 28);
            this.lblUser.TabIndex = 25;
            this.lblUser.Text = "@User123";
            this.lblUser.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUser.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pbUser
            // 
            this.pbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUser.Image = global::PicMe.Properties.Resources.newUser;
            this.pbUser.Location = new System.Drawing.Point(18, 15);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(77, 66);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 24;
            this.pbUser.TabStop = false;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this;
            // 
            // _NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUser);
            this.Name = "_NewUser";
            this.Size = new System.Drawing.Size(810, 98);
            this.Load += new System.EventHandler(this._User_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panelUser;
        private Bunifu.UI.WinForms.BunifuLabel lblBio;
        private Bunifu.UI.WinForms.BunifuLabel lblUser;
        private System.Windows.Forms.PictureBox pbUser;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}
