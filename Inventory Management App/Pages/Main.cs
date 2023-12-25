using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory_Management_App
{
    public partial class Main : Form
    {
        private int userId;
        public Main(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<string> user = Scripts.GetUserById(userId);
            NameLabel.Text = user[4] + " " + user[5];
            List<string> orga = Scripts.GetOrganizationById(Int32.Parse(user[6]));
            OrganizationLabel.Text = orga[1];
        }

    }
}
