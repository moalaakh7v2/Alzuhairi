using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Classes
{
    public static class CheckData
    {
        public static bool CheckNull(this TextBox textBox , bool getMessage = true)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                if (getMessage)
                    MessageBox.Show("Please make sure to enter all data", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}
