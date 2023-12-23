using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Management_App
{

    public partial class Register : Form
    {
        private SqlConnection cn;

        public Register()
        {
            InitializeComponent();
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\misyu\Desktop\Coding\Inventory Management App\Inventory Management App\Database.mdf"";Integrated Security=True");
            cn.Open();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox2.Text != string.Empty || PasswordBox1.Text != string.Empty || RegisterUsernameBox.Text != string.Empty)
            {
                if (PasswordBox1.Text == PasswordBox2.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from Users where username='" + RegisterUsernameBox.Text + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd.Dispose();
                        cmd = new SqlCommand("insert into Users values(@username,@password,@email,@organization)", cn);
                        cmd.Parameters.AddWithValue("username", RegisterUsernameBox.Text);
                        cmd.Parameters.AddWithValue("password", PasswordBox1.Text);
                        cmd.Parameters.AddWithValue("email", EmailBox.Text);
                        cmd.Parameters.AddWithValue("organization", OrganizationDropBox.SelectedItem == null ? "" : OrganizationDropBox.SelectedItem);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
