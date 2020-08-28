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
    public partial class ManageStudents : Form
    {
        public ManageStudents()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            List<Test> tests = new List<Test>();
            tests.Add(new Test
            {
                Id = 7,
                FirstName = "Alaa",
                LastName = "Alkhawam",
                Age = 22,
                Active = true
            });
            tests.Add(new Test
            {
                Id = 7,
                FirstName = "Marco",
                LastName = "Asensio",
                Age = 25,
                Active = false
            });
            grdStudents.DataSource = tests;
        }
        class Test
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public bool Active { get; set; }
        }

        private void grdStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            editStudent.ShowDialog();
        }
    }
}
