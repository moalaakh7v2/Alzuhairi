﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Ionic.Zip;

namespace AdminPanel.View.NoteBook
{
    public partial class AddVideo : Form
    {
        public static string VideosPath = @"C:\AlzuhairiVideos\";
        public static string ZipPath = @"C:\_ZipVideos\";
        List<string> ext = new List<string> { "mp4", "avi" };
        List<string> myFiles;
        public AddVideo()
        {
            InitializeComponent();
        }
        private void AddVideo_Load(object sender, EventArgs e)
        {
            Check();
            var files = myFiles.Select(x => x.Split('\\').Last()).ToList();
            comboBox1.DataSource = files;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CompressZip();
        }

        private void Check()
        {
            if (!Directory.Exists(VideosPath))
            {
                MessageBox.Show("عذراً لا يوجد أي فيديو", "تنبيه");
                Directory.CreateDirectory(VideosPath);
                return;
            }
            if (!Directory.Exists(ZipPath))
            {
                Directory.CreateDirectory(ZipPath);
                DirectoryInfo info = new DirectoryInfo(ZipPath);
                info.Attributes = FileAttributes.Hidden;
            }
            myFiles = Directory
                 .EnumerateFiles(VideosPath, "*.*", SearchOption.TopDirectoryOnly)
                 .Where(s => ext.Contains(Path.GetExtension(s).TrimStart('.').ToLowerInvariant())).ToList();
            if (!myFiles.Any())
            {
                MessageBox.Show("عذراً لا يوجد أي فيديو", "تنبيه");
                return;
            }
           
        }
        public void CompressZip()
        {
            ZipFile z = new ZipFile();
           var videoPath= myFiles.First(x => x.Split('\\').Last() == comboBox1.Text);
            z.AddFile(videoPath);
            string name = comboBox1.Text.Split('.').First() + ".zip";
            z.Save(string.Format("{0}/{1}", ZipPath, name));
            MessageBox.Show("تم ضغط الفيديو ","تم");
        }
    }
}