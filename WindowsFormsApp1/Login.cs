using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class loginFrm : Form
    {
        public loginFrm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ROMANO\SQLEXPRESS;Initial Catalog=loginTest;Integrated Security=True;Encrypt=False;");

        private void loginFrm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                String querry = "SELECT * FROM login WHERE username = '"+usrnameField.Text+"' AND password = '"+pswdField.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login, Try agian!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usrnameField.Clear();
                    pswdField.Clear();

                    usrnameField.Focus();
                }
            }
            catch 
            {
                MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                conn.Close();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
