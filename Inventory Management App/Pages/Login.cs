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

namespace Inventory_Management_App
{
    public partial class Login : Form
    {
        private SqlConnection cn;
        public Login()
        {
            InitializeComponent();
        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\misyu\Desktop\Coding\Inventory Management App\Inventory Management App\Database.mdf"";Integrated Security=True");
            cn.Open();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(PasswordBox.Text != string.Empty || UsernameBox.Text != string.Empty)
            {

                SqlCommand cmd = new SqlCommand("select * from Users where username='" + UsernameBox.Text + "' and password='" + PasswordBox.Text + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int logUserId = (int)dr["Id"];
                    dr.Close();
                    this.Hide();
                    if (logUserId == 1)
                    {
                        Admin admin = new Admin();
                        admin.ShowDialog();
                    }
                    else
                    {
                        Main main = new Main(logUserId);
                        main.ShowDialog();
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No account with those credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
