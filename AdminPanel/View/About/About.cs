using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.View.About
{
    public partial class About : Form
    {
        Models.About about;
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            about = CallAPI.GetObjectContent<Models.About, Models.About>("GetAbout");
            txtEmail.Text = about.Email;
            txtLocation.Text = about.Location;
            txtMobile.Text = about.MobileNumber;
        }
    }
}
