using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminPanel.Tools;
using AdminPanel.View.Students;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace AdminPanel.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudents_Click_1(object sender, EventArgs e)
        {
            controller myForm = new controller(pnlDisplay);
            btnStudents.ChangePanelMood(pnlControl, pnlDisplay, myForm);
        }
    }
}
