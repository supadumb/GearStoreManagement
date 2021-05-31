
namespace Gear_Store
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btn_Mini = new System.Windows.Forms.Button();
            this.btn_Maxi = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.panel_Wrapper = new Bunifu.UI.WinForms.BunifuPanel();
            this.page = new Bunifu.UI.WinForms.BunifuPages();
            this.pDashboard = new System.Windows.Forms.TabPage();
            this.pProduct = new System.Windows.Forms.TabPage();
            this.pOrder = new System.Windows.Forms.TabPage();
            this.pCustomer = new System.Windows.Forms.TabPage();
            this.pEmployee = new System.Windows.Forms.TabPage();
            this.panelNavigation = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnEmployee = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCustomer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnOrder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDashBoard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panelTopBar.SuspendLayout();
            this.panel_Wrapper.SuspendLayout();
            this.page.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panelTopBar.Controls.Add(this.btn_Mini);
            this.panelTopBar.Controls.Add(this.btn_Maxi);
            this.panelTopBar.Controls.Add(this.btn_Quit);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1200, 35);
            this.panelTopBar.TabIndex = 1;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
            this.panelTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseUp);
            // 
            // btn_Mini
            // 
            this.btn_Mini.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Mini.FlatAppearance.BorderSize = 0;
            this.btn_Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mini.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mini.Image")));
            this.btn_Mini.Location = new System.Drawing.Point(1027, 0);
            this.btn_Mini.Name = "btn_Mini";
            this.btn_Mini.Size = new System.Drawing.Size(57, 35);
            this.btn_Mini.TabIndex = 4;
            this.btn_Mini.UseVisualStyleBackColor = true;
            this.btn_Mini.Click += new System.EventHandler(this.btn_Mini_Click);
            // 
            // btn_Maxi
            // 
            this.btn_Maxi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Maxi.FlatAppearance.BorderSize = 0;
            this.btn_Maxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maxi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Maxi.Image")));
            this.btn_Maxi.Location = new System.Drawing.Point(1084, 0);
            this.btn_Maxi.Name = "btn_Maxi";
            this.btn_Maxi.Size = new System.Drawing.Size(57, 35);
            this.btn_Maxi.TabIndex = 2;
            this.btn_Maxi.UseVisualStyleBackColor = true;
            this.btn_Maxi.Click += new System.EventHandler(this.btn_Maxi_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Quit.FlatAppearance.BorderSize = 0;
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Quit.Image")));
            this.btn_Quit.Location = new System.Drawing.Point(1141, 0);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(59, 35);
            this.btn_Quit.TabIndex = 1;
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // panel_Wrapper
            // 
            this.panel_Wrapper.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panel_Wrapper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Wrapper.BackgroundImage")));
            this.panel_Wrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Wrapper.BorderColor = System.Drawing.Color.Transparent;
            this.panel_Wrapper.BorderRadius = 3;
            this.panel_Wrapper.BorderThickness = 1;
            this.panel_Wrapper.Controls.Add(this.page);
            this.panel_Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Wrapper.Location = new System.Drawing.Point(0, 79);
            this.panel_Wrapper.Name = "panel_Wrapper";
            this.panel_Wrapper.ShowBorders = true;
            this.panel_Wrapper.Size = new System.Drawing.Size(1200, 621);
            this.panel_Wrapper.TabIndex = 3;
            // 
            // page
            // 
            this.page.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.page.AllowTransitions = false;
            this.page.Controls.Add(this.pDashboard);
            this.page.Controls.Add(this.pProduct);
            this.page.Controls.Add(this.pOrder);
            this.page.Controls.Add(this.pCustomer);
            this.page.Controls.Add(this.pEmployee);
            this.page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page.Location = new System.Drawing.Point(0, 0);
            this.page.Multiline = true;
            this.page.Name = "page";
            this.page.Page = this.pDashboard;
            this.page.PageIndex = 0;
            this.page.PageName = "pDashboard";
            this.page.PageTitle = "Dashboard";
            this.page.SelectedIndex = 0;
            this.page.Size = new System.Drawing.Size(1200, 621);
            this.page.TabIndex = 0;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.page.Transition = animation1;
            this.page.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            // 
            // pDashboard
            // 
            this.pDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.pDashboard.Location = new System.Drawing.Point(4, 4);
            this.pDashboard.Name = "pDashboard";
            this.pDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.pDashboard.Size = new System.Drawing.Size(1192, 595);
            this.pDashboard.TabIndex = 0;
            this.pDashboard.Text = "Dashboard";
            // 
            // pProduct
            // 
            this.pProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.pProduct.Location = new System.Drawing.Point(4, 4);
            this.pProduct.Name = "pProduct";
            this.pProduct.Padding = new System.Windows.Forms.Padding(3);
            this.pProduct.Size = new System.Drawing.Size(1192, 595);
            this.pProduct.TabIndex = 1;
            this.pProduct.Text = "Product";
            // 
            // pOrder
            // 
            this.pOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.pOrder.Location = new System.Drawing.Point(4, 4);
            this.pOrder.Name = "pOrder";
            this.pOrder.Padding = new System.Windows.Forms.Padding(3);
            this.pOrder.Size = new System.Drawing.Size(1192, 595);
            this.pOrder.TabIndex = 2;
            this.pOrder.Text = "Order";
            // 
            // pCustomer
            // 
            this.pCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.pCustomer.Location = new System.Drawing.Point(4, 4);
            this.pCustomer.Name = "pCustomer";
            this.pCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.pCustomer.Size = new System.Drawing.Size(1192, 595);
            this.pCustomer.TabIndex = 3;
            this.pCustomer.Text = "Customer";
            // 
            // pEmployee
            // 
            this.pEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.pEmployee.Location = new System.Drawing.Point(4, 4);
            this.pEmployee.Name = "pEmployee";
            this.pEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.pEmployee.Size = new System.Drawing.Size(1192, 595);
            this.pEmployee.TabIndex = 4;
            this.pEmployee.Text = "Employee";
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.panelNavigation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelNavigation.BackgroundImage")));
            this.panelNavigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNavigation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.panelNavigation.BorderRadius = 15;
            this.panelNavigation.BorderThickness = 0;
            this.panelNavigation.Controls.Add(this.bunifuSeparator1);
            this.panelNavigation.Controls.Add(this.btnEmployee);
            this.panelNavigation.Controls.Add(this.btnCustomer);
            this.panelNavigation.Controls.Add(this.btnOrder);
            this.panelNavigation.Controls.Add(this.btnProduct);
            this.panelNavigation.Controls.Add(this.btnDashBoard);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigation.Location = new System.Drawing.Point(0, 35);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.ShowBorders = true;
            this.panelNavigation.Size = new System.Drawing.Size(1200, 44);
            this.panelNavigation.TabIndex = 2;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(180, 6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 32);
            this.bunifuSeparator1.TabIndex = 0;
            // 
            // btnEmployee
            // 
            this.btnEmployee.AllowAnimations = true;
            this.btnEmployee.AllowMouseEffects = true;
            this.btnEmployee.AllowToggling = false;
            this.btnEmployee.AnimationSpeed = 200;
            this.btnEmployee.AutoGenerateColors = false;
            this.btnEmployee.AutoRoundBorders = false;
            this.btnEmployee.AutoSizeLeftIcon = true;
            this.btnEmployee.AutoSizeRightIcon = true;
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployee.BackgroundImage")));
            this.btnEmployee.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmployee.ButtonText = "Employee";
            this.btnEmployee.ButtonTextMarginLeft = 0;
            this.btnEmployee.ColorContrastOnClick = 45;
            this.btnEmployee.ColorContrastOnHover = 45;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnEmployee.CustomizableEdges = borderEdges1;
            this.btnEmployee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEmployee.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEmployee.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEmployee.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEmployee.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEmployee.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEmployee.IconMarginLeft = 11;
            this.btnEmployee.IconPadding = 10;
            this.btnEmployee.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployee.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEmployee.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEmployee.IconSize = 25;
            this.btnEmployee.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnEmployee.IdleBorderRadius = 15;
            this.btnEmployee.IdleBorderThickness = 1;
            this.btnEmployee.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnEmployee.IdleIconLeftImage = null;
            this.btnEmployee.IdleIconRightImage = null;
            this.btnEmployee.IndicateFocus = false;
            this.btnEmployee.Location = new System.Drawing.Point(533, 0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEmployee.OnDisabledState.BorderRadius = 15;
            this.btnEmployee.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmployee.OnDisabledState.BorderThickness = 1;
            this.btnEmployee.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEmployee.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEmployee.OnDisabledState.IconLeftImage = null;
            this.btnEmployee.OnDisabledState.IconRightImage = null;
            this.btnEmployee.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnEmployee.onHoverState.BorderRadius = 15;
            this.btnEmployee.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmployee.onHoverState.BorderThickness = 1;
            this.btnEmployee.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnEmployee.onHoverState.ForeColor = System.Drawing.Color.Orange;
            this.btnEmployee.onHoverState.IconLeftImage = null;
            this.btnEmployee.onHoverState.IconRightImage = null;
            this.btnEmployee.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnEmployee.OnIdleState.BorderRadius = 15;
            this.btnEmployee.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmployee.OnIdleState.BorderThickness = 1;
            this.btnEmployee.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnEmployee.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.OnIdleState.IconLeftImage = null;
            this.btnEmployee.OnIdleState.IconRightImage = null;
            this.btnEmployee.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnEmployee.OnPressedState.BorderRadius = 15;
            this.btnEmployee.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmployee.OnPressedState.BorderThickness = 1;
            this.btnEmployee.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnEmployee.OnPressedState.ForeColor = System.Drawing.Color.Orange;
            this.btnEmployee.OnPressedState.IconLeftImage = null;
            this.btnEmployee.OnPressedState.IconRightImage = null;
            this.btnEmployee.Size = new System.Drawing.Size(116, 44);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmployee.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEmployee.TextMarginLeft = 0;
            this.btnEmployee.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEmployee.UseDefaultRadiusAndThickness = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.AllowAnimations = true;
            this.btnCustomer.AllowMouseEffects = true;
            this.btnCustomer.AllowToggling = false;
            this.btnCustomer.AnimationSpeed = 200;
            this.btnCustomer.AutoGenerateColors = false;
            this.btnCustomer.AutoRoundBorders = false;
            this.btnCustomer.AutoSizeLeftIcon = true;
            this.btnCustomer.AutoSizeRightIcon = true;
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.BackgroundImage")));
            this.btnCustomer.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomer.ButtonText = "Customer";
            this.btnCustomer.ButtonTextMarginLeft = 0;
            this.btnCustomer.ColorContrastOnClick = 45;
            this.btnCustomer.ColorContrastOnHover = 45;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCustomer.CustomizableEdges = borderEdges2;
            this.btnCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCustomer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCustomer.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCustomer.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCustomer.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCustomer.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCustomer.IconMarginLeft = 11;
            this.btnCustomer.IconPadding = 10;
            this.btnCustomer.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomer.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCustomer.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCustomer.IconSize = 25;
            this.btnCustomer.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnCustomer.IdleBorderRadius = 15;
            this.btnCustomer.IdleBorderThickness = 1;
            this.btnCustomer.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnCustomer.IdleIconLeftImage = null;
            this.btnCustomer.IdleIconRightImage = null;
            this.btnCustomer.IndicateFocus = false;
            this.btnCustomer.Location = new System.Drawing.Point(414, 0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCustomer.OnDisabledState.BorderRadius = 15;
            this.btnCustomer.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomer.OnDisabledState.BorderThickness = 1;
            this.btnCustomer.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCustomer.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCustomer.OnDisabledState.IconLeftImage = null;
            this.btnCustomer.OnDisabledState.IconRightImage = null;
            this.btnCustomer.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnCustomer.onHoverState.BorderRadius = 15;
            this.btnCustomer.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomer.onHoverState.BorderThickness = 1;
            this.btnCustomer.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnCustomer.onHoverState.ForeColor = System.Drawing.Color.Orange;
            this.btnCustomer.onHoverState.IconLeftImage = null;
            this.btnCustomer.onHoverState.IconRightImage = null;
            this.btnCustomer.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnCustomer.OnIdleState.BorderRadius = 15;
            this.btnCustomer.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomer.OnIdleState.BorderThickness = 1;
            this.btnCustomer.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnCustomer.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.OnIdleState.IconLeftImage = null;
            this.btnCustomer.OnIdleState.IconRightImage = null;
            this.btnCustomer.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnCustomer.OnPressedState.BorderRadius = 15;
            this.btnCustomer.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomer.OnPressedState.BorderThickness = 1;
            this.btnCustomer.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnCustomer.OnPressedState.ForeColor = System.Drawing.Color.Orange;
            this.btnCustomer.OnPressedState.IconLeftImage = null;
            this.btnCustomer.OnPressedState.IconRightImage = null;
            this.btnCustomer.Size = new System.Drawing.Size(119, 44);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustomer.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCustomer.TextMarginLeft = 0;
            this.btnCustomer.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCustomer.UseDefaultRadiusAndThickness = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.AllowAnimations = true;
            this.btnOrder.AllowMouseEffects = true;
            this.btnOrder.AllowToggling = false;
            this.btnOrder.AnimationSpeed = 200;
            this.btnOrder.AutoGenerateColors = false;
            this.btnOrder.AutoRoundBorders = false;
            this.btnOrder.AutoSizeLeftIcon = true;
            this.btnOrder.AutoSizeRightIcon = true;
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.BackgroundImage")));
            this.btnOrder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.ButtonText = "Order";
            this.btnOrder.ButtonTextMarginLeft = 0;
            this.btnOrder.ColorContrastOnClick = 45;
            this.btnOrder.ColorContrastOnHover = 45;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnOrder.CustomizableEdges = borderEdges3;
            this.btnOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOrder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOrder.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOrder.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOrder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOrder.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnOrder.IconMarginLeft = 11;
            this.btnOrder.IconPadding = 10;
            this.btnOrder.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOrder.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnOrder.IconSize = 25;
            this.btnOrder.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnOrder.IdleBorderRadius = 15;
            this.btnOrder.IdleBorderThickness = 1;
            this.btnOrder.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnOrder.IdleIconLeftImage = null;
            this.btnOrder.IdleIconRightImage = null;
            this.btnOrder.IndicateFocus = false;
            this.btnOrder.Location = new System.Drawing.Point(307, 0);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOrder.OnDisabledState.BorderRadius = 15;
            this.btnOrder.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.OnDisabledState.BorderThickness = 1;
            this.btnOrder.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOrder.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOrder.OnDisabledState.IconLeftImage = null;
            this.btnOrder.OnDisabledState.IconRightImage = null;
            this.btnOrder.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnOrder.onHoverState.BorderRadius = 15;
            this.btnOrder.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.onHoverState.BorderThickness = 1;
            this.btnOrder.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnOrder.onHoverState.ForeColor = System.Drawing.Color.Orange;
            this.btnOrder.onHoverState.IconLeftImage = null;
            this.btnOrder.onHoverState.IconRightImage = null;
            this.btnOrder.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnOrder.OnIdleState.BorderRadius = 15;
            this.btnOrder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.OnIdleState.BorderThickness = 1;
            this.btnOrder.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnOrder.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnOrder.OnIdleState.IconLeftImage = null;
            this.btnOrder.OnIdleState.IconRightImage = null;
            this.btnOrder.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnOrder.OnPressedState.BorderRadius = 15;
            this.btnOrder.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.OnPressedState.BorderThickness = 1;
            this.btnOrder.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnOrder.OnPressedState.ForeColor = System.Drawing.Color.Orange;
            this.btnOrder.OnPressedState.IconLeftImage = null;
            this.btnOrder.OnPressedState.IconRightImage = null;
            this.btnOrder.Size = new System.Drawing.Size(107, 44);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOrder.TextMarginLeft = 0;
            this.btnOrder.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnOrder.UseDefaultRadiusAndThickness = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.AllowAnimations = true;
            this.btnProduct.AllowMouseEffects = true;
            this.btnProduct.AllowToggling = false;
            this.btnProduct.AnimationSpeed = 200;
            this.btnProduct.AutoGenerateColors = false;
            this.btnProduct.AutoRoundBorders = false;
            this.btnProduct.AutoSizeLeftIcon = true;
            this.btnProduct.AutoSizeRightIcon = true;
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProduct.BackgroundImage")));
            this.btnProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProduct.ButtonText = "Product";
            this.btnProduct.ButtonTextMarginLeft = 0;
            this.btnProduct.ColorContrastOnClick = 45;
            this.btnProduct.ColorContrastOnHover = 45;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnProduct.CustomizableEdges = borderEdges4;
            this.btnProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProduct.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProduct.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnProduct.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnProduct.IconMarginLeft = 11;
            this.btnProduct.IconPadding = 10;
            this.btnProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduct.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnProduct.IconSize = 25;
            this.btnProduct.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnProduct.IdleBorderRadius = 15;
            this.btnProduct.IdleBorderThickness = 1;
            this.btnProduct.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnProduct.IdleIconLeftImage = null;
            this.btnProduct.IdleIconRightImage = null;
            this.btnProduct.IndicateFocus = false;
            this.btnProduct.Location = new System.Drawing.Point(194, 0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProduct.OnDisabledState.BorderRadius = 15;
            this.btnProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProduct.OnDisabledState.BorderThickness = 1;
            this.btnProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProduct.OnDisabledState.IconLeftImage = null;
            this.btnProduct.OnDisabledState.IconRightImage = null;
            this.btnProduct.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnProduct.onHoverState.BorderRadius = 15;
            this.btnProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProduct.onHoverState.BorderThickness = 1;
            this.btnProduct.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnProduct.onHoverState.ForeColor = System.Drawing.Color.Orange;
            this.btnProduct.onHoverState.IconLeftImage = null;
            this.btnProduct.onHoverState.IconRightImage = null;
            this.btnProduct.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnProduct.OnIdleState.BorderRadius = 15;
            this.btnProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProduct.OnIdleState.BorderThickness = 1;
            this.btnProduct.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnProduct.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnProduct.OnIdleState.IconLeftImage = null;
            this.btnProduct.OnIdleState.IconRightImage = null;
            this.btnProduct.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnProduct.OnPressedState.BorderRadius = 15;
            this.btnProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProduct.OnPressedState.BorderThickness = 1;
            this.btnProduct.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnProduct.OnPressedState.ForeColor = System.Drawing.Color.Orange;
            this.btnProduct.OnPressedState.IconLeftImage = null;
            this.btnProduct.OnPressedState.IconRightImage = null;
            this.btnProduct.Size = new System.Drawing.Size(112, 44);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProduct.TextMarginLeft = 0;
            this.btnProduct.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnProduct.UseDefaultRadiusAndThickness = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.AllowAnimations = true;
            this.btnDashBoard.AllowMouseEffects = true;
            this.btnDashBoard.AllowToggling = false;
            this.btnDashBoard.AnimationSpeed = 200;
            this.btnDashBoard.AutoGenerateColors = false;
            this.btnDashBoard.AutoRoundBorders = false;
            this.btnDashBoard.AutoSizeLeftIcon = true;
            this.btnDashBoard.AutoSizeRightIcon = true;
            this.btnDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashBoard.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnDashBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.BackgroundImage")));
            this.btnDashBoard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashBoard.ButtonText = "      Dashboard";
            this.btnDashBoard.ButtonTextMarginLeft = 0;
            this.btnDashBoard.ColorContrastOnClick = 45;
            this.btnDashBoard.ColorContrastOnHover = 45;
            this.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnDashBoard.CustomizableEdges = borderEdges5;
            this.btnDashBoard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashBoard.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashBoard.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashBoard.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashBoard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashBoard.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDashBoard.IconMarginLeft = 11;
            this.btnDashBoard.IconPadding = 10;
            this.btnDashBoard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashBoard.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashBoard.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDashBoard.IconSize = 25;
            this.btnDashBoard.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnDashBoard.IdleBorderRadius = 15;
            this.btnDashBoard.IdleBorderThickness = 1;
            this.btnDashBoard.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnDashBoard.IdleIconLeftImage = global::Gear_Store.Properties.Resources.home_48px;
            this.btnDashBoard.IdleIconRightImage = null;
            this.btnDashBoard.IndicateFocus = false;
            this.btnDashBoard.Location = new System.Drawing.Point(19, 0);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashBoard.OnDisabledState.BorderRadius = 15;
            this.btnDashBoard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashBoard.OnDisabledState.BorderThickness = 1;
            this.btnDashBoard.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashBoard.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashBoard.OnDisabledState.IconLeftImage = null;
            this.btnDashBoard.OnDisabledState.IconRightImage = null;
            this.btnDashBoard.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnDashBoard.onHoverState.BorderRadius = 15;
            this.btnDashBoard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashBoard.onHoverState.BorderThickness = 1;
            this.btnDashBoard.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnDashBoard.onHoverState.ForeColor = System.Drawing.Color.Orange;
            this.btnDashBoard.onHoverState.IconLeftImage = null;
            this.btnDashBoard.onHoverState.IconRightImage = null;
            this.btnDashBoard.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnDashBoard.OnIdleState.BorderRadius = 15;
            this.btnDashBoard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashBoard.OnIdleState.BorderThickness = 1;
            this.btnDashBoard.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnDashBoard.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.OnIdleState.IconLeftImage = global::Gear_Store.Properties.Resources.home_48px;
            this.btnDashBoard.OnIdleState.IconRightImage = null;
            this.btnDashBoard.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnDashBoard.OnPressedState.BorderRadius = 15;
            this.btnDashBoard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashBoard.OnPressedState.BorderThickness = 1;
            this.btnDashBoard.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnDashBoard.OnPressedState.ForeColor = System.Drawing.Color.Orange;
            this.btnDashBoard.OnPressedState.IconLeftImage = null;
            this.btnDashBoard.OnPressedState.IconRightImage = null;
            this.btnDashBoard.Size = new System.Drawing.Size(156, 44);
            this.btnDashBoard.TabIndex = 0;
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashBoard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashBoard.TextMarginLeft = 0;
            this.btnDashBoard.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDashBoard.UseDefaultRadiusAndThickness = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            this.btnDashBoard.MouseHover += new System.EventHandler(this.btnDashBoard_MouseHover);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel_Wrapper);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.panelTopBar.ResumeLayout(false);
            this.panel_Wrapper.ResumeLayout(false);
            this.page.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button btn_Mini;
        private System.Windows.Forms.Button btn_Maxi;
        private System.Windows.Forms.Button btn_Quit;
        private Bunifu.UI.WinForms.BunifuPanel panelNavigation;
        private Bunifu.UI.WinForms.BunifuPanel panel_Wrapper;
        private Bunifu.UI.WinForms.BunifuPages page;
        private System.Windows.Forms.TabPage pDashboard;
        private System.Windows.Forms.TabPage pProduct;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDashBoard;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCustomer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOrder;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnProduct;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEmployee;
        private System.Windows.Forms.TabPage pOrder;
        private System.Windows.Forms.TabPage pCustomer;
        private System.Windows.Forms.TabPage pEmployee;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
    }
}

