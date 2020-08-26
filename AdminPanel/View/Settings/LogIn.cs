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
            //Get Api Login
            if (txtEmail.Text == "aa")
            {
                IsLogin = true;
            }
            else
            {
                IsLogin = false;
            }
            Main.CheckLogin();
        }

        
    }
}
