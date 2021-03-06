﻿
using AdminPanel.Classes;
using Library;
using Models;
using System;
using System.Windows.Forms;

namespace AdminPanel.View.Settings
{
    public partial class LogIn : Form
    {
        Main Main;
        public static bool IsLogin;
        public LogIn(Main Main)
        {
            this.Main = Main;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Exit", "Exit Program", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "" || txtPassword == null)
                {
                    txtEmail.Text = "test";
                    txtPassword.Text = "123";
                }
                if (txtEmail.CheckNull())
                    return;
                if (txtPassword.CheckNull())
                    return;
                Admin admin = new Admin
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text
                };
                admin = CallAPI.PostObjectAndGetObject<Admin, Admin>(admin, "LogInAdminAccount");
                if (admin.Id != 0)
                {
                    Program.admin = admin;
                    IsLogin = true;
                }
                else
                {
                    IsLogin = false;
                }
                Main.CheckLogin();
            }
            catch
            {
                MessageBox.Show("Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
