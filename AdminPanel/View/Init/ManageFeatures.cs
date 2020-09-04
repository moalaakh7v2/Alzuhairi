using AdminPanel.Classes;
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
            if (txtTitle.CheckNull())
                return;
            Feature feature = new Feature { Title = txtTitle.Text };
            feature = CallAPI.PostObjectAndGetObject<Feature, Feature>(feature, "AddFeature");
            if (feature.Id != 0)
            {
                MessageBox.Show("Added successfully","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                features.Add(feature);
                FillGrid();
            }
        }

        private void ManageFeatures_Load(object sender, EventArgs e)
        {
            features = CallAPI.GetListContent<Feature, Feature>("GetFeatures");
            FillGrid();
        }

        void FillGrid()
        {
            lstFeatures.DataSource = null;
            lstFeatures.DataSource = features;
            lstFeatures.DisplayMember = "Title";
        }
    }
}
