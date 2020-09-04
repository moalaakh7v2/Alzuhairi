﻿using AdminPanel.Classes;
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

namespace AdminPanel.View.Init
{
    public partial class ManageSubjects : Form
    {
        List<Dept> depts;
        List<Student> students;
        public ManageSubjects()
        {
            InitializeComponent();
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            if (txtDeptName.CheckNull())
                return;
            Dept dept = new Dept
            {
                DeptName = txtDeptName.Text
            };
            dept = CallAPI.PostObjectAndGetObject<Dept, Dept>(dept, "AddNewDept");
            MessageBox.Show("Added SuccesFull", "Doen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ManageSubjects_Load(object sender, EventArgs e)
        {
            depts = CallAPI.GetListContent<Dept, Dept>("GetDepts");
            comboDepts.DataSource = depts;
            comboDepts.ValueMember = "Id";
            comboDepts.DisplayMember = "DeptName";

            comboGetDept.DataSource = depts;
            comboGetDept.ValueMember = "Id";
            comboGetDept.DisplayMember = "DeptName";
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (txtSubjectName.CheckNull())
                return;
            Subject subject = new Subject
            {
                DeptId = (int)comboDepts.SelectedValue,
                SubjectName = txtSubjectName.Text
            };
            subject = CallAPI.PostObjectAndGetObject<Subject, Subject>(subject, "AddNewSubject");
        }

        private void btnGetStudents_Click(object sender, EventArgs e)
        {
            students = CallAPI.GetListContent<Student, Student>("GetStudentsByDeptId", comboGetDept.SelectedValue.ToString());
            grdStudents.DataSource = students;
        }
    }
}
