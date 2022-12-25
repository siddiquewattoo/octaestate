namespace OctaEstate
{
    partial class AddPropertiesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPropertiesForm));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.closeBtn = new System.Windows.Forms.Button();
			this.prType = new OctaEstate.OctaComboBox();
			this.prFeatures = new OctaEstate.OctaComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.octaComboBox1 = new OctaEstate.OctaComboBox();
			this.save = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// closeBtn
			// 
			this.closeBtn.BackColor = System.Drawing.Color.Transparent;
			this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.ForeColor = System.Drawing.Color.Transparent;
			this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
			this.closeBtn.Location = new System.Drawing.Point(1076, 18);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(38, 43);
			this.closeBtn.TabIndex = 14;
			this.closeBtn.UseVisualStyleBackColor = false;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// prType
			// 
			this.prType.Error = false;
			this.prType.ErrorText = "This field is required!";
			this.prType.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prType.Hint = "Property Type";
			this.prType.Icon = null;
			this.prType.Location = new System.Drawing.Point(40, 29);
			this.prType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.prType.Name = "prType";
			this.prType.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.prType.Size = new System.Drawing.Size(424, 112);
			this.prType.TabIndex = 15;
			this.prType.TabStop = false;
			this.prType.Value = "Property Type";
			this.prType.Enter += new System.EventHandler(this.prType_Enter);
			// 
			// prFeatures
			// 
			this.prFeatures.Error = false;
			this.prFeatures.ErrorText = "This field is required!";
			this.prFeatures.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prFeatures.Hint = "Property Feature";
			this.prFeatures.Icon = null;
			this.prFeatures.Location = new System.Drawing.Point(531, 29);
			this.prFeatures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.prFeatures.Name = "prFeatures";
			this.prFeatures.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.prFeatures.Size = new System.Drawing.Size(424, 112);
			this.prFeatures.TabIndex = 16;
			this.prFeatures.TabStop = false;
			this.prFeatures.Value = "Property Feature";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.save);
			this.groupBox1.Controls.Add(this.octaComboBox1);
			this.groupBox1.Controls.Add(this.prType);
			this.groupBox1.Controls.Add(this.prFeatures);
			this.groupBox1.Location = new System.Drawing.Point(58, 57);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(998, 591);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Property Size";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// octaComboBox1
			// 
			this.octaComboBox1.Error = false;
			this.octaComboBox1.ErrorText = "This field is required!";
			this.octaComboBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.octaComboBox1.Hint = "Property Size";
			this.octaComboBox1.Icon = null;
			this.octaComboBox1.Location = new System.Drawing.Point(285, 160);
			this.octaComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.octaComboBox1.Name = "octaComboBox1";
			this.octaComboBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.octaComboBox1.Size = new System.Drawing.Size(410, 96);
			this.octaComboBox1.TabIndex = 21;
			this.octaComboBox1.TabStop = false;
			this.octaComboBox1.Value = "Property Size";
			// 
			// save
			// 
			this.save.AllowAnimations = true;
			this.save.AllowMouseEffects = true;
			this.save.AllowToggling = false;
			this.save.AnimationSpeed = 200;
			this.save.AutoGenerateColors = false;
			this.save.AutoRoundBorders = false;
			this.save.AutoSizeLeftIcon = true;
			this.save.AutoSizeRightIcon = true;
			this.save.BackColor = System.Drawing.Color.Transparent;
			this.save.BackColor1 = System.Drawing.Color.DodgerBlue;
			this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
			this.save.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.save.ButtonText = "Save";
			this.save.ButtonTextMarginLeft = 0;
			this.save.ColorContrastOnClick = 45;
			this.save.ColorContrastOnHover = 45;
			this.save.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.save.CustomizableEdges = borderEdges1;
			this.save.DialogResult = System.Windows.Forms.DialogResult.None;
			this.save.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.save.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.save.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.save.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.save.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.save.ForeColor = System.Drawing.Color.White;
			this.save.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.save.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.save.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.save.IconMarginLeft = 11;
			this.save.IconPadding = 10;
			this.save.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.save.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.save.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.save.IconSize = 25;
			this.save.IdleBorderColor = System.Drawing.Color.Transparent;
			this.save.IdleBorderRadius = 1;
			this.save.IdleBorderThickness = 1;
			this.save.IdleFillColor = System.Drawing.Color.DodgerBlue;
			this.save.IdleIconLeftImage = null;
			this.save.IdleIconRightImage = null;
			this.save.IndicateFocus = false;
			this.save.Location = new System.Drawing.Point(374, 375);
			this.save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.save.Name = "save";
			this.save.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.save.OnDisabledState.BorderRadius = 1;
			this.save.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.save.OnDisabledState.BorderThickness = 1;
			this.save.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.save.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.save.OnDisabledState.IconLeftImage = null;
			this.save.OnDisabledState.IconRightImage = null;
			this.save.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.save.onHoverState.BorderRadius = 1;
			this.save.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.save.onHoverState.BorderThickness = 1;
			this.save.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.save.onHoverState.ForeColor = System.Drawing.Color.White;
			this.save.onHoverState.IconLeftImage = null;
			this.save.onHoverState.IconRightImage = null;
			this.save.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
			this.save.OnIdleState.BorderRadius = 1;
			this.save.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.save.OnIdleState.BorderThickness = 1;
			this.save.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
			this.save.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.save.OnIdleState.IconLeftImage = null;
			this.save.OnIdleState.IconRightImage = null;
			this.save.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.save.OnPressedState.BorderRadius = 1;
			this.save.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.save.OnPressedState.BorderThickness = 1;
			this.save.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.save.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.save.OnPressedState.IconLeftImage = null;
			this.save.OnPressedState.IconRightImage = null;
			this.save.Size = new System.Drawing.Size(225, 60);
			this.save.TabIndex = 23;
			this.save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.save.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.save.TextMarginLeft = 0;
			this.save.TextPadding = new System.Windows.Forms.Padding(0);
			this.save.UseDefaultRadiusAndThickness = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// AddPropertiesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::OctaEstate.Properties.Resources.border;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1140, 775);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.closeBtn);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "AddPropertiesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.AddPropertiesForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private OctaComboBox prType;
        private OctaComboBox prFeatures;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton save;
		private OctaComboBox octaComboBox1;
	}
}

