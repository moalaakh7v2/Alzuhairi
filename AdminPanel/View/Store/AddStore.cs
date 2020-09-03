using AdminPanel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Library;

namespace AdminPanel.View.Store
{
    public partial class AddStore : Form
    {
        public AddStore()
        {
            InitializeComponent();
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            if (!txtName.CheckNull() && !txtPhone.CheckNull() && txtLocation.CheckNull())
            {
                Models.Store store = new Models.Store
                {
                    Name = txtName.Text,
                    PhoneNumber = txtPhone.Text,
                    Location = txtLocation.Text
                };
                store = CallAPI.PostObjectAndGetObject<Models.Store, Models.Store>("AddNewStore");
                MessageBox.Show("", "");
            }
        }
    }
}
