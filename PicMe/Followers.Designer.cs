namespace PicMe
{
    partial class Followers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Followers));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblUser = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblCap = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnRemove = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pbFollowers = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFollowers)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblUser
            // 
            this.lblUser.AllowParentOverrides = false;
            this.lblUser.AutoEllipsis = false;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUser.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(100, 24);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUser.Size = new System.Drawing.Size(172, 28);
            this.lblUser.TabIndex = 48;
            this.lblUser.Text = "@Accumalaca";
            this.lblUser.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUser.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblCap
            // 
            this.lblCap.AllowParentOverrides = false;
            this.lblCap.AutoEllipsis = false;
            this.lblCap.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCap.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblCap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCap.ForeColor = System.Drawing.Color.Black;
            this.lblCap.Location = new System.Drawing.Point(100, 49);
            this.lblCap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblCap.Name = "lblCap";
            this.lblCap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCap.Size = new System.Drawing.Size(187, 30);
            this.lblCap.TabIndex = 50;
            this.lblCap.Text = "Hari yang indah";
            this.lblCap.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCap.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnRemove
            // 
            this.btnRemove.AllowAnimations = true;
            this.btnRemove.AllowMouseEffects = true;
            this.btnRemove.AllowToggling = false;
            this.btnRemove.AnimationSpeed = 200;
            this.btnRemove.AutoGenerateColors = false;
            this.btnRemove.AutoRoundBorders = false;
            this.btnRemove.AutoSizeLeftIcon = true;
            this.btnRemove.AutoSizeRightIcon = true;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemove.ButtonText = "Remove";
            this.btnRemove.ButtonTextMarginLeft = 0;
            this.btnRemove.ColorContrastOnClick = 45;
            this.btnRemove.ColorContrastOnHover = 45;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRemove.CustomizableEdges = borderEdges1;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemove.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRemove.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRemove.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRemove.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRemove.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRemove.IconMarginLeft = 11;
            this.btnRemove.IconPadding = 10;
            this.btnRemove.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRemove.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRemove.IconSize = 25;
            this.btnRemove.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.IdleBorderRadius = 20;
            this.btnRemove.IdleBorderThickness = 1;
            this.btnRemove.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.IdleIconLeftImage = null;
            this.btnRemove.IdleIconRightImage = null;
            this.btnRemove.IndicateFocus = false;
            this.btnRemove.Location = new System.Drawing.Point(352, 30);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRemove.OnDisabledState.BorderRadius = 20;
            this.btnRemove.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemove.OnDisabledState.BorderThickness = 1;
            this.btnRemove.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRemove.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRemove.OnDisabledState.IconLeftImage = null;
            this.btnRemove.OnDisabledState.IconRightImage = null;
            this.btnRemove.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRemove.onHoverState.BorderRadius = 20;
            this.btnRemove.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemove.onHoverState.BorderThickness = 1;
            this.btnRemove.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRemove.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRemove.onHoverState.IconLeftImage = null;
            this.btnRemove.onHoverState.IconRightImage = null;
            this.btnRemove.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.OnIdleState.BorderRadius = 20;
            this.btnRemove.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemove.OnIdleState.BorderThickness = 1;
            this.btnRemove.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRemove.OnIdleState.IconLeftImage = null;
            this.btnRemove.OnIdleState.IconRightImage = null;
            this.btnRemove.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRemove.OnPressedState.BorderRadius = 20;
            this.btnRemove.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemove.OnPressedState.BorderThickness = 1;
            this.btnRemove.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRemove.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRemove.OnPressedState.IconLeftImage = null;
            this.btnRemove.OnPressedState.IconRightImage = null;
            this.btnRemove.Size = new System.Drawing.Size(150, 41);
            this.btnRemove.TabIndex = 51;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemove.TextMarginLeft = 0;
            this.btnRemove.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRemove.UseDefaultRadiusAndThickness = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pbFollowers
            // 
            this.pbFollowers.Image = global::PicMe.Properties.Resources.alreadyUserBold;
            this.pbFollowers.Location = new System.Drawing.Point(19, 11);
            this.pbFollowers.Name = "pbFollowers";
            this.pbFollowers.Size = new System.Drawing.Size(74, 71);
            this.pbFollowers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFollowers.TabIndex = 52;
            this.pbFollowers.TabStop = false;
            // 
            // Followers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbFollowers);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.lblUser);
            this.Name = "Followers";
            this.Size = new System.Drawing.Size(525, 98);
            this.Load += new System.EventHandler(this.Followers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFollowers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel lblCap;
        private Bunifu.UI.WinForms.BunifuLabel lblUser;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRemove;
        private System.Windows.Forms.PictureBox pbFollowers;
    }
}
