using System;
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
using Library;
using Models;

namespace AdminPanel.View.NoteBook
{
    public partial class AddVideo : Form
    {
        int noteBookId;
        public static string VideosPath = @"C:\AlzuhairiVideos\";
        public static string ZipPath = @"C:\_ZipVideos\";
        List<string> ext = new List<string> { "mp4", "avi" };
        List<string> myFiles;
        string name;
        public AddVideo(int noteBookId)
        {
            this.noteBookId = noteBookId;
            InitializeComponent();
        }
        private void AddVideo_Load(object sender, EventArgs e)
        {
            Check();
            var files = myFiles.Select(x => Path.GetFileName(x)).ToList();
            comboBox1.DataSource = files;
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
            var videoPath = myFiles.First(x => Path.GetFileName(x) == comboBox1.Text);
            z.AddFile(videoPath);
            name = Path.GetFileNameWithoutExtension(videoPath) + ".zip";
            z.Save(string.Format("{0}/{1}", ZipPath, name));
            MessageBox.Show("تم ضغط الفيديو ","تم");
        }
        public static void ClearDir(string dirPath)
        {
            string[] Files = Directory.GetFiles(dirPath);
            foreach (string f in Files)
                File.Delete(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompressZip();
            Video video = CallAPI.PostFile<Video, Video>(ZipPath + name, "AddVideoToNoteBook", noteBookId.ToString());
            if (video == null)
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
