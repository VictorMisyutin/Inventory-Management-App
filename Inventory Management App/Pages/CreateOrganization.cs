using System;
using System.Windows.Forms;

namespace Inventory_Management_App
{
    public partial class CreateOrganization : Form
    {
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
                // put here
                Scripts.CreateNewOrganization(OrgoNameBox.Text, LocationBox.Text, userId);
                MessageBox.Show("Organization created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter a name for the organization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
