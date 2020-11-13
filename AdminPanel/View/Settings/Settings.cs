using AdminPanel.Classes;
using Library;
using Models;
using System;
using System.Windows.Forms;

namespace AdminPanel.View.Settings
{
    public partial class Settings : Form
    {
        Models.About about;
        public Settings()
        {
            InitializeComponent();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.CheckNull())
                    return;
                if (txtPassword.CheckNull())
                    return;
                Admin admin = new Admin
                {
                    Id = Program.admin.Id,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                };
                admin = CallAPI.PostObjectAndGetObject<Admin, Admin>(admin, "UpdateAdminInfo", "7");
                MessageBox.Show("Modified successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.admin = admin;
                txtEmail.Text = txtPassword.Text = "";

            }
            catch (Exception)
            {
                MessageBox.Show("There Are An Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
           
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            about = CallAPI.GetObjectContent<Models.About, Models.About>("GetAbout");
            txtEmailAbout.Text = about.Email;
            txtLocation.Text = about.Address;
            txtMobile.Text = about.MobileNumber;
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmailAbout.CheckNull())
                    return;
                if (txtMobile.CheckNull())
                    return;
                if (txtLocation.CheckNull())
                    return;
                about.Email = txtEmailAbout.Text;
                about.Address = txtLocation.Text;
                about.MobileNumber = txtMobile.Text;
                about = CallAPI.PostObjectAndGetObject<Models.About, Models.About>(about, "UpdateAbout");
                MessageBox.Show("Modified successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailAbout.Text = about.Email;
                txtLocation.Text = about.Address;
                txtMobile.Text = about.MobileNumber;
            }
            catch
            {
                MessageBox.Show("There Are An Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
