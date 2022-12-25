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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
   
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.maximize.Image = global::OctaEstate.Properties.Resources.maximize;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.maximize.Image = global::OctaEstate.Properties.Resources.minimize;
            }
           
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Add(this.dashBoardControl);
            mainPanel.Controls.Remove(this.propertiesControl);
            mainPanel.Controls.Remove(this.featuresControl);
            mainPanel.Controls.Remove(this.propertyTypesControl);
            mainPanel.Controls.Remove(this.historyControl);
        }

        private void properties_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(this.dashBoardControl);
            mainPanel.Controls.Add(this.propertiesControl);
            mainPanel.Controls.Remove(this.featuresControl);
            mainPanel.Controls.Remove(this.propertyTypesControl);
            mainPanel.Controls.Remove(this.historyControl);
        }

        private void features_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(this.dashBoardControl);
            mainPanel.Controls.Remove(this.propertiesControl);
            mainPanel.Controls.Add(this.featuresControl);
            mainPanel.Controls.Remove(this.propertyTypesControl);
            mainPanel.Controls.Remove(this.historyControl);
        }

        private void propertyTypes_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(this.dashBoardControl);
            mainPanel.Controls.Remove(this.propertiesControl);
            mainPanel.Controls.Remove(this.featuresControl);
            mainPanel.Controls.Add(this.propertyTypesControl);
            mainPanel.Controls.Remove(this.historyControl);
        }

        private void history_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(this.dashBoardControl);
            mainPanel.Controls.Remove(this.propertiesControl);
            mainPanel.Controls.Remove(this.featuresControl);
            mainPanel.Controls.Remove(this.propertyTypesControl);
            mainPanel.Controls.Add(this.historyControl);
        }
    }
}
