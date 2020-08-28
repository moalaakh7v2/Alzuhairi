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
    public partial class NoteBookPanel : Form
    {
        Main Main;
        public NoteBookPanel(Main main)
        {
            this.Main = main;
            InitializeComponent();
        }
        private void NoteBookPanel_Load(object sender, EventArgs e)
        {
            btnAddNoteBook_Click(sender, e);
        }
        private void btnAddNoteBook_Click(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(150, 12);

            AddNoteBook addNoteBook = new AddNoteBook();
            ShowInPanelView(addNoteBook);
        }
        private void btnManageNoteBook_Click(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(150, 67);

            ManageNoteBooks manageNoteBooks = new ManageNoteBooks();
            ShowInPanelView(manageNoteBooks);
        }
        void ShowInPanelView(Form form)
        {
            Main.pnlView.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            Main.pnlView.Controls.Add(form);
            form.Show();
        }

        
    }
}
