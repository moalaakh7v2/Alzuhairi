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

namespace AdminPanel.View.Store
{
    public partial class ManageStore : Form
    {
        List<Reseller> resellers;
        public ManageStore()
        {
            InitializeComponent();
        }

        private void ManageStore_Load(object sender, EventArgs e)
        {
            resellers = CallAPI.GetListContent<Reseller, Reseller>("GetResellers");
        }
    }
}
