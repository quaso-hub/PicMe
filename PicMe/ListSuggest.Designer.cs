namespace PicMe
{
    partial class ListSuggest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSuggest));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelSuggest = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblPosts = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblfu = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnTrends = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panelSuggest.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuggest
            // 
            this.panelSuggest.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelSuggest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSuggest.BackgroundImage")));
            this.panelSuggest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSuggest.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelSuggest.BorderRadius = 20;
            this.panelSuggest.BorderThickness = 1;
            this.panelSuggest.Controls.Add(this.lblPosts);
            this.panelSuggest.Controls.Add(this.lblfu);
            this.panelSuggest.Controls.Add(this.btnTrends);
            this.panelSuggest.Location = new System.Drawing.Point(0, 0);
            this.panelSuggest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSuggest.Name = "panelSuggest";
            this.panelSuggest.ShowBorders = true;
            this.panelSuggest.Size = new System.Drawing.Size(390, 119);
            this.panelSuggest.TabIndex = 7;
            this.panelSuggest.Click += new System.EventHandler(this.panelSuggest_Click);
            // 
            // lblPosts
            // 
            this.lblPosts.AllowParentOverrides = false;
            this.lblPosts.AutoEllipsis = false;
            this.lblPosts.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPosts.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPosts.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosts.ForeColor = System.Drawing.Color.Black;
            this.lblPosts.Location = new System.Drawing.Point(39, 82);
            this.lblPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblPosts.Name = "lblPosts";
            this.lblPosts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPosts.Size = new System.Drawing.Size(110, 25);
            this.lblPosts.TabIndex = 25;
            this.lblPosts.Text = "500K posts";
            this.lblPosts.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPosts.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblfu
            // 
            this.lblfu.AllowParentOverrides = false;
            this.lblfu.AutoEllipsis = false;
            this.lblfu.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblfu.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblfu.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfu.ForeColor = System.Drawing.Color.Black;
            this.lblfu.Location = new System.Drawing.Point(38, 12);
            this.lblfu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblfu.Name = "lblfu";
            this.lblfu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblfu.Size = new System.Drawing.Size(92, 25);
            this.lblfu.TabIndex = 24;
            this.lblfu.Text = "Trending";
            this.lblfu.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblfu.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnTrends
            // 
            this.btnTrends.AllowAnimations = true;
            this.btnTrends.AllowMouseEffects = true;
            this.btnTrends.AllowToggling = false;
            this.btnTrends.AnimationSpeed = 200;
            this.btnTrends.AutoGenerateColors = false;
            this.btnTrends.AutoRoundBorders = false;
            this.btnTrends.AutoSizeLeftIcon = true;
            this.btnTrends.AutoSizeRightIcon = true;
            this.btnTrends.BackColor = System.Drawing.Color.Transparent;
            this.btnTrends.BackColor1 = System.Drawing.Color.Transparent;
            this.btnTrends.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrends.BackgroundImage")));
            this.btnTrends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrends.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnTrends.ButtonText = "Sunmorries";
            this.btnTrends.ButtonTextMarginLeft = 0;
            this.btnTrends.ColorContrastOnClick = 45;
            this.btnTrends.ColorContrastOnHover = 45;
            this.btnTrends.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnTrends.CustomizableEdges = borderEdges1;
            this.btnTrends.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTrends.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTrends.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTrends.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTrends.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTrends.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrends.ForeColor = System.Drawing.Color.Black;
            this.btnTrends.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrends.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTrends.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTrends.IconMarginLeft = 11;
            this.btnTrends.IconPadding = 10;
            this.btnTrends.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrends.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTrends.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTrends.IconSize = 25;
            this.btnTrends.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnTrends.IdleBorderRadius = 20;
            this.btnTrends.IdleBorderThickness = 1;
            this.btnTrends.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnTrends.IdleIconLeftImage = null;
            this.btnTrends.IdleIconRightImage = null;
            this.btnTrends.IndicateFocus = false;
            this.btnTrends.Location = new System.Drawing.Point(0, 3);
            this.btnTrends.Name = "btnTrends";
            this.btnTrends.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTrends.OnDisabledState.BorderRadius = 20;
            this.btnTrends.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrends.OnDisabledState.BorderThickness = 1;
            this.btnTrends.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTrends.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTrends.OnDisabledState.IconLeftImage = null;
            this.btnTrends.OnDisabledState.IconRightImage = null;
            this.btnTrends.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.btnTrends.onHoverState.BorderRadius = 20;
            this.btnTrends.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrends.onHoverState.BorderThickness = 1;
            this.btnTrends.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTrends.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTrends.onHoverState.IconLeftImage = null;
            this.btnTrends.onHoverState.IconRightImage = null;
            this.btnTrends.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnTrends.OnIdleState.BorderRadius = 20;
            this.btnTrends.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnTrends.OnIdleState.BorderThickness = 1;
            this.btnTrends.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnTrends.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnTrends.OnIdleState.IconLeftImage = null;
            this.btnTrends.OnIdleState.IconRightImage = null;
            this.btnTrends.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTrends.OnPressedState.BorderRadius = 20;
            this.btnTrends.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrends.OnPressedState.BorderThickness = 1;
            this.btnTrends.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTrends.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTrends.OnPressedState.IconLeftImage = null;
            this.btnTrends.OnPressedState.IconRightImage = null;
            this.btnTrends.Size = new System.Drawing.Size(387, 109);
            this.btnTrends.TabIndex = 9;
            this.btnTrends.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrends.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTrends.TextMarginLeft = 0;
            this.btnTrends.TextPadding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTrends.UseDefaultRadiusAndThickness = true;
            this.btnTrends.Click += new System.EventHandler(this.btnTrends_Click);
            // 
            // ListSuggest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSuggest);
            this.Name = "ListSuggest";
            this.Size = new System.Drawing.Size(392, 130);
            this.Load += new System.EventHandler(this.ListSuggest_Load);
            this.panelSuggest.ResumeLayout(false);
            this.panelSuggest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panelSuggest;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTrends;
        private Bunifu.UI.WinForms.BunifuLabel lblPosts;
        private Bunifu.UI.WinForms.BunifuLabel lblfu;
    }
}
