using AdminPanel.Classes;
using Library;
using Models;
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
        List<Student> students;
        public ManageStudents()
        {
            InitializeComponent();
        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            students = CallAPI.GetListContent<Student, Student>("GetStudents");
            grdStudents.DataSource = students;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            grdStudents.DataSource = students;
        }

        private void grdStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Student student = (Student)grdStudents.Rows[e.RowIndex].DataBoundItem;
                EditStudent editStudent = new EditStudent(student);
                editStudent.ShowDialog();
            }
            catch { }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var res = students.Where(x=>x.FirstName == txtName.Text).ToList();
                if (!res.Any())
                {
                    MessageBox.Show("Not Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                grdStudents.DataSource = res;
                
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            grdStudents.copyAlltoClipboard();
        }
    }
}
