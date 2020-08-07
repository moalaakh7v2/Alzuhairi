using AdminPanel.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.View.Subjects
{
    public partial class SubjectsController : Form
    {
        Panel pnlDisplay;
        public SubjectsController(Panel pnlDisplay)
        {
            this.pnlDisplay = pnlDisplay;
            InitializeComponent();
        }

        private void SubjectsController_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            ManageSubjects displaySubjects = new ManageSubjects();
            btnDisplay.GetFormInDisplay(pnlDisplay, displaySubjects);
        }
    }
}
