﻿using AdminPanel.Classes;
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

namespace AdminPanel.View.NoteBook
{
    public partial class AddVideoInfo : Form
    {
        Models.NoteBook noteBook;
        public AddVideoInfo(Models.NoteBook noteBook)
        {
            this.noteBook = noteBook;
            InitializeComponent();
        }

        private void AddVideoInfo_Load(object sender, EventArgs e)
        {
            lblNoteBook.Text = noteBook.Title;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPath.CheckNull())
                return;
            if (txtTitle.CheckNull())
                return;
            File file = new File
            {
                Title = txtTitle.Text,
                Path = txtPath.Text,
                NoteBookId = noteBook.Id,
                IsVideo = RadioVideo.Checked,
                IsActive = true
            };
            var checkFile = CallAPI.PostObjectAndGetObject<File, File>(file, "AddFile");
            if (checkFile == null)
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
