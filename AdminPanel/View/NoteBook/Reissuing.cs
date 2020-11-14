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
    public partial class Reissuing : Form
    {
        List<Models.NoteBook> noteBooks;
        List<NoteBooksTitle> noteBooksTitles;
        Models.NoteBook noteBook;
        public Reissuing()
        {
            InitializeComponent();
        }

        private void Reissuing_Load(object sender, EventArgs e)
        {
            noteBooks = CallAPI.GetListContent<Models.NoteBook, Models.NoteBook>("GetNoteBooks");
            if (!noteBooks.Any())
            {
                MessageBox.Show("There is no notebook yet","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnReissuing.Enabled = btnQrDownload.Enabled = false;
                return;
            }
            noteBooksTitles = new List<NoteBooksTitle>();
            foreach (var item in noteBooks)
            {
                noteBooksTitles.Add(new NoteBooksTitle
                {
                    Id = item.Id,
                    Title = item.Subject.SubjectName + " " + item.Subject.Dept.ToString() + " " + item.Subject.Chapter + " " + item.ReleaseDate.Year
                });
            }
            comboNoteBook.DataSource = noteBooksTitles;
            comboNoteBook.DisplayMember = "Title";
            comboNoteBook.ValueMember = "Id";
        }

        private void btnReissuing_Click(object sender, EventArgs e)
        {
            if (!txtCount.CheckInt())
                return;
            noteBook = noteBooks.First(x => x.Id == (int)comboNoteBook.SelectedValue);
            noteBook = CallAPI.PostObjectAndGetObject<Models.NoteBook, Models.NoteBook>(noteBook, "AddNewSerialForExistNoteBook", txtCount.Text);
            grdQRcode.DataSource = noteBook.NoteBookSerials;
            grdQRcode.Columns[0].Visible = grdQRcode.Columns[2].Visible =
            grdQRcode.Columns[3].Visible = grdQRcode.Columns[4].Visible = false;
        }

        private void btnQrDownload_Click(object sender, EventArgs e)
        {
            if (grdQRcode.DataSource == null)
            {
                MessageBox.Show("There is no code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                string path = browser.SelectedPath;

                foreach (var item in noteBook.NoteBookSerials)
                {
                    QRcode.CreateQR(item.QRcode.ToString(), path);
                }
                MessageBox.Show("operation accomplished successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
