﻿using Library;
using Models;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.View.NoteBook
{
    public partial class AddNoteBook : Form
    {
        List<Subject> subjects;
        List<SubjectsInDept> subjectsInDepts;
        List<Feature> features;
        List<NoteBookSerial> noteBookSerials;
        public AddNoteBook()
        {
            InitializeComponent();
        }

        private void AddNoteBook_Load(object sender, EventArgs e)
        {
            subjects = CallAPI.GetListContent<Subject, Subject>("GetSubjects");
            features = CallAPI.GetListContent<Feature, Feature>("GetFeatures");
            subjectsInDepts = new List<SubjectsInDept>();
            foreach (var item in subjects)
            {
                subjectsInDepts.Add(new SubjectsInDept
                {
                    Id = item.Id,
                    Title = item.SubjectName + " " + item.Dept.DeptName
                });
            }
            comboSubjects.DataSource = subjectsInDepts;
            comboSubjects.DisplayMember = "Title";
            comboSubjects.ValueMember = "Id";
            foreach (var feature in features)
            {
                chkFeatures.Items.Add(feature);
            }
            chkFeatures.DisplayMember = "Title";
            chkFeatures.ValueMember = "Id";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> featureIds = new List<int>();
                foreach (var itemChecked in chkFeatures.CheckedItems)
                {
                    featureIds.Add(((Feature)itemChecked).Id);
                }
                var ChoseFeature = features.Where(x => featureIds.Contains(x.Id)).ToList();
                List<NoteBookFeature> noteBookFeatures = new List<NoteBookFeature>();
                foreach (var item in ChoseFeature)
                {
                    noteBookFeatures.Add(new NoteBookFeature
                    {
                        FeatureId = item.Id,
                        IsActive = true
                    });
                }
                Models.NoteBook noteBook = new Models.NoteBook
                {
                    Note = txtNote.Text,
                    SubjectId = (int)comboSubjects.SelectedValue,
                    NoteBookFeatures = noteBookFeatures
                };
                noteBook = CallAPI.PostObjectAndGetObject<Models.NoteBook, Models.NoteBook>(noteBook, "AddNewNoteBook", txtCount.Text);
                MessageBox.Show("Added successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                noteBookSerials = noteBook.NoteBookSerials.ToList();
                grdQRcode.DataSource = noteBookSerials;
                grdQRcode.Columns[0].Visible = grdQRcode.Columns[2].Visible =
                grdQRcode.Columns[3].Visible = grdQRcode.Columns[4].Visible = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show("There Are An Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQrDownload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                string path = browser.SelectedPath;

                foreach (var item in noteBookSerials)
                {
                    QRcode.CreateQR(item.QRcode.ToString(), path);
                }
                MessageBox.Show("operation accomplished successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
