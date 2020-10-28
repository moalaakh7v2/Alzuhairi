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
            CheckCode checkCode = new CheckCode
            {
                PhoneNumber = "0930701453",
                Code = 936507
            };
            //android2
            RegisterState State = CallAPI.PostObjectAndGetObject<CheckCode, RegisterState>(checkCode, "CheckCodeExists", "7");

            //  var x = CallAPI.PostObjectAndGetObject<StudentNoteBook, List<StudentNoteBook>>(new Guid("46e2cd41-a8d5-46b6-b265-0ad5100a4095"), "SetUpNewNoteBook", "1");
            MainForm = new Main();
            Application.Run(MainForm);
        }
    }
}
