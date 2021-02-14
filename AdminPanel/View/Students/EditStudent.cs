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
            txtPhone.Text = student.PhoneNumber;
            //if (!student.IsActive)
            //    btnDeactive.Text = "Activate";
            //else
            //    btnDeactive.Text = "Deactivate";

            foreach (var item in student.StudentNoteBooks.Select(x=>x.NoteBookSerial).Select(x=>x.NoteBook))
            {
                lstNoteBook.Items.Add(item.Subject.SubjectName + " - " + item.Subject.Dept.ToString() + " - " + item.ReleaseDate.Year);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            //if (btnDeactive.Text == "Deactivate")
            //    student.IsActive = false;
            //else if (btnDeactive.Text == "Activate")
            //    student.IsActive = true;
            student = CallAPI.PostObjectAndGetObject<Student, Student>(student,"ModifyStudent");
            Close();

        }
    }
}
