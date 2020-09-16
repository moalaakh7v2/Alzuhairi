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
    public partial class ManageNoteBooks : Form
    {
        List<Models.NoteBook> noteBooks;
        List<NoteBooksTitle> noteBooksTitles;
        public ManageNoteBooks()
        {
            InitializeComponent();
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            AddVideo video = new AddVideo((int)comboDeptSubjectYear.SelectedValue);
            video.ShowDialog();
        }

        private void ManageNoteBooks_Load(object sender, EventArgs e)
        {
            noteBooks = CallAPI.GetListContent<Models.NoteBook, Models.NoteBook>("GetNoteBooks");
            noteBooksTitles = new List<NoteBooksTitle>();
            foreach (var item in noteBooks)
            {
                noteBooksTitles.Add(new NoteBooksTitle
                {
                    Id = item.Id,
                    Title = item.Subject.SubjectName + " " + item.Subject.Dept.DeptName + " " + item.ReleaseDate.Year
                });
            }
            comboDeptSubjectYear.DataSource = noteBooksTitles;
            comboDeptSubjectYear.DisplayMember = "Title";
            comboDeptSubjectYear.ValueMember = "Id";
        }

        private void comboDeptSubjectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int notebookId = (int)comboDeptSubjectYear.SelectedValue;
            var notebook = noteBooks.First(x => x.Id == notebookId);
            btnDeAvtiveNoteBook.Visible = notebook.IsActive;
            List<Feature> features = notebook.NoteBookFeatures.Select(x => x.Feature).ToList();
            lstFeatures.DataSource = features.Select(x=>x.Title);
            txtCount.Text = notebook.NoteBookSerials.Count.ToString();

            //todo Test This 
            var used = notebook.NoteBookSerials.Select(x => x.StudentNoteBooks.Count());
            txtUsed.Text = used.Sum().ToString();
            txtUnused.Text = (notebook.NoteBookSerials.Count() - used.Sum()).ToString();

            var videos = notebook.Videos.ToList();
            foreach (var item in videos)
            {
                chkVideos.Items.Add(item);
            }
            chkVideos.DisplayMember = "Title";
            chkVideos.ValueMember = "Id";
        }

        private void btnDeAvtiveNoteBook_Click(object sender, EventArgs e)
        {
            int notebookId = (int)comboDeptSubjectYear.SelectedValue;
            Models.NoteBook noteBook = CallAPI.GetObjectContent<Models.NoteBook, Models.NoteBook>("DeActiveNoteBook", notebookId.ToString());
            MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
