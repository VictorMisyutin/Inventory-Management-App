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
    public partial class Admin : Form
    {
        public Admin()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateOrganization co = new CreateOrganization(1);
            co.ShowDialog();
        }
    }
}
