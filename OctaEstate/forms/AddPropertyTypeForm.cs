using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;
using System.Diagnostics;

namespace OctaEstate
{
    public partial class AddPropertyTypeForm : Form
    {
        private DataAccess da;
        private IDictionary<string, dynamic> data;
        private int id;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
            );

        public AddPropertyTypeForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            da = new DataAccess("property_type", "type_code");
            data = new Dictionary<string, dynamic>();
            this.save.Click += new System.EventHandler(this.save_Click);
        }
        public AddPropertyTypeForm(int id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            da = new DataAccess("property_type", "type_code");
            data = new Dictionary<string, dynamic>();
            data = da.SearchByID(id);
            this.id = id;
            if (data["res"] == 1)
            {
                data = data["dataList"][0];
                typeDesc.Value = data["type_desc"];
                typeDesc.Text = typeDesc.Hint;
                save.Tag = data["type_code"];
                save.Text = "Update";
                save.IdleFillColor = Color.Green;
                this.save.Click += new System.EventHandler(this.update_Click);
            }
            else
            {
                MessageBox.Show(data["msg"].ToString());
                this.Close();
            };
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            data.Clear();
            data["type_desc"] = typeDesc.Value;
            data = da.Save(data);
            if (data["res"] == 1)
            {
                this.Close();
            }
            else MessageBox.Show(data["msg"].ToString());
        }

        private void update_Click(object sender, EventArgs e)
        {
            data.Clear();
            data["type_desc"] = typeDesc.Value;
            data = da.Update(data, id);
            if (data["res"] == 1)
            {
                this.Close();
            }
            else MessageBox.Show(data["msg"].ToString());
        }

        private void userField_ValueChanged(object control, string text, EventArgs e)
        {
            OctaTextBox field = control as OctaTextBox;
            if (text.Equals(field.Hint))
            {
                field.Error = true;
            }
            else
            {
                field.Error = false;
            }
        }

		private void save_Click_1(object sender, EventArgs e)
		{

		}
	}
}
