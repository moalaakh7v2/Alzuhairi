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

namespace AdminPanel.View.NoteBook
{
    public partial class AddNoteBook : Form
    {
        public AddNoteBook()
        {
            InitializeComponent();
        }

        private void AddNoteBook_Load(object sender, EventArgs e)
        {
            var subjects = CallAPI.GetListContent<Subject, Subject>("GetSubjects");
            List<SubjectsInDept> subjectsInDepts = new List<SubjectsInDept>();
            foreach (var item in subjects)
            {
                subjectsInDepts.Add(new SubjectsInDept
                {
                    Id= item.Id,
                    Title = item.SubjectName + " " + item.Dept.DeptName
                });
            }
            comboSubjects.DataSource = subjectsInDepts;
            comboSubjects.DisplayMember = "Title";
            comboSubjects.ValueMember = "Id";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Models.NoteBook> noteBooks = new List<Models.NoteBook>();
            int count = Convert.ToInt32(txtCount.Text);
            for (int i = 0; i <count; i++)
            {
                noteBooks.Add( new Models.NoteBook
                {
                    SubjectId = (int)comboSubjects.SelectedValue,
                    ReleaseDate = DateTime.Now,
                    Note = txtNote.Text
                });
            }
        }
    }
}
