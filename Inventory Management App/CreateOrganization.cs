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
    public partial class CreateOrganization : Form
    {
        private SqlConnection cn;
        private int userId;
        public CreateOrganization(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private void CreateOrganizationButton_Click(object sender, EventArgs e)
        {
            if (OrgoNameBox.Text != string.Empty)
            {
                SqlCommand cmd;
                cmd = new SqlCommand("insert into Organizations (name, location, ownerId) values(@name,@location,@ownerId)", cn);
                cmd.Parameters.AddWithValue("name", OrgoNameBox.Text);
                cmd.Parameters.AddWithValue("location", LocationBox.Text == string.Empty ? "" : LocationBox.Text);
                cmd.Parameters.AddWithValue("ownerId", userId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Organization created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter a name for the organization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateOrganization_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\misyu\Desktop\Coding\Inventory Management App\Inventory Management App\Database.mdf"";Integrated Security=True");
            cn.Open();
        }
    }
}
