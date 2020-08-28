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
        public NoteBookPanel()
        {
            InitializeComponent();
        }

        private void btnAddNoteBook_Click(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(150, 12);
        }
    }
}
