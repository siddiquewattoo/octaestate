namespace OctaEstate
{
    partial class AddFeaturesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFeaturesForm));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.closeBtn = new System.Windows.Forms.Button();
			this.save = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.featureDetails = new OctaEstate.OctaTextBox();
			this.featureName = new OctaEstate.OctaTextBox();
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
			this.closeBtn.Location = new System.Drawing.Point(572, 18);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(38, 43);
			this.closeBtn.TabIndex = 14;
			this.closeBtn.UseVisualStyleBackColor = false;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
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
			this.save.Location = new System.Drawing.Point(186, 385);
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
			this.save.TabIndex = 17;
			this.save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.save.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.save.TextMarginLeft = 0;
			this.save.TextPadding = new System.Windows.Forms.Padding(0);
			this.save.UseDefaultRadiusAndThickness = true;
			this.save.Click += new System.EventHandler(this.save_Click_1);
			// 
			// featureDetails
			// 
			this.featureDetails.BackColor = System.Drawing.Color.Transparent;
			this.featureDetails.Error = false;
			this.featureDetails.ErrorText = "";
			this.featureDetails.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.featureDetails.Hint = "Feature Details";
			this.featureDetails.Icon = global::OctaEstate.Properties.Resources.data_98;
			this.featureDetails.Location = new System.Drawing.Point(92, 223);
			this.featureDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.featureDetails.Name = "featureDetails";
			this.featureDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.featureDetails.PasswordChar = '\0';
			this.featureDetails.Size = new System.Drawing.Size(423, 111);
			this.featureDetails.TabIndex = 16;
			this.featureDetails.TabStop = false;
			this.featureDetails.Value = "Feature Details";
			// 
			// featureName
			// 
			this.featureName.BackColor = System.Drawing.Color.Transparent;
			this.featureName.Error = false;
			this.featureName.ErrorText = "This field is required!";
			this.featureName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.featureName.Hint = "Feature Name";
			this.featureName.Icon = global::OctaEstate.Properties.Resources.edit_308;
			this.featureName.Location = new System.Drawing.Point(92, 71);
			this.featureName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.featureName.Name = "featureName";
			this.featureName.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.featureName.PasswordChar = '\0';
			this.featureName.Size = new System.Drawing.Size(423, 111);
			this.featureName.TabIndex = 15;
			this.featureName.TabStop = false;
			this.featureName.Value = "Feature Name";
			this.featureName.ValueChanged += new OctaEstate.OctaTextBox.OnValueChanged(this.userField_ValueChanged);
			// 
			// AddFeaturesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::OctaEstate.Properties.Resources.border;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(633, 512);
			this.Controls.Add(this.save);
			this.Controls.Add(this.featureDetails);
			this.Controls.Add(this.featureName);
			this.Controls.Add(this.closeBtn);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "AddFeaturesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private OctaTextBox featureName;
        private OctaTextBox featureDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton save;
    }
}

