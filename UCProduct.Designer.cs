
namespace Gear_Store
{
    partial class UCProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProduct));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMoreDetail = new System.Windows.Forms.LinkLabel();
            this.btnBuy = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Picbox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(252, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(562, 75);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "asdaw";
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Brown;
            this.labelPrice.Location = new System.Drawing.Point(289, 161);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(162, 34);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "10000000";
            // 
            // labelMoreDetail
            // 
            this.labelMoreDetail.AutoSize = true;
            this.labelMoreDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoreDetail.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelMoreDetail.Location = new System.Drawing.Point(280, 122);
            this.labelMoreDetail.Name = "labelMoreDetail";
            this.labelMoreDetail.Size = new System.Drawing.Size(171, 21);
            this.labelMoreDetail.TabIndex = 4;
            this.labelMoreDetail.TabStop = true;
            this.labelMoreDetail.Text = "Click here for details...";
            this.labelMoreDetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelMoreDetail_LinkClicked);
            // 
            // btnBuy
            // 
            this.btnBuy.AllowAnimations = true;
            this.btnBuy.AllowMouseEffects = true;
            this.btnBuy.AllowToggling = false;
            this.btnBuy.AnimationSpeed = 200;
            this.btnBuy.AutoGenerateColors = false;
            this.btnBuy.AutoRoundBorders = false;
            this.btnBuy.AutoSizeLeftIcon = true;
            this.btnBuy.AutoSizeRightIcon = true;
            this.btnBuy.BackColor = System.Drawing.Color.Transparent;
            this.btnBuy.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(73)))), ((int)(((byte)(95)))));
            this.btnBuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuy.BackgroundImage")));
            this.btnBuy.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuy.ButtonText = "Buy Now";
            this.btnBuy.ButtonTextMarginLeft = 0;
            this.btnBuy.ColorContrastOnClick = 45;
            this.btnBuy.ColorContrastOnHover = 45;
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnBuy.CustomizableEdges = borderEdges1;
            this.btnBuy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuy.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuy.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuy.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuy.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBuy.IconMarginLeft = 11;
            this.btnBuy.IconPadding = 10;
            this.btnBuy.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuy.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuy.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBuy.IconSize = 25;
            this.btnBuy.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(73)))), ((int)(((byte)(95)))));
            this.btnBuy.IdleBorderRadius = 25;
            this.btnBuy.IdleBorderThickness = 1;
            this.btnBuy.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(73)))), ((int)(((byte)(95)))));
            this.btnBuy.IdleIconLeftImage = null;
            this.btnBuy.IdleIconRightImage = null;
            this.btnBuy.IndicateFocus = false;
            this.btnBuy.Location = new System.Drawing.Point(648, 161);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuy.OnDisabledState.BorderRadius = 25;
            this.btnBuy.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuy.OnDisabledState.BorderThickness = 1;
            this.btnBuy.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuy.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuy.OnDisabledState.IconLeftImage = null;
            this.btnBuy.OnDisabledState.IconRightImage = null;
            this.btnBuy.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnBuy.onHoverState.BorderRadius = 25;
            this.btnBuy.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuy.onHoverState.BorderThickness = 1;
            this.btnBuy.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnBuy.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBuy.onHoverState.IconLeftImage = null;
            this.btnBuy.onHoverState.IconRightImage = null;
            this.btnBuy.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(73)))), ((int)(((byte)(95)))));
            this.btnBuy.OnIdleState.BorderRadius = 25;
            this.btnBuy.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuy.OnIdleState.BorderThickness = 1;
            this.btnBuy.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(73)))), ((int)(((byte)(95)))));
            this.btnBuy.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnBuy.OnIdleState.IconLeftImage = null;
            this.btnBuy.OnIdleState.IconRightImage = null;
            this.btnBuy.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnBuy.OnPressedState.BorderRadius = 25;
            this.btnBuy.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuy.OnPressedState.BorderThickness = 1;
            this.btnBuy.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnBuy.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBuy.OnPressedState.IconLeftImage = null;
            this.btnBuy.OnPressedState.IconRightImage = null;
            this.btnBuy.Size = new System.Drawing.Size(152, 49);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuy.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuy.TextMarginLeft = 0;
            this.btnBuy.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBuy.UseDefaultRadiusAndThickness = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // Picbox
            // 
            this.Picbox.AllowFocused = false;
            this.Picbox.AutoSizeHeight = true;
            this.Picbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Picbox.BorderRadius = 0;
            this.Picbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Picbox.Image = ((System.Drawing.Image)(resources.GetObject("Picbox.Image")));
            this.Picbox.IsCircle = false;
            this.Picbox.Location = new System.Drawing.Point(0, 0);
            this.Picbox.Name = "Picbox";
            this.Picbox.Size = new System.Drawing.Size(233, 233);
            this.Picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picbox.TabIndex = 0;
            this.Picbox.TabStop = false;
            this.Picbox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Green;
            this.labelStatus.Location = new System.Drawing.Point(658, 109);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(127, 37);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "In Stock.";
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelMoreDetail);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.Picbox);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(850, 234);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox Picbox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBuy;
        private System.Windows.Forms.LinkLabel labelMoreDetail;
        private System.Windows.Forms.Label labelStatus;
    }
}
