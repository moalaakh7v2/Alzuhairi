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
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Token = Guid.NewGuid()
                };
                admin = CallAPI.PostObjectAndGetObject<Admin, Admin>(admin, "UpdateAdminInfo", Program.admin.Token.ToString());
                if (admin.Id != 0)
                {
                    MessageBox.Show("Modified successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.admin = admin;
                    txtEmail.Text = txtPassword.Text = "";
                }
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
            txtLocation.Text = about.Location;
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
                about.Location = txtLocation.Text;
                about.MobileNumber = txtMobile.Text;
                about = CallAPI.PostObjectAndGetObject<Models.About, Models.About>(about, "UpdateAbout", Program.admin.Token.ToString());
                if (about.Id != 0)
                {
                    MessageBox.Show("Modified successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailAbout.Text = about.Email;
                    txtLocation.Text = about.Location;
                    txtMobile.Text = about.MobileNumber;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("There Are An Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
