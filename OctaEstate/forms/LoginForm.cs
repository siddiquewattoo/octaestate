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
    public partial class LoginForm : Form
    {
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
        SqlConnection con = new SqlConnection();
        public LoginForm()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=yourpcnamehere\\servernamehere;Initial Catalog=POSdb;Integrated Security=True";
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=yourpcnamehere\\servernamehere;Initial Catalog=POSdb;Integrated Security=True");
            //con.Open();

            {
            }
/*            var materialTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
*/        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void loginButton_MouseHover(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.Transparent;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userField.Value.Equals(userField.Hint))
            {
                userField.Error = true;
                
            }
            if (pwdField.Value.Equals(pwdField.Hint))
            {
                pwdField.Error = true;
            }
            if (userField.Value == "admin" && pwdField.Value == "root")
            {
                this.Hide();
                new DashboardForm().ShowDialog();
            } MessageBox.Show("Invalid Username or Password!");
        }

        private void userField_ValueChanged(object control, string text, EventArgs e)
        {
            OctaTextBox field = control as OctaTextBox;
            if (text.Equals(field.Hint))
            {
                field.Error = true;
            } else {
                field.Error = false;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
