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
using AdminPanel.View.Notas;
using AdminPanel.View.Students;
using AdminPanel.View.Subjects;
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudents_Click_1(object sender, EventArgs e)
        {
            StudenController myForm = new StudenController(pnlDisplay);
            btnStudents.ChangePanelMood(pnlControl, pnlDisplay, myForm);
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            SubjectsController myForm = new SubjectsController(pnlDisplay);
            btnSubjects.ChangePanelMood(pnlControl, pnlDisplay, myForm);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            NotaController myForm = new NotaController(pnlDisplay);
            btnBooks.ChangePanelMood(pnlControl, pnlDisplay, myForm);
        }
    }
}
