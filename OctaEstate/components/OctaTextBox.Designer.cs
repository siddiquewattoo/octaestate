using System.Drawing;

namespace OctaEstate
{
    partial class OctaTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OctaTextBox));
            this.line = new Bunifu.UI.WinForms.BunifuPanel();
            this.icon = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // line
            // 
            this.line.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.line.BorderColor = System.Drawing.Color.Transparent;
            this.line.BorderRadius = 3;
            this.line.BorderThickness = 1;
            this.line.Location = new System.Drawing.Point(11, 56);
            this.line.Name = "line";
            this.line.ShowBorders = true;
            this.line.Size = new System.Drawing.Size(260, 5);
            this.line.TabIndex = 0;
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(14, 30);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(25, 25);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(13, 61);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(74, 10);
            this.error.TabIndex = 1;
            this.error.Text = "This field is required!";
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Window;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox.Location = new System.Drawing.Point(45, 35);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(221, 17);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // OctaTextBox
            // 
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.error);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.line);
            this.Size = new System.Drawing.Size(282, 72);
            this.Enter += new System.EventHandler(this.OctaTextBox_Enter);
            this.Leave += new System.EventHandler(this.OctaTextBox_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel line;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label error;

        //public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private string hint;
        private char passwordChar;

        public System.Drawing.Image Icon { get => icon.Image; set => icon.Image = value; }
        public bool Error { get => error.Visible; set => error.Visible = value; }
        public string ErrorText { get => error.Text; set => error.Text = value; }
        public string Value { get => textBox.Text; set => textBox.Text = value; }
        public char PasswordChar { get => passwordChar; set { passwordChar = value; } }
        public string Hint { get => hint; set { hint = value; textBox.Text = value; textBox.ForeColor = Color.Gray; textBox.PasswordChar = '\0'; } }

        public delegate void OnValueChanged(object control, string text, System.EventArgs e);
        public event OnValueChanged ValueChanged;
    }
}
