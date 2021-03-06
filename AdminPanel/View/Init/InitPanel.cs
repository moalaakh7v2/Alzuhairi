﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminPanel.View.Settings;

namespace AdminPanel.View.Init
{
    public partial class InitPanel : Form
    {
        Main Main;
        public InitPanel(Main main)
        {
            this.Main = main;
            InitializeComponent();
        }

        private void InitPanel_Load(object sender, EventArgs e)
        {
            btnSubjects_Click(sender, e);
        }
        private void btnSubjects_Click(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(150, 12);

            ManageSubjects manageSubjects = new ManageSubjects();
            ShowInPanelView(manageSubjects);
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(150, 66);

            ManageFeatures manageFeatures = new ManageFeatures();
            ShowInPanelView(manageFeatures);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlChoise.Location = new Point(150, 122);

            Settings.Settings settings = new Settings.Settings();
            ShowInPanelView(settings);
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
