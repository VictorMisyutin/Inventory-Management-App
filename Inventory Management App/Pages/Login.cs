using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory_Management_App
{
    public partial class Login : Form
    {
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
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(PasswordBox.Text != string.Empty || UsernameBox.Text != string.Empty)
            {

                List<string> user = Scripts.GetUserByUsernameAndPassword(UsernameBox.Text, PasswordBox.Text);

                if (user.Count > 0)
                {
                    int logUserId = Int32.Parse(user[0]);
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
