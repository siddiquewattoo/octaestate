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
    public partial class OctaComboBox : GroupBox
    {
        public OctaComboBox()
        {
            InitializeComponent();
            //this.BackColor = Color.Transparent;
            Error = false;
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBox.GotFocus += removePlaceHolder;
            comboBox.LostFocus += setPlaceholder;
        }


        private void OctaComboBox_Leave(object sender, EventArgs e)
        {
            line.BackgroundColor = Color.RoyalBlue;
        }

        private void OctaComboBox_Enter(object sender, EventArgs e)
        {
            line.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
        }

        public void removePlaceHolder(object sender, EventArgs e)
        {
            if (comboBox.Text == hint)
            {
                comboBox.Text = "";
                comboBox.ForeColor = Color.Black;
                this.Text = hint;
            }
        }

        public void setPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox.Text))
            {
                comboBox.Text = hint;
                comboBox.ForeColor = Color.Gray;
                this.Text = "";
            }
        }
        
        private void comboBox_TextChanged(object sender, System.EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, (sender as ComboBox).Text, e);

        }

    }
}
