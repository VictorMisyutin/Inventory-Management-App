using System;
using System.Collections.Generic;
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
            if (OrgaNameBox.Text != string.Empty)
            {
                List<string> orga = Scripts.GetOrganizationByName(OrgaNameBox.Text);
                if (orga.Count > 0)
                {
                    MessageBox.Show("Organization already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Scripts.CreateNewOrganization(OrgaNameBox.Text, LocationBox.Text, userId);
                    MessageBox.Show("Organization created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please enter a name for the organization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
