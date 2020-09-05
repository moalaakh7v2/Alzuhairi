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
            try
            {
                if (!txtName.CheckNull() && !txtPhone.CheckNull() && !txtLocation.CheckNull())
                {
                    Reseller reseller = new Reseller
                    {
                        Title = txtName.Text,
                        PhoneNumber = txtPhone.Text,
                        Location = txtLocation.Text
                    };
                    reseller = CallAPI.PostObjectAndGetObject<Reseller, Reseller>(reseller,"UpdateReseller");
                    MessageBox.Show("Added successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There Are An Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
