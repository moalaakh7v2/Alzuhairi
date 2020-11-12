using AdminPanel.Classes;
using Library;
using Models;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.View.Init
{
    public partial class ManageSubjects : Form
    {
        public ManageSubjects()
        {
            InitializeComponent();
        }

        private void ManageSubjects_Load(object sender, EventArgs e)
        {
            comboChapter.DataSource = Enum.GetValues(typeof(Chapter));
            comboDept.DataSource = Enum.GetValues(typeof(Dept));

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                List<Subject> subjects = CallAPI.GetListContent<Subject, Subject>("GetSubjects");
                if (subjects.Any(x=>x.SubjectName == txtName.Text && x.Chapter == (Chapter)comboChapter.SelectedValue && x.Dept == (Dept)comboDept.SelectedValue ))
                {
                    MessageBox.Show("The information was already entered","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                Subject subject = new Subject
                {
                    SubjectName = txtName.Text,
                    Chapter = (Chapter)comboChapter.SelectedValue,
                    Dept = (Dept)comboDept.SelectedValue
                };
                subject = CallAPI.PostObjectAndGetObject<Subject, Subject>(subject, "AddNewSubject");
                MessageBox.Show("The information has been entered successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred, please try again" , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
