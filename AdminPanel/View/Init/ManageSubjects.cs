using AdminPanel.Classes;
using Library;
using Models;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.View.Init
{
    public partial class ManageSubjects : Form
    {
        List<Dept> depts;
        List<Student> students;
        List<Subject> subjects;
        public ManageSubjects()
        {
            InitializeComponent();
        }
        private void ManageSubjects_Load(object sender, EventArgs e)
        {
            try
            {
                depts = CallAPI.GetListContent<Dept, Dept>("GetDepts");
                subjects = CallAPI.GetListContent<Subject, Subject>("GetSubjects");
                comboDepts.DataSource = depts;
                comboDepts.ValueMember = "Id";
                comboDepts.DisplayMember = "DeptName";

                comboGetDept.DataSource = depts;
                comboGetDept.ValueMember = "Id";
                comboGetDept.DisplayMember = "DeptName";
            }
            catch (Exception)
            {
                MessageBox.Show("Error completing operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnAddDept_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDeptName.CheckNull())
                    return;
                if (depts.Any(x=>x.DeptName == txtDeptName.Text))
                {
                    MessageBox.Show("The section already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Dept dept = new Dept
                {
                    DeptName = txtDeptName.Text
                };
                dept = CallAPI.PostObjectAndGetObject<Dept, Dept>(dept, "AddNewDept");
                ManageSubjects_Load(sender, e);
                MessageBox.Show("Added SuccesFull", "Doen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDeptName.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error completing operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

     

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSubjectName.CheckNull())
                    return;
                int deptId = (int)comboDepts.SelectedValue;
                if (subjects.Any(x=>x.SubjectName == txtSubjectName.Text && x.DeptId == deptId))
                {
                    MessageBox.Show("The Subject name is duplicated in the same section","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                Subject subject = new Subject
                {
                    DeptId = (int)comboDepts.SelectedValue,
                    SubjectName = txtSubjectName.Text
                };
                if (radioFirst.Checked)
                    subject.Chapter = Chapter.First;
                else
                    subject.Chapter = Chapter.Second;
                subject = CallAPI.PostObjectAndGetObject<Subject, Subject>(subject, "AddNewSubject");
                MessageBox.Show("Added successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSubjectName.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error completing operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetStudents_Click(object sender, EventArgs e)
        {
            try
            {
                students = CallAPI.GetListContent<Student, Student>("GetStudentsByDeptId", comboGetDept.SelectedValue.ToString());
                var y = students.Select(x => new { x.FirstName, x.LastName, x.PhoneNumber }).ToList();
                grdStudents.DataSource = y;
            }
            catch (Exception)
            {
                CheckData.ErrorMessage();
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
    }
}
