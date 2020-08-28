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
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            txtFullName.Text = "Alaa Alkhawam";
            txtDept.Text = "TCC";
            txtPhone.Text = "0930701459";
        }
    }
}
