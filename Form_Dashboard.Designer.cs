
namespace Gear_Store
{
    partial class Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges25 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges26 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges27 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges28 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.panelNavigation = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnmonth = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnyear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnall = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnday = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtrevenue = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtper_revenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtper_order = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtorder = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart_revenue = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.barchar_order = new Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(this.components);
            this.chart_order = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.doughnut_revenue = new Bunifu.Charts.WinForms.ChartTypes.BunifuDoughnutChart(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.bunifuPanel1.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.panelNavigation);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1240, 43);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.panelNavigation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelNavigation.BackgroundImage")));
            this.panelNavigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNavigation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.panelNavigation.BorderRadius = 15;
            this.panelNavigation.BorderThickness = 0;
            this.panelNavigation.Controls.Add(this.btnmonth);
            this.panelNavigation.Controls.Add(this.btnyear);
            this.panelNavigation.Controls.Add(this.btnall);
            this.panelNavigation.Controls.Add(this.btnday);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.ShowBorders = true;
            this.panelNavigation.Size = new System.Drawing.Size(1240, 43);
            this.panelNavigation.TabIndex = 3;
            // 
            // btnmonth
            // 
            this.btnmonth.AllowAnimations = true;
            this.btnmonth.AllowMouseEffects = true;
            this.btnmonth.AllowToggling = false;
            this.btnmonth.AnimationSpeed = 200;
            this.btnmonth.AutoGenerateColors = false;
            this.btnmonth.AutoRoundBorders = false;
            this.btnmonth.AutoSizeLeftIcon = true;
            this.btnmonth.AutoSizeRightIcon = true;
            this.btnmonth.BackColor = System.Drawing.Color.Transparent;
            this.btnmonth.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnmonth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmonth.BackgroundImage")));
            this.btnmonth.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnmonth.ButtonText = "Month";
            this.btnmonth.ButtonTextMarginLeft = 0;
            this.btnmonth.ColorContrastOnClick = 45;
            this.btnmonth.ColorContrastOnHover = 45;
            this.btnmonth.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges25.BottomLeft = true;
            borderEdges25.BottomRight = true;
            borderEdges25.TopLeft = true;
            borderEdges25.TopRight = true;
            this.btnmonth.CustomizableEdges = borderEdges25;
            this.btnmonth.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnmonth.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnmonth.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnmonth.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnmonth.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmonth.ForeColor = System.Drawing.Color.White;
            this.btnmonth.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmonth.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnmonth.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnmonth.IconMarginLeft = 11;
            this.btnmonth.IconPadding = 10;
            this.btnmonth.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmonth.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnmonth.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnmonth.IconSize = 25;
            this.btnmonth.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnmonth.IdleBorderRadius = 15;
            this.btnmonth.IdleBorderThickness = 1;
            this.btnmonth.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnmonth.IdleIconLeftImage = null;
            this.btnmonth.IdleIconRightImage = null;
            this.btnmonth.IndicateFocus = false;
            this.btnmonth.Location = new System.Drawing.Point(102, 0);
            this.btnmonth.Name = "btnmonth";
            this.btnmonth.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnmonth.OnDisabledState.BorderRadius = 15;
            this.btnmonth.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnmonth.OnDisabledState.BorderThickness = 1;
            this.btnmonth.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnmonth.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnmonth.OnDisabledState.IconLeftImage = null;
            this.btnmonth.OnDisabledState.IconRightImage = null;
            this.btnmonth.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnmonth.onHoverState.BorderRadius = 15;
            this.btnmonth.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnmonth.onHoverState.BorderThickness = 1;
            this.btnmonth.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnmonth.onHoverState.ForeColor = System.Drawing.Color.Orange;
            this.btnmonth.onHoverState.IconLeftImage = null;
            this.btnmonth.onHoverState.IconRightImage = null;
            this.btnmonth.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnmonth.OnIdleState.BorderRadius = 15;
            this.btnmonth.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnmonth.OnIdleState.BorderThickness = 1;
            this.btnmonth.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnmonth.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnmonth.OnIdleState.IconLeftImage = null;
            this.btnmonth.OnIdleState.IconRightImage = null;
            this.btnmonth.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnmonth.OnPressedState.BorderRadius = 15;
            this.btnmonth.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnmonth.OnPressedState.BorderThickness = 1;
            this.btnmonth.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnmonth.OnPressedState.ForeColor = System.Drawing.Color.Orange;
            this.btnmonth.OnPressedState.IconLeftImage = null;
            this.btnmonth.OnPressedState.IconRightImage = null;
            this.btnmonth.Size = new System.Drawing.Size(76, 44);
            this.btnmonth.TabIndex = 5;
            this.btnmonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnmonth.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmonth.TextMarginLeft = 0;
            this.btnmonth.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnmonth.UseDefaultRadiusAndThickness = true;
            // 
            // btnyear
            // 
            this.btnyear.AllowAnimations = true;
            this.btnyear.AllowMouseEffects = true;
            this.btnyear.AllowToggling = false;
            this.btnyear.AnimationSpeed = 200;
            this.btnyear.AutoGenerateColors = false;
            this.btnyear.AutoRoundBorders = false;
            this.btnyear.AutoSizeLeftIcon = true;
            this.btnyear.AutoSizeRightIcon = true;
            this.btnyear.BackColor = System.Drawing.Color.Transparent;
            this.btnyear.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnyear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnyear.BackgroundImage")));
            this.btnyear.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnyear.ButtonText = "Year";
            this.btnyear.ButtonTextMarginLeft = 0;
            this.btnyear.ColorContrastOnClick = 45;
            this.btnyear.ColorContrastOnHover = 45;
            this.btnyear.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges26.BottomLeft = true;
            borderEdges26.BottomRight = true;
            borderEdges26.TopLeft = true;
            borderEdges26.TopRight = true;
            this.btnyear.CustomizableEdges = borderEdges26;
            this.btnyear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnyear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnyear.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnyear.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnyear.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyear.ForeColor = System.Drawing.Color.White;
            this.btnyear.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyear.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnyear.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnyear.IconMarginLeft = 11;
            this.btnyear.IconPadding = 10;
            this.btnyear.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnyear.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnyear.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnyear.IconSize = 25;
            this.btnyear.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnyear.IdleBorderRadius = 15;
            this.btnyear.IdleBorderThickness = 1;
            this.btnyear.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnyear.IdleIconLeftImage = null;
            this.btnyear.IdleIconRightImage = null;
            this.btnyear.IndicateFocus = false;
            this.btnyear.Location = new System.Drawing.Point(184, -1);
            this.btnyear.Name = "btnyear";
            this.btnyear.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnyear.OnDisabledState.BorderRadius = 15;
            this.btnyear.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnyear.OnDisabledState.BorderThickness = 1;
            this.btnyear.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnyear.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnyear.OnDisabledState.IconLeftImage = null;
            this.btnyear.OnDisabledState.IconRightImage = null;
            this.btnyear.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnyear.onHoverState.BorderRadius = 15;
            this.btnyear.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnyear.onHoverState.BorderThickness = 1;
            this.btnyear.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnyear.onHoverState.ForeColor = System.Drawing.Color.Orange;
            this.btnyear.onHoverState.IconLeftImage = null;
            this.btnyear.onHoverState.IconRightImage = null;
            this.btnyear.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnyear.OnIdleState.BorderRadius = 15;
            this.btnyear.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnyear.OnIdleState.BorderThickness = 1;
            this.btnyear.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnyear.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnyear.OnIdleState.IconLeftImage = null;
            this.btnyear.OnIdleState.IconRightImage = null;
            this.btnyear.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnyear.OnPressedState.BorderRadius = 15;
            this.btnyear.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnyear.OnPressedState.BorderThickness = 1;
            this.btnyear.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnyear.OnPressedState.ForeColor = System.Drawing.Color.Orange;
            this.btnyear.OnPressedState.IconLeftImage = null;
            this.btnyear.OnPressedState.IconRightImage = null;
            this.btnyear.Size = new System.Drawing.Size(84, 44);
            this.btnyear.TabIndex = 4;
            this.btnyear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnyear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnyear.TextMarginLeft = 0;
            this.btnyear.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnyear.UseDefaultRadiusAndThickness = true;
            // 
            // btnall
            // 
            this.btnall.AllowAnimations = true;
            this.btnall.AllowMouseEffects = true;
            this.btnall.AllowToggling = false;
            this.btnall.AnimationSpeed = 200;
            this.btnall.AutoGenerateColors = false;
            this.btnall.AutoRoundBorders = false;
            this.btnall.AutoSizeLeftIcon = true;
            this.btnall.AutoSizeRightIcon = true;
            this.btnall.BackColor = System.Drawing.Color.Transparent;
            this.btnall.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnall.BackgroundImage")));
            this.btnall.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnall.ButtonText = "All";
            this.btnall.ButtonTextMarginLeft = 0;
            this.btnall.ColorContrastOnClick = 45;
            this.btnall.ColorContrastOnHover = 45;
            this.btnall.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges27.BottomLeft = true;
            borderEdges27.BottomRight = true;
            borderEdges27.TopLeft = true;
            borderEdges27.TopRight = true;
            this.btnall.CustomizableEdges = borderEdges27;
            this.btnall.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnall.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnall.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnall.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnall.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnall.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnall.ForeColor = System.Drawing.Color.White;
            this.btnall.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnall.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnall.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnall.IconMarginLeft = 11;
            this.btnall.IconPadding = 10;
            this.btnall.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnall.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnall.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnall.IconSize = 25;
            this.btnall.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnall.IdleBorderRadius = 15;
            this.btnall.IdleBorderThickness = 1;
            this.btnall.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnall.IdleIconLeftImage = null;
            this.btnall.IdleIconRightImage = null;
            this.btnall.IndicateFocus = false;
            this.btnall.Location = new System.Drawing.Point(274, -1);
            this.btnall.Name = "btnall";
            this.btnall.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnall.OnDisabledState.BorderRadius = 15;
            this.btnall.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnall.OnDisabledState.BorderThickness = 1;
            this.btnall.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnall.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnall.OnDisabledState.IconLeftImage = null;
            this.btnall.OnDisabledState.IconRightImage = null;
            this.btnall.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnall.onHoverState.BorderRadius = 15;
            this.btnall.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnall.onHoverState.BorderThickness = 1;
            this.btnall.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnall.onHoverState.ForeColor = System.Drawing.Color.Orange;
            this.btnall.onHoverState.IconLeftImage = null;
            this.btnall.onHoverState.IconRightImage = null;
            this.btnall.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnall.OnIdleState.BorderRadius = 15;
            this.btnall.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnall.OnIdleState.BorderThickness = 1;
            this.btnall.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnall.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnall.OnIdleState.IconLeftImage = null;
            this.btnall.OnIdleState.IconRightImage = null;
            this.btnall.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnall.OnPressedState.BorderRadius = 15;
            this.btnall.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnall.OnPressedState.BorderThickness = 1;
            this.btnall.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnall.OnPressedState.ForeColor = System.Drawing.Color.Orange;
            this.btnall.OnPressedState.IconLeftImage = null;
            this.btnall.OnPressedState.IconRightImage = null;
            this.btnall.Size = new System.Drawing.Size(78, 44);
            this.btnall.TabIndex = 3;
            this.btnall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnall.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnall.TextMarginLeft = 0;
            this.btnall.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnall.UseDefaultRadiusAndThickness = true;
            // 
            // btnday
            // 
            this.btnday.AllowAnimations = true;
            this.btnday.AllowMouseEffects = true;
            this.btnday.AllowToggling = false;
            this.btnday.AnimationSpeed = 200;
            this.btnday.AutoGenerateColors = false;
            this.btnday.AutoRoundBorders = false;
            this.btnday.AutoSizeLeftIcon = true;
            this.btnday.AutoSizeRightIcon = true;
            this.btnday.BackColor = System.Drawing.Color.Transparent;
            this.btnday.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnday.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnday.BackgroundImage")));
            this.btnday.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnday.ButtonText = "Day";
            this.btnday.ButtonTextMarginLeft = 0;
            this.btnday.ColorContrastOnClick = 45;
            this.btnday.ColorContrastOnHover = 45;
            this.btnday.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges28.BottomLeft = true;
            borderEdges28.BottomRight = true;
            borderEdges28.TopLeft = true;
            borderEdges28.TopRight = true;
            this.btnday.CustomizableEdges = borderEdges28;
            this.btnday.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnday.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnday.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnday.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnday.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnday.ForeColor = System.Drawing.Color.White;
            this.btnday.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnday.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnday.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnday.IconMarginLeft = 11;
            this.btnday.IconPadding = 10;
            this.btnday.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnday.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnday.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnday.IconSize = 25;
            this.btnday.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnday.IdleBorderRadius = 15;
            this.btnday.IdleBorderThickness = 1;
            this.btnday.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnday.IdleIconLeftImage = null;
            this.btnday.IdleIconRightImage = null;
            this.btnday.IndicateFocus = false;
            this.btnday.Location = new System.Drawing.Point(20, 0);
            this.btnday.Name = "btnday";
            this.btnday.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnday.OnDisabledState.BorderRadius = 15;
            this.btnday.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnday.OnDisabledState.BorderThickness = 1;
            this.btnday.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnday.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnday.OnDisabledState.IconLeftImage = null;
            this.btnday.OnDisabledState.IconRightImage = null;
            this.btnday.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnday.onHoverState.BorderRadius = 15;
            this.btnday.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnday.onHoverState.BorderThickness = 1;
            this.btnday.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnday.onHoverState.ForeColor = System.Drawing.Color.Orange;
            this.btnday.onHoverState.IconLeftImage = null;
            this.btnday.onHoverState.IconRightImage = null;
            this.btnday.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnday.OnIdleState.BorderRadius = 15;
            this.btnday.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnday.OnIdleState.BorderThickness = 1;
            this.btnday.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnday.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnday.OnIdleState.IconLeftImage = null;
            this.btnday.OnIdleState.IconRightImage = null;
            this.btnday.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnday.OnPressedState.BorderRadius = 15;
            this.btnday.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnday.OnPressedState.BorderThickness = 1;
            this.btnday.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.btnday.OnPressedState.ForeColor = System.Drawing.Color.Orange;
            this.btnday.OnPressedState.IconLeftImage = null;
            this.btnday.OnPressedState.IconRightImage = null;
            this.btnday.Size = new System.Drawing.Size(76, 44);
            this.btnday.TabIndex = 2;
            this.btnday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnday.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnday.TextMarginLeft = 0;
            this.btnday.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnday.UseDefaultRadiusAndThickness = true;
            // 
            // txtrevenue
            // 
            this.txtrevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrevenue.AutoSize = true;
            this.txtrevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.txtrevenue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrevenue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtrevenue.Location = new System.Drawing.Point(51, 9);
            this.txtrevenue.Name = "txtrevenue";
            this.txtrevenue.Size = new System.Drawing.Size(104, 37);
            this.txtrevenue.TabIndex = 0;
            this.txtrevenue.Text = "$2,000";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.txtper_revenue);
            this.bunifuPanel2.Controls.Add(this.label3);
            this.bunifuPanel2.Controls.Add(this.label2);
            this.bunifuPanel2.Controls.Add(this.txtrevenue);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(3, 3);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(601, 88);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // txtper_revenue
            // 
            this.txtper_revenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtper_revenue.AutoSize = true;
            this.txtper_revenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.txtper_revenue.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtper_revenue.ForeColor = System.Drawing.Color.Orange;
            this.txtper_revenue.Location = new System.Drawing.Point(280, 16);
            this.txtper_revenue.Name = "txtper_revenue";
            this.txtper_revenue.Size = new System.Drawing.Size(51, 28);
            this.txtper_revenue.TabIndex = 3;
            this.txtper_revenue.Text = "30%";
            this.txtper_revenue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(234, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "🚀";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(54, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Revenue";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.txtper_order);
            this.bunifuPanel3.Controls.Add(this.label6);
            this.bunifuPanel3.Controls.Add(this.label7);
            this.bunifuPanel3.Controls.Add(this.txtorder);
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel3.Location = new System.Drawing.Point(610, 3);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(599, 88);
            this.bunifuPanel3.TabIndex = 4;
            // 
            // txtper_order
            // 
            this.txtper_order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtper_order.AutoSize = true;
            this.txtper_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.txtper_order.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtper_order.ForeColor = System.Drawing.Color.Orange;
            this.txtper_order.Location = new System.Drawing.Point(249, 20);
            this.txtper_order.Name = "txtper_order";
            this.txtper_order.Size = new System.Drawing.Size(51, 28);
            this.txtper_order.TabIndex = 3;
            this.txtper_order.Text = "30%";
            this.txtper_order.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(203, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "🚀";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(51, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Order";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtorder
            // 
            this.txtorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtorder.AutoSize = true;
            this.txtorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.txtorder.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtorder.Location = new System.Drawing.Point(47, 10);
            this.txtorder.Name = "txtorder";
            this.txtorder.Size = new System.Drawing.Size(60, 46);
            this.txtorder.TabIndex = 0;
            this.txtorder.Text = "57";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.14204F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.85796F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bunifuPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1212, 94);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // chart_revenue
            // 
            this.chart_revenue.AnimationDuration = 1000;
            this.chart_revenue.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.chart_revenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.chart_revenue.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.chart_revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_revenue.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.chart_revenue.Labels = new string[] {
        "Sun",
        "Mon",
        "Tue",
        "Wed",
        "Thu",
        "Fri",
        "Sat"};
            this.chart_revenue.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.chart_revenue.LegendDisplay = true;
            this.chart_revenue.LegendFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_revenue.LegendForeColor = System.Drawing.Color.DarkGray;
            this.chart_revenue.LegendFullWidth = true;
            this.chart_revenue.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.chart_revenue.LegendRevese = false;
            this.chart_revenue.LegendRTL = false;
            this.chart_revenue.Location = new System.Drawing.Point(4, 200);
            this.chart_revenue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart_revenue.Name = "chart_revenue";
            this.chart_revenue.ShowXAxis = true;
            this.chart_revenue.ShowYAxis = true;
            this.chart_revenue.Size = new System.Drawing.Size(598, 320);
            this.chart_revenue.TabIndex = 7;
            this.chart_revenue.Title = "";
            this.chart_revenue.TitleLineHeight = 1.2D;
            this.chart_revenue.TitlePadding = 10;
            this.chart_revenue.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.chart_revenue.TooltipBackgroundColor = System.Drawing.Color.Black;
            this.chart_revenue.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_revenue.TooltipForeColor = System.Drawing.Color.Gray;
            this.chart_revenue.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.chart_revenue.TooltipsEnabled = true;
            this.chart_revenue.XAxesBeginAtZero = true;
            this.chart_revenue.XAxesDrawTicks = true;
            this.chart_revenue.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chart_revenue.XAxesForeColor = System.Drawing.SystemColors.ControlDark;
            this.chart_revenue.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart_revenue.XAxesGridLines = true;
            this.chart_revenue.XAxesLabel = "";
            this.chart_revenue.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chart_revenue.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.chart_revenue.XAxesLineWidth = 1;
            this.chart_revenue.XAxesStacked = false;
            this.chart_revenue.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart_revenue.XAxesZeroLineWidth = 1;
            this.chart_revenue.YAxesBeginAtZero = true;
            this.chart_revenue.YAxesDrawTicks = true;
            this.chart_revenue.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chart_revenue.YAxesForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.chart_revenue.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart_revenue.YAxesGridLines = true;
            this.chart_revenue.YAxesLabel = "";
            this.chart_revenue.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chart_revenue.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.chart_revenue.YAxesLineWidth = 1;
            this.chart_revenue.YAxesStacked = false;
            this.chart_revenue.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart_revenue.YAxesZeroLineWidth = 1;
            // 
            // barchar_order
            // 
            this.barchar_order.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("barchar_order.BackgroundColor")));
            this.barchar_order.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("barchar_order.BorderColor")));
            this.barchar_order.BorderSkipped = null;
            this.barchar_order.BorderWidth = 0;
            this.barchar_order.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("barchar_order.Data")));
            this.barchar_order.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.barchar_order.HoverBorderColor = System.Drawing.Color.Empty;
            this.barchar_order.HoverBorderWidth = 0;
            this.barchar_order.Label = "Order";
            this.barchar_order.TargetCanvas = this.chart_order;
            // 
            // chart_order
            // 
            this.chart_order.AnimationDuration = 1000;
            this.chart_order.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.chart_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.chart_order.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.chart_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_order.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.chart_order.Labels = new string[] {
        "Sun",
        "Mon",
        "Tue",
        "Wed",
        "Thu",
        "Fri",
        "Sat"};
            this.chart_order.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.chart_order.LegendDisplay = true;
            this.chart_order.LegendFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_order.LegendForeColor = System.Drawing.Color.DarkGray;
            this.chart_order.LegendFullWidth = true;
            this.chart_order.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.chart_order.LegendRevese = false;
            this.chart_order.LegendRTL = false;
            this.chart_order.Location = new System.Drawing.Point(610, 200);
            this.chart_order.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart_order.Name = "chart_order";
            this.chart_order.ShowXAxis = true;
            this.chart_order.ShowYAxis = true;
            this.chart_order.Size = new System.Drawing.Size(599, 331);
            this.chart_order.TabIndex = 8;
            this.chart_order.Title = "";
            this.chart_order.TitleLineHeight = 1.2D;
            this.chart_order.TitlePadding = 10;
            this.chart_order.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.chart_order.TooltipBackgroundColor = System.Drawing.Color.Black;
            this.chart_order.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chart_order.TooltipForeColor = System.Drawing.Color.Gray;
            this.chart_order.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.chart_order.TooltipsEnabled = true;
            this.chart_order.XAxesBeginAtZero = true;
            this.chart_order.XAxesDrawTicks = true;
            this.chart_order.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chart_order.XAxesForeColor = System.Drawing.SystemColors.ControlDark;
            this.chart_order.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart_order.XAxesGridLines = true;
            this.chart_order.XAxesLabel = "";
            this.chart_order.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chart_order.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.chart_order.XAxesLineWidth = 1;
            this.chart_order.XAxesStacked = false;
            this.chart_order.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart_order.XAxesZeroLineWidth = 1;
            this.chart_order.YAxesBeginAtZero = true;
            this.chart_order.YAxesDrawTicks = true;
            this.chart_order.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chart_order.YAxesForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.chart_order.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart_order.YAxesGridLines = true;
            this.chart_order.YAxesLabel = "";
            this.chart_order.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chart_order.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.chart_order.YAxesLineWidth = 1;
            this.chart_order.YAxesStacked = false;
            this.chart_order.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart_order.YAxesZeroLineWidth = 1;
            // 
            // doughnut_revenue
            // 
            this.doughnut_revenue.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("doughnut_revenue.BackgroundColor")));
            this.doughnut_revenue.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("doughnut_revenue.BorderColor")));
            this.doughnut_revenue.BorderWidth = 0;
            this.doughnut_revenue.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("doughnut_revenue.Data")));
            this.doughnut_revenue.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.doughnut_revenue.HoverBorderColor = System.Drawing.Color.Empty;
            this.doughnut_revenue.HoverBorderWidth = 0;
            this.doughnut_revenue.Label = "R";
            this.doughnut_revenue.TargetCanvas = this.chart_revenue;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(261, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Revenue";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 400);
            this.panel1.TabIndex = 10;
            // 
            // dgv
            // 
            this.dgv.AllowCustomTheming = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv.ColumnHeadersHeight = 40;
            this.dgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv.CurrentTheme.Name = null;
            this.dgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv.HeaderForeColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(0, 46);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 40;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1169, 354);
            this.dgv.TabIndex = 11;
            this.dgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(4, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Order History:";
            // 
            // bunifuVScrollBar1
            // 
            this.bunifuVScrollBar1.AllowCursorChanges = true;
            this.bunifuVScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar1.AllowMouseDownEffects = true;
            this.bunifuVScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar1.AllowScrollingAnimations = true;
            this.bunifuVScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar1.AutoScroll = true;
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = this;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.bunifuVScrollBar1.BorderRadius = 14;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(1216, 54);
            this.bunifuVScrollBar1.Maximum = 100;
            this.bunifuVScrollBar1.Minimum = 0;
            this.bunifuVScrollBar1.MinimumThumbLength = 18;
            this.bunifuVScrollBar1.Name = "bunifuVScrollBar1";
            this.bunifuVScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.bunifuVScrollBar1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.bunifuVScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(19, 537);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 11;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.bunifuVScrollBar1.ThumbLength = 52;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1240, 687);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_order);
            this.Controls.Add(this.chart_revenue);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dashboard";
            this.Text = "Form_Dashboard";
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel panelNavigation;
        private System.Windows.Forms.Label txtrevenue;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Label txtper_revenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private System.Windows.Forms.Label txtper_order;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtorder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart barchar_order;
        private Bunifu.Charts.WinForms.BunifuChartCanvas chart_revenue;
        private Bunifu.Charts.WinForms.BunifuChartCanvas chart_order;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuDoughnutChart doughnut_revenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnday;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnmonth;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnyear;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnall;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
    }
}