using System;
using System.Windows.Forms;

namespace AdminPanel.Classes
{
    public static class CheckData
    {
        public static bool CheckNull(this TextBox textBox, bool getMessage = true)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                if (getMessage)
                    MessageBox.Show("Please make sure to enter all data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public static bool CheckInt(this TextBox textBox, bool getMessage = true)
        {
            if (!textBox.CheckNull())
            {
                try
                {
                    Convert.ToInt32(textBox.Text);
                    return true;
                }
                catch 
                {
                    if (getMessage)
                    {
                        MessageBox.Show("Please verify the entered number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return false;
        }
        public static bool CheckPhoneNumber(this TextBox textBox, bool getMessage = true)
        {
            if (!textBox.CheckNull())
            {
                try
                {
                    string phone = Convert.ToInt32(textBox.Text).ToString();
                    if (phone.Length != 9)
                        throw new Exception();
                    return true;
                }
                catch
                {
                    if (getMessage)
                    {
                        MessageBox.Show("Please verify the entered phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return false;
        }
        public static bool CheckAge(this TextBox textBox, bool getMessage = true)
        {
            if (!textBox.CheckNull())
            {

                try
                {
                    int age = Convert.ToInt32(textBox.Text);
                    if (age < 10 || age > 50)
                        throw new Exception();
                    return true;
                }
                catch
                {
                    if (getMessage)
                    {
                        MessageBox.Show("Please enter a valid age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return false;
        }

        public static void ErrorMessage(string message = "There are An Error")
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
