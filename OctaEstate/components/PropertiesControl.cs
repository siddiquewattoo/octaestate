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
    public partial class PropertiesControl : Control
    {
        private DataAccess da;
        private IDictionary<string, dynamic> data;
        public PropertiesControl()
        {
            InitializeComponent();
            da = new DataAccess("properties", "p_id");
            data = new Dictionary<string, dynamic>();
            LoadGridView();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            AddPropertiesForm form = new AddPropertiesForm();
            form.ShowDialog();
            LoadGridView();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            AddPropertiesForm form = new AddPropertiesForm(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
            form.ShowDialog();
            LoadGridView();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteForm form = new DeleteForm(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()), da);
            form.ShowDialog();
            LoadGridView();
        }

        public void LoadGridView()
        {
            data = da.loadTable();
            if (data["res"] == 1)
            {
                dataGridView1.DataSource = data["dataTable"];
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void soldBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
