﻿using AdminPanel.Classes;
using Library;
using Models;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdminPanel.View.Students
{
    public partial class AddNewStudent : Form
    {
        public AddNewStudent()
        {
            InitializeComponent();
        }
        private void AddNewStudent_Load(object sender, EventArgs e)
        {
            comboDept.DataSource = Enum.GetValues(typeof(Dept));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtFName.CheckNull() && !txtLName.CheckNull() && txtAge.CheckAge() && txtNumber.CheckPhoneNumber())
            {
                Student student = new Student{
                    FirstName = txtFName.Text,
                    LastName = txtLName.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    PhoneNumber = txtNumber.Text,
                    Address = txtAddress.Text,
                    SchoolName = txtSchoolName.Text,
                    StudentNoteBooks  = new List<StudentNoteBook>()
                };
                student = CallAPI.PostObjectAndGetObject<Student, Student>(student, "UpdateStudent", student.Id.ToString());
                if (student.Id != 0)
                    MessageBox.Show("Student has been added successfully", "Done", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }


    }
}
