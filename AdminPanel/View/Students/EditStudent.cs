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
    public partial class EditStudent : Form
    {
        Student student;
        public EditStudent(Student student)
        {
            this.student = student;
            InitializeComponent();
        }


        private void EditStudent_Load(object sender, EventArgs e)
        {
            txtFullName.Text = student.FirstName + " " + student.LastName;
            txtDept.Text = student.Dept.DeptName;
            txtPhone.Text = student.PhoneNumber;
            if (!student.IsActive)
                btnDeactive.Enabled = false;
            foreach (var item in student.StudentNoteBooks.Select(x=>x.NoteBookSerial).Select(x=>x.NoteBook))
            {
                lstNoteBook.Items.Add(item.Subject.SubjectName + " - " + item.Subject.Dept.DeptName + " - " + item.ReleaseDate.Year);
            }
            // todo Alaa Get VideoWatched
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            student.IsActive = false;
            student = CallAPI.PostObjectAndGetObject<Student, Student>(student,"ModifyStudent", "false");
            Close();

        }
    }
}
