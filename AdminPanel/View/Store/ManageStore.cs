using AdminPanel.Classes;
using Library;
using Models;
using Models.Enums;
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

namespace AdminPanel.View.Store
{
    public partial class ManageStore : Form
    {
        List<Reseller> resellers;
        Reseller reseller;
        List<ResellerAndNoteBook> resellerAndNoteBooks;
        List<Models.NoteBook> noteBooks;
        List<NoteBooksTitle> noteBooksTitles;
        public ManageStore()
        {
            InitializeComponent();
        }

        private void ManageStore_Load(object sender, EventArgs e)
        {
            comboLocation.DataSource = Enum.GetValues(typeof(Provinces));
            resellers = CallAPI.GetListContent<Reseller, Reseller>("GetResellers");
            grdStores.DataSource = resellers;
            grdStores.Columns["Id"].Visible = false;
            noteBooks = CallAPI.GetListContent<Models.NoteBook, Models.NoteBook>("GetNoteBooks");
            noteBooksTitles = new List<NoteBooksTitle>();
            foreach (var item in noteBooks)
            {
                noteBooksTitles.Add(new NoteBooksTitle
                {
                    Id = item.Id,
                    Title = item.Subject.SubjectName + " " + item.Subject.Dept.ToString() + " " + item.ReleaseDate.Year
                });
            }
            comboNoteBook.DataSource = noteBooksTitles;
            comboNoteBook.DisplayMember = "Title";
            comboNoteBook.ValueMember = "Id";
        }

        private void grdStores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                reseller = (Reseller)grdStores.Rows[e.RowIndex].DataBoundItem;
                lblTitle.Text = reseller.Title;
                resellerAndNoteBooks = CallAPI.GetListContent<Reseller, ResellerAndNoteBook>("GetResellerAndNoteBookByResellerId", reseller.Id.ToString());
                List<ResellerAndNoteBooksVM> resellerAndNoteBooksVM = new List<ResellerAndNoteBooksVM>();
                foreach (var item in resellerAndNoteBooks)
                {
                    resellerAndNoteBooksVM.Add(new ResellerAndNoteBooksVM
                    {
                        NoteBookTitle = item.NoteBook.Subject.SubjectName + " " + item.NoteBook.Subject.Dept.ToString() + " " + item.NoteBook.Subject.Chapter + " " + item.NoteBook.ReleaseDate.Year,
                        ResellerTitle = item.Reseller.Title,
                        Count = item.Count,
                        LastGrantDate = item.LastGrantDate
                    });
                }
                grdResellerAndNoteBook.DataSource = resellerAndNoteBooksVM;
                //grdResellerAndNoteBook.Columns["Id"].Visible =
                //grdResellerAndNoteBook.Columns["NoteBook"].Visible =
                //grdResellerAndNoteBook.Columns["Reseller"].Visible = false;
            }
            catch { }
        }

        private void btnGrant_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCount.CheckNull())
                    return;
                if (!txtCount.CheckInt())
                    return;
                if (comboNoteBook.SelectedItem == null)
                {
                    CheckData.ErrorMessage("Error , Plase Select notebook from the combo box");
                    return;
                }
                if(reseller == null)
                {
                    CheckData.ErrorMessage("Error , Plase Select reseller ");
                    return;
                }
                // Todo Check Limit of NoteBookSerials Count
                var noteBook = noteBooks.First(x => x.Id == (int)comboNoteBook.SelectedValue);
                   var countNoteBookSerials = noteBook.NoteBookSerials.Count;
                //----------------------------------------------------------------------
                ResellerAndNoteBook resellerAndNoteBook = CallAPI.PostObjectAndGetObject<ResellerAndNoteBook, ResellerAndNoteBook>(null,"GrantNoteBooksToReseller",
                 reseller.Id.ToString(), comboNoteBook.SelectedValue.ToString(), txtCount.Text);
                MessageBox.Show("Added Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                CheckData.ErrorMessage();
            }
                      
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            grdStores.DataSource = resellers.Where(x => x.Location.Split('-').First() == comboLocation.Text).ToList();
        }
    }
}
