using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ROMANO\SQLEXPRESS;Initial Catalog=loginTest;Integrated Security=True;Encrypt=False;");

        private void exitReg_Click(object sender, EventArgs e)
        {
            loginFrm loginFrm = new loginFrm();
            loginFrm.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (pswd.Text == pswdConfirm.Text)
                {
                    String querry = "INSERT INTO login VALUES ('" + usrName.Text + "', '" + pswd.Text + "', '" + frstName.Text + "', '" + lstName.Text + "', '" + email.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                }
                else
                {
                    MessageBox.Show("Your Passwords does not match!");
                }
            }
            catch 
            {
                
            }
            finally 
            {
                loginFrm loginFrm = new loginFrm();
                loginFrm.Show();
                this.Hide();

                conn.Close();
            }
        }
    }
}
