using AdminPanel.Classes;
using AdminPanel.View.About;
using Library;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (txtEmailAbout.CheckNull())
                return;
            if (txtMobile.CheckNull())
                return;
            if (txtLocation.CheckNull())
                return;
            Models.About newAbout = new Models.About
            {
                Email = txtEmailAbout.Text,
                Location = txtLocation.Text,
                MobileNumber = txtMobile.Text
            };
            newAbout = CallAPI.PostObjectAndGetObject<Models.About, Models.About>(newAbout, "", Program.admin.Token.ToString());
            if (newAbout.Id != 0 )
            {
                MessageBox.Show("Modified successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                about = newAbout;
                txtEmailAbout.Text = about.Email;
                txtLocation.Text = about.Location;
                txtMobile.Text = about.MobileNumber;
            }
        }
    }
}
