using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.View.Students
{
    public partial class StudentPanel : Form
    {
        Main Main;
        public StudentPanel(Main main)
        {
            this.Main = main;
            InitializeComponent();
        }
        private void StudentPanel_Load(object sender, EventArgs e)
        {
            btnAddStudents_Click(sender, e);
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(150, 12);

            AddNewStudent addNewStudent = new AddNewStudent();
            ShowInPanelView(addNewStudent);
        }


        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(150, 66);

            ManageStudents manageStudents = new ManageStudents();
            ShowInPanelView(manageStudents);


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
