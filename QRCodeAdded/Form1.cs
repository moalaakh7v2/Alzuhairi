using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeAdded
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddQRPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                string path = browser.SelectedPath;
                txtQRPath.Text = path;
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtQRPath.Text = txtFormPath.Text = string.Empty;
        }

        private void btnAddFormPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog()==DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                string path = fileDialog.FileName;
                txtFormPath.Text = path;
                Cursor.Current = Cursors.Default;

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }
    }
}
