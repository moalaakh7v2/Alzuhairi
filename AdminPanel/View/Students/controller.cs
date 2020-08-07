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

namespace AdminPanel.View.Students
{
    public partial class controller : Form
    {
        Panel pnlDisplay;
        public controller(Panel pnlDisplay)
        {
            this.pnlDisplay = pnlDisplay;
            InitializeComponent();
        }

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            DisplayStudents displayStudents = new DisplayStudents();
            btnDisplay.GetFormInDisplay(pnlDisplay, displayStudents);
        }
    }
}
