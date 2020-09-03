
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
            //if (txtEmail.Text == "" || txtPassword==null)
            //{
            //    txtEmail.Text = "test";
            //    txtPassword.Text = "123";
            //}
            //Admin admin = CallAPI.
            //if (IsLogin = true;)
            //{

            //}
            //else
            //{
            //    IsLogin = false;
            //}
            //Main.CheckLogin();
        }

    }
}
