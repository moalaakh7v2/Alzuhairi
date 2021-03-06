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

namespace AdminPanel.View.Init
{
    public partial class ManageFeatures : Form
    {
        List<Feature> features;
        public ManageFeatures()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitle.CheckNull())
                    return;
                if (features.Any(x=>x.Title == txtTitle.Text))
                {
                    MessageBox.Show("A pre-existing feature", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Feature feature = new Feature { Title = txtTitle.Text };
                feature = CallAPI.PostObjectAndGetObject<Feature, Feature>(feature, "AddFeature");
                if (feature.Id != 0)
                {
                    MessageBox.Show("Added successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTitle.Text = "";
                    features.Add(feature);
                    FillGrid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There Are An Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ManageFeatures_Load(object sender, EventArgs e)
        {
            try
            {
                features = CallAPI.GetListContent<Feature, Feature>("GetFeatures");
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There Are An Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void FillGrid()
        {
            lstFeatures.DataSource = null;
            lstFeatures.DataSource = features.Where(x => x.Id != 1).ToList();
            lstFeatures.DisplayMember = "Title";
        }
    }
}
