namespace PicMe
{
    partial class FormHome
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblGreet = new Bunifu.UI.WinForms.BunifuLabel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSide = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.labelDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnHome = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNotif = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPost = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.btnLogout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnProfile = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAccount = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.timerAccount = new System.Windows.Forms.Timer(this.components);
            this.timerSidebar = new System.Windows.Forms.Timer(this.components);
            this.scroll = new System.Windows.Forms.FlowLayoutPanel();
            this.suggest = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.panelSuggest = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblfu = new Bunifu.UI.WinForms.BunifuLabel();
            this.notifHome = new System.Windows.Forms.NotifyIcon(this.components);
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.suggest.SuspendLayout();
            this.panelSuggest.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblGreet
            // 
            this.lblGreet.AllowParentOverrides = false;
            this.lblGreet.AutoEllipsis = false;
            this.lblGreet.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGreet.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblGreet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGreet.Location = new System.Drawing.Point(48, 149);
            this.lblGreet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblGreet.Name = "lblGreet";
            this.lblGreet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGreet.Size = new System.Drawing.Size(243, 30);
            this.lblGreet.TabIndex = 22;
            this.lblGreet.Text = "Selamat pagi @user!";
            this.lblGreet.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblGreet.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.HotPink;
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.btnHome);
            this.sidebar.Controls.Add(this.btnSearch);
            this.sidebar.Controls.Add(this.btnNotif);
            this.sidebar.Controls.Add(this.btnPost);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidebar.MaximumSize = new System.Drawing.Size(376, 1020);
            this.sidebar.MinimumSize = new System.Drawing.Size(102, 1020);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(376, 1020);
            this.sidebar.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblGreet);
            this.panel2.Controls.Add(this.btnSide);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 232);
            this.panel2.TabIndex = 15;
            // 
            // btnSide
            // 
            this.btnSide.AllowAnimations = true;
            this.btnSide.AllowMouseEffects = true;
            this.btnSide.AllowToggling = false;
            this.btnSide.AnimationSpeed = 200;
            this.btnSide.AutoGenerateColors = false;
            this.btnSide.AutoRoundBorders = false;
            this.btnSide.AutoSizeLeftIcon = true;
            this.btnSide.AutoSizeRightIcon = true;
            this.btnSide.BackColor = System.Drawing.Color.Transparent;
            this.btnSide.BackColor1 = System.Drawing.Color.Transparent;
            this.btnSide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSide.BackgroundImage")));
            this.btnSide.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnSide.ButtonText = "";
            this.btnSide.ButtonTextMarginLeft = 0;
            this.btnSide.ColorContrastOnClick = 45;
            this.btnSide.ColorContrastOnHover = 45;
            this.btnSide.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSide.CustomizableEdges = borderEdges1;
            this.btnSide.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSide.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnSide.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnSide.DisabledForecolor = System.Drawing.Color.Transparent;
            this.btnSide.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSide.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSide.ForeColor = System.Drawing.Color.White;
            this.btnSide.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSide.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSide.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.btnSide.IconMarginLeft = 11;
            this.btnSide.IconPadding = 10;
            this.btnSide.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSide.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSide.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnSide.IconSize = 10;
            this.btnSide.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnSide.IdleBorderRadius = 1;
            this.btnSide.IdleBorderThickness = 1;
            this.btnSide.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSide.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnSide.IdleIconLeftImage")));
            this.btnSide.IdleIconRightImage = null;
            this.btnSide.IndicateFocus = false;
            this.btnSide.Location = new System.Drawing.Point(4, 5);
            this.btnSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSide.Name = "btnSide";
            this.btnSide.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSide.OnDisabledState.BorderRadius = 1;
            this.btnSide.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSide.OnDisabledState.BorderThickness = 1;
            this.btnSide.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnSide.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnSide.OnDisabledState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnSide.OnDisabledState.IconLeftImage")));
            this.btnSide.OnDisabledState.IconRightImage = null;
            this.btnSide.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSide.onHoverState.BorderRadius = 1;
            this.btnSide.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSide.onHoverState.BorderThickness = 1;
            this.btnSide.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSide.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSide.onHoverState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage")));
            this.btnSide.onHoverState.IconRightImage = null;
            this.btnSide.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSide.OnIdleState.BorderRadius = 1;
            this.btnSide.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnSide.OnIdleState.BorderThickness = 1;
            this.btnSide.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnSide.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSide.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnSide.OnIdleState.IconLeftImage")));
            this.btnSide.OnIdleState.IconRightImage = null;
            this.btnSide.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSide.OnPressedState.BorderRadius = 1;
            this.btnSide.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSide.OnPressedState.BorderThickness = 1;
            this.btnSide.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btnSide.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSide.OnPressedState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage1")));
            this.btnSide.OnPressedState.IconRightImage = null;
            this.btnSide.Size = new System.Drawing.Size(84, 108);
            this.btnSide.TabIndex = 20;
            this.btnSide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSide.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSide.TextMarginLeft = 0;
            this.btnSide.TextPadding = new System.Windows.Forms.Padding(-5, 0, 0, 0);
            this.btnSide.UseDefaultRadiusAndThickness = true;
            this.btnSide.Click += new System.EventHandler(this.btnSide_Click);
            // 
            // labelDate
            // 
            this.labelDate.AllowParentOverrides = false;
            this.labelDate.AutoEllipsis = false;
            this.labelDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDate.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(105, 48);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelDate.Name = "labelDate";
            this.labelDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDate.Size = new System.Drawing.Size(144, 34);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "Th, 19 April";
            this.labelDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnHome
            // 
            this.btnHome.AllowAnimations = true;
            this.btnHome.AllowMouseEffects = true;
            this.btnHome.AllowToggling = false;
            this.btnHome.AnimationSpeed = 200;
            this.btnHome.AutoGenerateColors = false;
            this.btnHome.AutoRoundBorders = false;
            this.btnHome.AutoSizeLeftIcon = true;
            this.btnHome.AutoSizeRightIcon = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackColor1 = System.Drawing.Color.HotPink;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnHome.ButtonText = "Home";
            this.btnHome.ButtonTextMarginLeft = 0;
            this.btnHome.ColorContrastOnClick = 45;
            this.btnHome.ColorContrastOnHover = 45;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnHome.CustomizableEdges = borderEdges2;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnHome.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnHome.DisabledForecolor = System.Drawing.Color.Transparent;
            this.btnHome.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHome.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnHome.IconMarginLeft = 11;
            this.btnHome.IconPadding = 10;
            this.btnHome.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnHome.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnHome.IconSize = 10;
            this.btnHome.IdleBorderColor = System.Drawing.Color.HotPink;
            this.btnHome.IdleBorderRadius = 50;
            this.btnHome.IdleBorderThickness = 1;
            this.btnHome.IdleFillColor = System.Drawing.Color.HotPink;
            this.btnHome.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnHome.IdleIconLeftImage")));
            this.btnHome.IdleIconRightImage = null;
            this.btnHome.IndicateFocus = false;
            this.btnHome.Location = new System.Drawing.Point(4, 247);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.OnDisabledState.BorderRadius = 50;
            this.btnHome.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHome.OnDisabledState.BorderThickness = 1;
            this.btnHome.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.OnDisabledState.IconLeftImage = null;
            this.btnHome.OnDisabledState.IconRightImage = null;
            this.btnHome.onHoverState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnHome.onHoverState.BorderRadius = 50;
            this.btnHome.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHome.onHoverState.BorderThickness = 1;
            this.btnHome.onHoverState.FillColor = System.Drawing.Color.DeepPink;
            this.btnHome.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHome.onHoverState.IconLeftImage = null;
            this.btnHome.onHoverState.IconRightImage = null;
            this.btnHome.OnIdleState.BorderColor = System.Drawing.Color.HotPink;
            this.btnHome.OnIdleState.BorderRadius = 50;
            this.btnHome.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnHome.OnIdleState.BorderThickness = 1;
            this.btnHome.OnIdleState.FillColor = System.Drawing.Color.HotPink;
            this.btnHome.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnHome.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnHome.OnIdleState.IconLeftImage")));
            this.btnHome.OnIdleState.IconRightImage = null;
            this.btnHome.OnPressedState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnHome.OnPressedState.BorderRadius = 50;
            this.btnHome.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHome.OnPressedState.BorderThickness = 1;
            this.btnHome.OnPressedState.FillColor = System.Drawing.Color.DeepPink;
            this.btnHome.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHome.OnPressedState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage2")));
            this.btnHome.OnPressedState.IconRightImage = null;
            this.btnHome.Size = new System.Drawing.Size(363, 91);
            this.btnHome.TabIndex = 7;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHome.TextMarginLeft = 0;
            this.btnHome.TextPadding = new System.Windows.Forms.Padding(-20, 0, 0, 0);
            this.btnHome.UseDefaultRadiusAndThickness = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AllowAnimations = true;
            this.btnSearch.AllowMouseEffects = true;
            this.btnSearch.AllowToggling = false;
            this.btnSearch.AnimationSpeed = 200;
            this.btnSearch.AutoGenerateColors = false;
            this.btnSearch.AutoRoundBorders = false;
            this.btnSearch.AutoSizeLeftIcon = true;
            this.btnSearch.AutoSizeRightIcon = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackColor1 = System.Drawing.Color.HotPink;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.ButtonTextMarginLeft = 0;
            this.btnSearch.ColorContrastOnClick = 45;
            this.btnSearch.ColorContrastOnHover = 45;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSearch.CustomizableEdges = borderEdges3;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnSearch.DisabledForecolor = System.Drawing.Color.Transparent;
            this.btnSearch.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSearch.IconMarginLeft = 11;
            this.btnSearch.IconPadding = 10;
            this.btnSearch.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSearch.IconSize = 10;
            this.btnSearch.IdleBorderColor = System.Drawing.Color.HotPink;
            this.btnSearch.IdleBorderRadius = 50;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleFillColor = System.Drawing.Color.HotPink;
            this.btnSearch.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.IdleIconLeftImage")));
            this.btnSearch.IdleIconRightImage = null;
            this.btnSearch.IndicateFocus = false;
            this.btnSearch.Location = new System.Drawing.Point(4, 348);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.OnDisabledState.BorderRadius = 50;
            this.btnSearch.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnDisabledState.BorderThickness = 1;
            this.btnSearch.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.OnDisabledState.IconLeftImage = null;
            this.btnSearch.OnDisabledState.IconRightImage = null;
            this.btnSearch.onHoverState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnSearch.onHoverState.BorderRadius = 50;
            this.btnSearch.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.onHoverState.BorderThickness = 1;
            this.btnSearch.onHoverState.FillColor = System.Drawing.Color.DeepPink;
            this.btnSearch.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.onHoverState.IconLeftImage = null;
            this.btnSearch.onHoverState.IconRightImage = null;
            this.btnSearch.OnIdleState.BorderColor = System.Drawing.Color.HotPink;
            this.btnSearch.OnIdleState.BorderRadius = 50;
            this.btnSearch.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnSearch.OnIdleState.BorderThickness = 1;
            this.btnSearch.OnIdleState.FillColor = System.Drawing.Color.HotPink;
            this.btnSearch.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.OnIdleState.IconLeftImage")));
            this.btnSearch.OnIdleState.IconRightImage = null;
            this.btnSearch.OnPressedState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnSearch.OnPressedState.BorderRadius = 50;
            this.btnSearch.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnPressedState.BorderThickness = 1;
            this.btnSearch.OnPressedState.FillColor = System.Drawing.Color.DeepPink;
            this.btnSearch.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnPressedState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage3")));
            this.btnSearch.OnPressedState.IconRightImage = null;
            this.btnSearch.Size = new System.Drawing.Size(363, 91);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.TextMarginLeft = 0;
            this.btnSearch.TextPadding = new System.Windows.Forms.Padding(-15, 0, 0, 0);
            this.btnSearch.UseDefaultRadiusAndThickness = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNotif
            // 
            this.btnNotif.AllowAnimations = true;
            this.btnNotif.AllowMouseEffects = true;
            this.btnNotif.AllowToggling = false;
            this.btnNotif.AnimationSpeed = 200;
            this.btnNotif.AutoGenerateColors = false;
            this.btnNotif.AutoRoundBorders = false;
            this.btnNotif.AutoSizeLeftIcon = true;
            this.btnNotif.AutoSizeRightIcon = true;
            this.btnNotif.BackColor = System.Drawing.Color.Transparent;
            this.btnNotif.BackColor1 = System.Drawing.Color.HotPink;
            this.btnNotif.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotif.BackgroundImage")));
            this.btnNotif.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnNotif.ButtonText = "Notification";
            this.btnNotif.ButtonTextMarginLeft = 0;
            this.btnNotif.ColorContrastOnClick = 45;
            this.btnNotif.ColorContrastOnHover = 45;
            this.btnNotif.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnNotif.CustomizableEdges = borderEdges4;
            this.btnNotif.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNotif.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnNotif.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnNotif.DisabledForecolor = System.Drawing.Color.Transparent;
            this.btnNotif.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNotif.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotif.ForeColor = System.Drawing.Color.White;
            this.btnNotif.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotif.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNotif.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNotif.IconMarginLeft = 11;
            this.btnNotif.IconPadding = 10;
            this.btnNotif.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotif.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNotif.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNotif.IconSize = 10;
            this.btnNotif.IdleBorderColor = System.Drawing.Color.HotPink;
            this.btnNotif.IdleBorderRadius = 50;
            this.btnNotif.IdleBorderThickness = 1;
            this.btnNotif.IdleFillColor = System.Drawing.Color.HotPink;
            this.btnNotif.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnNotif.IdleIconLeftImage")));
            this.btnNotif.IdleIconRightImage = null;
            this.btnNotif.IndicateFocus = false;
            this.btnNotif.Location = new System.Drawing.Point(4, 449);
            this.btnNotif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNotif.Name = "btnNotif";
            this.btnNotif.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNotif.OnDisabledState.BorderRadius = 50;
            this.btnNotif.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotif.OnDisabledState.BorderThickness = 1;
            this.btnNotif.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnNotif.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnNotif.OnDisabledState.IconLeftImage = null;
            this.btnNotif.OnDisabledState.IconRightImage = null;
            this.btnNotif.onHoverState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnNotif.onHoverState.BorderRadius = 50;
            this.btnNotif.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotif.onHoverState.BorderThickness = 1;
            this.btnNotif.onHoverState.FillColor = System.Drawing.Color.DeepPink;
            this.btnNotif.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNotif.onHoverState.IconLeftImage = null;
            this.btnNotif.onHoverState.IconRightImage = null;
            this.btnNotif.OnIdleState.BorderColor = System.Drawing.Color.HotPink;
            this.btnNotif.OnIdleState.BorderRadius = 50;
            this.btnNotif.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnNotif.OnIdleState.BorderThickness = 1;
            this.btnNotif.OnIdleState.FillColor = System.Drawing.Color.HotPink;
            this.btnNotif.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNotif.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnNotif.OnIdleState.IconLeftImage")));
            this.btnNotif.OnIdleState.IconRightImage = null;
            this.btnNotif.OnPressedState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnNotif.OnPressedState.BorderRadius = 50;
            this.btnNotif.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotif.OnPressedState.BorderThickness = 1;
            this.btnNotif.OnPressedState.FillColor = System.Drawing.Color.DeepPink;
            this.btnNotif.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNotif.OnPressedState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage4")));
            this.btnNotif.OnPressedState.IconRightImage = null;
            this.btnNotif.Size = new System.Drawing.Size(363, 91);
            this.btnNotif.TabIndex = 17;
            this.btnNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNotif.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNotif.TextMarginLeft = 0;
            this.btnNotif.TextPadding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnNotif.UseDefaultRadiusAndThickness = true;
            this.btnNotif.Click += new System.EventHandler(this.btnNotif_Click);
            // 
            // btnPost
            // 
            this.btnPost.AllowAnimations = true;
            this.btnPost.AllowMouseEffects = true;
            this.btnPost.AllowToggling = false;
            this.btnPost.AnimationSpeed = 200;
            this.btnPost.AutoGenerateColors = false;
            this.btnPost.AutoRoundBorders = false;
            this.btnPost.AutoSizeLeftIcon = true;
            this.btnPost.AutoSizeRightIcon = true;
            this.btnPost.BackColor = System.Drawing.Color.Transparent;
            this.btnPost.BackColor1 = System.Drawing.Color.HotPink;
            this.btnPost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPost.BackgroundImage")));
            this.btnPost.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnPost.ButtonText = "Post";
            this.btnPost.ButtonTextMarginLeft = 0;
            this.btnPost.ColorContrastOnClick = 45;
            this.btnPost.ColorContrastOnHover = 45;
            this.btnPost.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnPost.CustomizableEdges = borderEdges5;
            this.btnPost.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPost.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnPost.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnPost.DisabledForecolor = System.Drawing.Color.Transparent;
            this.btnPost.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPost.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPost.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPost.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPost.IconMarginLeft = 11;
            this.btnPost.IconPadding = 10;
            this.btnPost.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPost.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPost.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPost.IconSize = 10;
            this.btnPost.IdleBorderColor = System.Drawing.Color.HotPink;
            this.btnPost.IdleBorderRadius = 50;
            this.btnPost.IdleBorderThickness = 1;
            this.btnPost.IdleFillColor = System.Drawing.Color.HotPink;
            this.btnPost.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnPost.IdleIconLeftImage")));
            this.btnPost.IdleIconRightImage = null;
            this.btnPost.IndicateFocus = false;
            this.btnPost.Location = new System.Drawing.Point(4, 550);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPost.Name = "btnPost";
            this.btnPost.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPost.OnDisabledState.BorderRadius = 50;
            this.btnPost.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPost.OnDisabledState.BorderThickness = 1;
            this.btnPost.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnPost.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnPost.OnDisabledState.IconLeftImage = null;
            this.btnPost.OnDisabledState.IconRightImage = null;
            this.btnPost.onHoverState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnPost.onHoverState.BorderRadius = 50;
            this.btnPost.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPost.onHoverState.BorderThickness = 1;
            this.btnPost.onHoverState.FillColor = System.Drawing.Color.DeepPink;
            this.btnPost.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPost.onHoverState.IconLeftImage = null;
            this.btnPost.onHoverState.IconRightImage = null;
            this.btnPost.OnIdleState.BorderColor = System.Drawing.Color.HotPink;
            this.btnPost.OnIdleState.BorderRadius = 50;
            this.btnPost.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnPost.OnIdleState.BorderThickness = 1;
            this.btnPost.OnIdleState.FillColor = System.Drawing.Color.HotPink;
            this.btnPost.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPost.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnPost.OnIdleState.IconLeftImage")));
            this.btnPost.OnIdleState.IconRightImage = null;
            this.btnPost.OnPressedState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnPost.OnPressedState.BorderRadius = 50;
            this.btnPost.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPost.OnPressedState.BorderThickness = 1;
            this.btnPost.OnPressedState.FillColor = System.Drawing.Color.DeepPink;
            this.btnPost.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPost.OnPressedState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage5")));
            this.btnPost.OnPressedState.IconRightImage = null;
            this.btnPost.Size = new System.Drawing.Size(363, 91);
            this.btnPost.TabIndex = 18;
            this.btnPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPost.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPost.TextMarginLeft = 0;
            this.btnPost.TextPadding = new System.Windows.Forms.Padding(-29, 0, 0, 0);
            this.btnPost.UseDefaultRadiusAndThickness = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelAccount);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Location = new System.Drawing.Point(4, 651);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 354);
            this.panel1.TabIndex = 19;
            // 
            // panelAccount
            // 
            this.panelAccount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAccount.Controls.Add(this.btnLogout);
            this.panelAccount.Controls.Add(this.btnProfile);
            this.panelAccount.Location = new System.Drawing.Point(4, 82);
            this.panelAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAccount.MaximumSize = new System.Drawing.Size(363, 140);
            this.panelAccount.MinimumSize = new System.Drawing.Size(363, 18);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(363, 137);
            this.panelAccount.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.AllowAnimations = true;
            this.btnLogout.AllowMouseEffects = true;
            this.btnLogout.AllowToggling = false;
            this.btnLogout.AnimationSpeed = 200;
            this.btnLogout.AutoGenerateColors = false;
            this.btnLogout.AutoRoundBorders = false;
            this.btnLogout.AutoSizeLeftIcon = true;
            this.btnLogout.AutoSizeRightIcon = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackColor1 = System.Drawing.Color.HotPink;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnLogout.ButtonText = "Logout";
            this.btnLogout.ButtonTextMarginLeft = 0;
            this.btnLogout.ColorContrastOnClick = 45;
            this.btnLogout.ColorContrastOnHover = 45;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnLogout.CustomizableEdges = borderEdges6;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnLogout.DisabledForecolor = System.Drawing.Color.Transparent;
            this.btnLogout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogout.IconMarginLeft = 11;
            this.btnLogout.IconPadding = 10;
            this.btnLogout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogout.IconSize = 10;
            this.btnLogout.IdleBorderColor = System.Drawing.Color.HotPink;
            this.btnLogout.IdleBorderRadius = 30;
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleFillColor = System.Drawing.Color.HotPink;
            this.btnLogout.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.IdleIconLeftImage")));
            this.btnLogout.IdleIconRightImage = null;
            this.btnLogout.IndicateFocus = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 68);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnDisabledState.BorderRadius = 30;
            this.btnLogout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnDisabledState.BorderThickness = 1;
            this.btnLogout.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnDisabledState.IconLeftImage = null;
            this.btnLogout.OnDisabledState.IconRightImage = null;
            this.btnLogout.onHoverState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnLogout.onHoverState.BorderRadius = 30;
            this.btnLogout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.onHoverState.BorderThickness = 1;
            this.btnLogout.onHoverState.FillColor = System.Drawing.Color.DeepPink;
            this.btnLogout.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.onHoverState.IconLeftImage = null;
            this.btnLogout.onHoverState.IconRightImage = null;
            this.btnLogout.OnIdleState.BorderColor = System.Drawing.Color.HotPink;
            this.btnLogout.OnIdleState.BorderRadius = 30;
            this.btnLogout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnLogout.OnIdleState.BorderThickness = 1;
            this.btnLogout.OnIdleState.FillColor = System.Drawing.Color.HotPink;
            this.btnLogout.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.OnIdleState.IconLeftImage")));
            this.btnLogout.OnIdleState.IconRightImage = null;
            this.btnLogout.OnPressedState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnLogout.OnPressedState.BorderRadius = 30;
            this.btnLogout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnPressedState.BorderThickness = 1;
            this.btnLogout.OnPressedState.FillColor = System.Drawing.Color.DeepPink;
            this.btnLogout.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.OnPressedState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage6")));
            this.btnLogout.OnPressedState.IconRightImage = null;
            this.btnLogout.Size = new System.Drawing.Size(363, 68);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.TextMarginLeft = 0;
            this.btnLogout.TextPadding = new System.Windows.Forms.Padding(-25, 0, 0, 0);
            this.btnLogout.UseDefaultRadiusAndThickness = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.AllowAnimations = true;
            this.btnProfile.AllowMouseEffects = true;
            this.btnProfile.AllowToggling = false;
            this.btnProfile.AnimationSpeed = 200;
            this.btnProfile.AutoGenerateColors = false;
            this.btnProfile.AutoRoundBorders = false;
            this.btnProfile.AutoSizeLeftIcon = true;
            this.btnProfile.AutoSizeRightIcon = true;
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackColor1 = System.Drawing.Color.HotPink;
            this.btnProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.BackgroundImage")));
            this.btnProfile.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnProfile.ButtonText = "Profile";
            this.btnProfile.ButtonTextMarginLeft = 0;
            this.btnProfile.ColorContrastOnClick = 45;
            this.btnProfile.ColorContrastOnHover = 45;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnProfile.CustomizableEdges = borderEdges7;
            this.btnProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProfile.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnProfile.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnProfile.DisabledForecolor = System.Drawing.Color.Transparent;
            this.btnProfile.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnProfile.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnProfile.IconMarginLeft = 11;
            this.btnProfile.IconPadding = 10;
            this.btnProfile.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfile.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnProfile.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnProfile.IconSize = 10;
            this.btnProfile.IdleBorderColor = System.Drawing.Color.HotPink;
            this.btnProfile.IdleBorderRadius = 30;
            this.btnProfile.IdleBorderThickness = 1;
            this.btnProfile.IdleFillColor = System.Drawing.Color.HotPink;
            this.btnProfile.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.IdleIconLeftImage")));
            this.btnProfile.IdleIconRightImage = null;
            this.btnProfile.IndicateFocus = false;
            this.btnProfile.Location = new System.Drawing.Point(0, 2);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnProfile.OnDisabledState.BorderRadius = 30;
            this.btnProfile.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProfile.OnDisabledState.BorderThickness = 1;
            this.btnProfile.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnProfile.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnProfile.OnDisabledState.IconLeftImage = null;
            this.btnProfile.OnDisabledState.IconRightImage = null;
            this.btnProfile.onHoverState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnProfile.onHoverState.BorderRadius = 30;
            this.btnProfile.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProfile.onHoverState.BorderThickness = 1;
            this.btnProfile.onHoverState.FillColor = System.Drawing.Color.DeepPink;
            this.btnProfile.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnProfile.onHoverState.IconLeftImage = null;
            this.btnProfile.onHoverState.IconRightImage = null;
            this.btnProfile.OnIdleState.BorderColor = System.Drawing.Color.HotPink;
            this.btnProfile.OnIdleState.BorderRadius = 30;
            this.btnProfile.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnProfile.OnIdleState.BorderThickness = 1;
            this.btnProfile.OnIdleState.FillColor = System.Drawing.Color.HotPink;
            this.btnProfile.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnProfile.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.OnIdleState.IconLeftImage")));
            this.btnProfile.OnIdleState.IconRightImage = null;
            this.btnProfile.OnPressedState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnProfile.OnPressedState.BorderRadius = 30;
            this.btnProfile.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProfile.OnPressedState.BorderThickness = 1;
            this.btnProfile.OnPressedState.FillColor = System.Drawing.Color.DeepPink;
            this.btnProfile.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnProfile.OnPressedState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage7")));
            this.btnProfile.OnPressedState.IconRightImage = null;
            this.btnProfile.Size = new System.Drawing.Size(363, 66);
            this.btnProfile.TabIndex = 19;
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProfile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProfile.TextMarginLeft = 0;
            this.btnProfile.TextPadding = new System.Windows.Forms.Padding(-30, 0, 0, 0);
            this.btnProfile.UseDefaultRadiusAndThickness = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.AllowAnimations = true;
            this.btnAccount.AllowMouseEffects = true;
            this.btnAccount.AllowToggling = false;
            this.btnAccount.AnimationSpeed = 200;
            this.btnAccount.AutoGenerateColors = false;
            this.btnAccount.AutoRoundBorders = false;
            this.btnAccount.AutoSizeLeftIcon = true;
            this.btnAccount.AutoSizeRightIcon = true;
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.BackColor1 = System.Drawing.Color.HotPink;
            this.btnAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.BackgroundImage")));
            this.btnAccount.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnAccount.ButtonText = "@Username";
            this.btnAccount.ButtonTextMarginLeft = 0;
            this.btnAccount.ColorContrastOnClick = 45;
            this.btnAccount.ColorContrastOnHover = 45;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnAccount.CustomizableEdges = borderEdges8;
            this.btnAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccount.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnAccount.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnAccount.DisabledForecolor = System.Drawing.Color.Transparent;
            this.btnAccount.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAccount.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAccount.IconMarginLeft = 11;
            this.btnAccount.IconPadding = 10;
            this.btnAccount.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAccount.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAccount.IconSize = 10;
            this.btnAccount.IdleBorderColor = System.Drawing.Color.HotPink;
            this.btnAccount.IdleBorderRadius = 50;
            this.btnAccount.IdleBorderThickness = 1;
            this.btnAccount.IdleFillColor = System.Drawing.Color.HotPink;
            this.btnAccount.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.IdleIconLeftImage")));
            this.btnAccount.IdleIconRightImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.IdleIconRightImage")));
            this.btnAccount.IndicateFocus = false;
            this.btnAccount.Location = new System.Drawing.Point(4, 230);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAccount.OnDisabledState.BorderRadius = 50;
            this.btnAccount.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnAccount.OnDisabledState.BorderThickness = 1;
            this.btnAccount.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnAccount.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnAccount.OnDisabledState.IconLeftImage = null;
            this.btnAccount.OnDisabledState.IconRightImage = null;
            this.btnAccount.onHoverState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnAccount.onHoverState.BorderRadius = 50;
            this.btnAccount.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnAccount.onHoverState.BorderThickness = 1;
            this.btnAccount.onHoverState.FillColor = System.Drawing.Color.DeepPink;
            this.btnAccount.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAccount.onHoverState.IconLeftImage = null;
            this.btnAccount.onHoverState.IconRightImage = null;
            this.btnAccount.OnIdleState.BorderColor = System.Drawing.Color.HotPink;
            this.btnAccount.OnIdleState.BorderRadius = 50;
            this.btnAccount.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnAccount.OnIdleState.BorderThickness = 1;
            this.btnAccount.OnIdleState.FillColor = System.Drawing.Color.HotPink;
            this.btnAccount.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAccount.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.OnIdleState.IconLeftImage")));
            this.btnAccount.OnIdleState.IconRightImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.OnIdleState.IconRightImage")));
            this.btnAccount.OnPressedState.BorderColor = System.Drawing.Color.DeepPink;
            this.btnAccount.OnPressedState.BorderRadius = 50;
            this.btnAccount.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnAccount.OnPressedState.BorderThickness = 1;
            this.btnAccount.OnPressedState.FillColor = System.Drawing.Color.DeepPink;
            this.btnAccount.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAccount.OnPressedState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage8")));
            this.btnAccount.OnPressedState.IconRightImage = ((System.Drawing.Image)(resources.GetObject("resource.IconRightImage")));
            this.btnAccount.Size = new System.Drawing.Size(363, 91);
            this.btnAccount.TabIndex = 21;
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAccount.TextMarginLeft = 0;
            this.btnAccount.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAccount.UseDefaultRadiusAndThickness = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // timerAccount
            // 
            this.timerAccount.Interval = 10;
            this.timerAccount.Tick += new System.EventHandler(this.timerAccount_Tick);
            // 
            // timerSidebar
            // 
            this.timerSidebar.Interval = 1;
            this.timerSidebar.Tick += new System.EventHandler(this.timerSidebar_Tick);
            // 
            // scroll
            // 
            this.scroll.AutoScroll = true;
            this.scroll.Location = new System.Drawing.Point(392, 10);
            this.scroll.Name = "scroll";
            this.scroll.Size = new System.Drawing.Size(924, 989);
            this.scroll.TabIndex = 8;
            // 
            // suggest
            // 
            this.suggest.AutoScroll = true;
            this.suggest.Controls.Add(this.bunifuPanel1);
            this.suggest.Controls.Add(this.panelSuggest);
            this.suggest.Dock = System.Windows.Forms.DockStyle.Right;
            this.suggest.Location = new System.Drawing.Point(1347, 0);
            this.suggest.Name = "suggest";
            this.suggest.Size = new System.Drawing.Size(396, 1011);
            this.suggest.TabIndex = 9;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPanel1.Location = new System.Drawing.Point(4, 5);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(384, 49);
            this.bunifuPanel1.TabIndex = 23;
            // 
            // panelSuggest
            // 
            this.panelSuggest.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelSuggest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSuggest.BackgroundImage")));
            this.panelSuggest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSuggest.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelSuggest.BorderRadius = 20;
            this.panelSuggest.BorderThickness = 1;
            this.panelSuggest.Controls.Add(this.lblfu);
            this.panelSuggest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSuggest.Location = new System.Drawing.Point(4, 64);
            this.panelSuggest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSuggest.Name = "panelSuggest";
            this.panelSuggest.ShowBorders = true;
            this.panelSuggest.Size = new System.Drawing.Size(384, 150);
            this.panelSuggest.TabIndex = 6;
            // 
            // lblfu
            // 
            this.lblfu.AllowParentOverrides = false;
            this.lblfu.AutoEllipsis = false;
            this.lblfu.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblfu.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblfu.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfu.ForeColor = System.Drawing.Color.Black;
            this.lblfu.Location = new System.Drawing.Point(40, 48);
            this.lblfu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblfu.Name = "lblfu";
            this.lblfu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblfu.Size = new System.Drawing.Size(271, 47);
            this.lblfu.TabIndex = 22;
            this.lblfu.Text = "Trends for You";
            this.lblfu.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblfu.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // notifHome
            // 
            this.notifHome.Text = "notifyIcon1";
            this.notifHome.Visible = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1743, 1011);
            this.Controls.Add(this.suggest);
            this.Controls.Add(this.scroll);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelAccount.ResumeLayout(false);
            this.suggest.ResumeLayout(false);
            this.panelSuggest.ResumeLayout(false);
            this.panelSuggest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel panelSuggest;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSide;
        private Bunifu.UI.WinForms.BunifuLabel labelDate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHome;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNotif;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPost;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel lblGreet;
        private System.Windows.Forms.Timer timerAccount;
        private System.Windows.Forms.Timer timerSidebar;
        private System.Windows.Forms.Panel panelAccount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogout;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAccount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnProfile;
        private System.Windows.Forms.FlowLayoutPanel scroll;
        private System.Windows.Forms.FlowLayoutPanel suggest;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblfu;
        private System.Windows.Forms.NotifyIcon notifHome;
    }
}