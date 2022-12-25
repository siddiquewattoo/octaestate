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


namespace OctaEstate
{
    public partial class AddPropertiesForm : Form
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
        public AddPropertiesForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            da = new DataAccess("properties", "p_id");
            data = new Dictionary<string, dynamic>();
            //this.save.Click += new System.EventHandler(this.save_Click);
        }

        public AddPropertiesForm(int id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            da = new DataAccess("properties", "p_id");
            data = new Dictionary<string, dynamic>();
            data = da.SearchByID(id);
            this.id = id;
            if (data["res"] == 1)
            {
                //data = data["dataList"][0];
                //featureName.Value = data["feature_name"];
                //featureName.Text = featureName.Hint;
                //featureDetails.Value = data["feature_details"];
                //featureDetails.Text = featureDetails.Hint;
                //save.Tag = data["id"];
                //save.Text = "Update";
                //save.IdleFillColor = Color.Green;
                //this.save.Click += new System.EventHandler(this.update_Click);
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

        private void AddPropertiesForm_Load(object sender, EventArgs e)
        {
            da = new DataAccess("property_type", "type_code");

            //prFeatures.ComboBox.DataSource = ;
            da = new DataAccess("", "");
        }

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void prType_Enter(object sender, EventArgs e)
		{

		}

		private void save_Click(object sender, EventArgs e)
		{


		}
	}
}
