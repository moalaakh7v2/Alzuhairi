using AdminPanel.View.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.View
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn(this);
            logIn.TopLevel = false;
            logIn.AutoScroll = true;
            this.pnlView.Controls.Add(logIn);
            logIn.Show();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Exit", "Exit Program", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void CheckLogin()
        {
            if (LogIn.IsLogin)
            {
                pnlView.Controls.Clear();
            }
            else
            {
                MessageBox.Show("Login Information Error","Error");
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(63, 12);
        }

        private void btnNoteBook_Click(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(63, 67);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(63, 124);
        }
    }
}
