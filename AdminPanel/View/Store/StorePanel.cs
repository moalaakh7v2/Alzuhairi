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
    public partial class StorePanel : Form
    {
        Main Main;
        public StorePanel(Main main)
        {
            this.Main = main;
            InitializeComponent();
        }
        private void StorePanel_Load(object sender, EventArgs e)
        {
            btnAddStore_Click(sender, e);
        }
        private void btnAddStore_Click(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(150, 12);

            AddStore addStore = new AddStore();
            ShowInPanelView(addStore);
        }
        private void btnManageStore_Click_1(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(150, 67);

            ManageStore manageStore = new ManageStore();
            ShowInPanelView(manageStore);

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
