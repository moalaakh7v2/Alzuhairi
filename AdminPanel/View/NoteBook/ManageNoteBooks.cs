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
        public ManageNoteBooks()
        {
            InitializeComponent();
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            AddVideo video = new AddVideo();
            video.ShowDialog();
        }

    }
}
