using AdminPanel.View.About;
using AdminPanel.View.Init;
using AdminPanel.View.NoteBook;
using AdminPanel.View.Settings;
using AdminPanel.View.Store;
using AdminPanel.View.Students;
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
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
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
                btnStudents.Visible = btnNoteBook.Visible = btnPOS.Visible = btnAbout.Visible  = btnInit.Visible = true;
            }
            else
            {
                MessageBox.Show("Login Information Error","Error");
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            pnlChoise.Visible = true;
            pnlChoise.Location = new Point(63, 12);

            StudentPanel studentPanel = new StudentPanel(this);
            ShowInPanelControlManage(studentPanel);
        }
        
        private void btnNoteBook_Click(object sender, EventArgs e)
        {
            pnlChoise.Visible = true;
            pnlChoise.Location = new Point(63, 67);

            NoteBookPanel noteBookPanel = new NoteBookPanel(this);
            ShowInPanelControlManage(noteBookPanel);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            pnlChoise.Visible = true;
            pnlChoise.Location = new Point(63, 124);

            StorePanel storePanel = new StorePanel();
            ShowInPanelControlManage(storePanel);
        }
        private void btnInit_Click(object sender, EventArgs e)
        {
            pnlChoise.Visible = true;
            pnlChoise.Location = new Point(63, 176);

            InitPanel initPanel = new InitPanel(this);
            ShowInPanelControlManage(initPanel);
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlChoise.Visible = true;
            pnlChoise.Location = new Point(63, 231);

            AboutPanel aboutPanel = new AboutPanel();
            ShowInPanelControlManage(aboutPanel);
        }

        void ShowInPanelControlManage(Form form)
        {
            this.pnlControlManage.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            this.pnlControlManage.Controls.Add(form);
            form.Show();
        }

        
    }
}
