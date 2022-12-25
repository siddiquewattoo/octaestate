using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OctaEstate
{
    public partial class OctaTextBox : GroupBox
    {
        public OctaTextBox()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            Error = false;
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.GotFocus += removePlaceHolder;
            textBox.LostFocus += setPlaceholder;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void OctaTextBox_Leave(object sender, EventArgs e)
        {
            line.BackgroundColor = Color.RoyalBlue;
        }

        private void OctaTextBox_Enter(object sender, EventArgs e)
        {
            line.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
        }

      


        public void removePlaceHolder(object sender, EventArgs e)
        {
            if (textBox.Text == hint)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                textBox.PasswordChar = passwordChar;
                this.Text = hint;
            }
        }

        public void setPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = hint;
                textBox.ForeColor = Color.Gray;
                textBox.PasswordChar = '\0';
                this.Text = "";
            }
        }
        
        private void textBox_TextChanged(object sender, System.EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, (sender as TextBox).Text, e);

        }

    }
}
