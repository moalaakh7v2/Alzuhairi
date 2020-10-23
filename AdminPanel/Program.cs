using AdminPanel.View;
using Library;
using Models;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel
{
   
    public static class Program
    {
        public static Admin admin;
        public static Main MainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var xxxx = CallAPI.GetObjectContent<Student, Student>("test" , "3" , "true");
            MainForm = new Main();
            Application.Run(MainForm);
        }
    }
}
