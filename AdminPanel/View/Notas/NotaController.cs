using AdminPanel.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.View.Notas
{
    public partial class NotaController : Form
    {
        Panel pnlDisplay;
        public NotaController(Panel pnlDisplay)
        {
            this.pnlDisplay = pnlDisplay;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNota addNota = new AddNota();
            btnAdd.GetFormInDisplay(pnlDisplay, addNota);
        }
    }
}
