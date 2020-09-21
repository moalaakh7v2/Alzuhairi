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

namespace AdminPanel.View.NoteBook
{
    public partial class ManageNoteBooks : Form
    {
        List<Models.NoteBook> noteBooks;
        List<NoteBooksTitle> noteBooksTitles;
        List<Video> videos;
        public ManageNoteBooks()
        {
            InitializeComponent();
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            try
            {
                AddVideo video = new AddVideo((int)comboDeptSubjectYear.SelectedValue);
                video.ShowDialog();
            }
            catch
            {
                CheckData.ErrorMessage();
            }
        }

        private void ManageNoteBooks_Load(object sender, EventArgs e)
        {
            try
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


            }
            catch
            {
                CheckData.ErrorMessage();
            }
        }

        private void comboDeptSubjectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDeptSubjectYear.DisplayMember = "Title";
            comboDeptSubjectYear.ValueMember = "Id";
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

            videos = notebook.Videos.ToList();
            foreach (var item in videos)
            {
                chkVideos.Items.Add(item);
            }
            chkVideos.DisplayMember = "Title";
            chkVideos.ValueMember = "Id";
        }

        private void btnDeAvtiveNoteBook_Click(object sender, EventArgs e)
        {
            try
            {
                int notebookId = (int)comboDeptSubjectYear.SelectedValue;
                Models.NoteBook noteBook = CallAPI.GetObjectContent<Models.NoteBook, Models.NoteBook>("DeActiveNoteBook", notebookId.ToString());
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                CheckData.ErrorMessage();
            }
       
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(chkVideos.Items.Count == 0 || chkVideos.CheckedItems.Count == 0)
            {
                CheckData.ErrorMessage();
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            List<Guid> vidoeIds = new List<Guid>();
            foreach (object itemChecked in chkVideos.CheckedItems)
            {
                DataRowView castedItem = itemChecked as DataRowView;
                vidoeIds.Add(new Guid(castedItem["Id"].ToString()));
            }
            CallAPI.PostObjectAndGetObject<Video,Video>(vidoeIds, "RemoveVideo");
            Cursor.Current = Cursors.Default;
            MessageBox.Show("The deletion was successful" , "Done" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            comboDeptSubjectYear_SelectedIndexChanged(sender, e);
        }

        private void btnDownloadVideoQR_Click(object sender, EventArgs e)
        {
            if (chkVideos.Items.Count == 0)
            {
                MessageBox.Show("There is no Video", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                string path = browser.SelectedPath;
                foreach (var item in videos)
                    QRcode.CreateQR(item.Id.ToString(), path , 10 , item.Title);
                Cursor.Current = Cursors.Default;
                MessageBox.Show("operation accomplished successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
