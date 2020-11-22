using AdminPanel.Classes;
using Library;
using Models;
using Models.ViewModels;
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
        List<DisplayStudents> displayStudents;
        public ManageStudents()
        {
            InitializeComponent();
        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            students = CallAPI.GetListContent<Student, Student>("GetStudents");
            FillGridView(students);
            var years = students.Select(x => x.LoginData.Year).Distinct().ToList();
            comboYear.DataSource = years;
        }
        void FillGridView(List<Student> students)
        {
            displayStudents = new List<DisplayStudents>();
            grdStudents.DataSource = null;
            foreach (var item in students)
            {
                displayStudents.Add(new DisplayStudents
                {
                    Id = item.Id,
                    Age = item.Age,
                    IsActive = item.IsActive,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    PhoneNumber = item.PhoneNumber,
                    RegisterDate = item.LoginData
                });
            }
            grdStudents.DataSource = displayStudents;
            grdStudents.Columns["Id"].Visible = false;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillGridView(students);
        }

        private void grdStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DisplayStudents displayStudent = (DisplayStudents)grdStudents.Rows[e.RowIndex].DataBoundItem;
                var student = students.Find(x => x.Id == displayStudent.Id);
                EditStudent editStudent = new EditStudent(student);
                editStudent.ShowDialog();
                ManageStudents_Load(sender, e);
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
                FillGridView(res);
                
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdStudents.DataSource == null)
            {
                CheckData.ErrorMessage();
                return;
            }
            grdStudents.copyAlltoClipboard();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (comboYear.SelectedItem != null)
            {
                int year = (int)comboYear.SelectedItem;
                FillGridView(students.Where(x => x.LoginData.Year == year).ToList());
            }
        }
    }
}
