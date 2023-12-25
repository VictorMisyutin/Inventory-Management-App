using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory_Management_App
{

    public partial class Register : Form
    {
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
            List<string> names = Scripts.GetAllOrganizationNames();
            foreach(string name in names)
            {
                OrganizationDropBox.Items.Add(name);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox2.Text != string.Empty || PasswordBox1.Text != string.Empty || RegisterUsernameBox.Text != string.Empty)
            {
                if (PasswordBox1.Text == PasswordBox2.Text)
                {
                    if (EmailBox.Text != RepeatEmailBox.Text)
                    {
                        MessageBox.Show("Emails do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (OrganizationDropBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please select an organization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    List<string> user = Scripts.GetUserByUserName(RegisterUsernameBox.Text);
                    if (user.Count > 0)
                    {
                        MessageBox.Show("Username already exist please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        List<string> organization = Scripts.GetOrganizationByName(OrganizationDropBox.SelectedItem.ToString());
                        int orgaId = Int32.Parse(organization[0]);
                        Scripts.CreateNewUser(RegisterUsernameBox.Text, PasswordBox1.Text, EmailBox.Text, FirstNameBox.Text, LastNameBox.Text, orgaId);
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
