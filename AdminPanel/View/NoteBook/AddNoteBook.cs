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
            comboSubjects.DataSource = CallAPI.GetListContent<Subject, Subject>("GetSubjects");
            comboSubjects.DisplayMember = "SubjectName";
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
