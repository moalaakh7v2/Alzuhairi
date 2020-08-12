using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Tools
{
    public static  class  FormMood
    {
        public static void ChangePanelMood(this Button btn , Panel panelController , Panel panelDisplay , Form myForm)
        {
            panelController.Controls.Clear();
            panelDisplay.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panelController.Controls.Add(myForm);
            myForm.Show();
        }

        public static void GetFormInDisplay(this Button btn, Panel panelDisplay, Form myForm)
        {
            panelDisplay.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panelDisplay.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
