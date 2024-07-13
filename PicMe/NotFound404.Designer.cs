namespace PicMe
{
    partial class NotFound404
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotFound404));
            this.panel404 = new System.Windows.Forms.Panel();
            this.lbl404 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pb404 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel404.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb404)).BeginInit();
            this.SuspendLayout();
            // 
            // panel404
            // 
            this.panel404.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel404.Controls.Add(this.lbl404);
            this.panel404.Controls.Add(this.pb404);
            this.panel404.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel404.Location = new System.Drawing.Point(0, 0);
            this.panel404.Name = "panel404";
            this.panel404.Size = new System.Drawing.Size(810, 98);
            this.panel404.TabIndex = 1;
            this.panel404.MouseLeave += new System.EventHandler(this.panel404_MouseLeave);
            this.panel404.MouseHover += new System.EventHandler(this.panel404_MouseHover);
            // 
            // lbl404
            // 
            this.lbl404.AllowParentOverrides = false;
            this.lbl404.AutoEllipsis = false;
            this.lbl404.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl404.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl404.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl404.ForeColor = System.Drawing.Color.Black;
            this.lbl404.Location = new System.Drawing.Point(111, 35);
            this.lbl404.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl404.Name = "lbl404";
            this.lbl404.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl404.Size = new System.Drawing.Size(175, 28);
            this.lbl404.TabIndex = 25;
            this.lbl404.Text = "Nothing Found!";
            this.lbl404.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl404.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pb404
            // 
            this.pb404.Image = global::PicMe.Properties.Resources._;
            this.pb404.Location = new System.Drawing.Point(18, 15);
            this.pb404.Name = "pb404";
            this.pb404.Size = new System.Drawing.Size(77, 66);
            this.pb404.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb404.TabIndex = 24;
            this.pb404.TabStop = false;
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
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this;
            // 
            // NotFound404
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel404);
            this.Name = "NotFound404";
            this.Size = new System.Drawing.Size(810, 98);
            this.Load += new System.EventHandler(this.NotFound404_Load);
            this.panel404.ResumeLayout(false);
            this.panel404.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb404)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel404;
        private Bunifu.UI.WinForms.BunifuLabel lbl404;
        private System.Windows.Forms.PictureBox pb404;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}
