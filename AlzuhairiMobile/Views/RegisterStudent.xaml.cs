using AlzuhairiMobile.Services;
using Library;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlzuhairiMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterStudent : ContentPage
    {
        string PhoneNumber;
        public RegisterStudent(string phoneNumber)
        {
            InitializeComponent();
            PhoneNumber = phoneNumber;
        }
        protected override void OnAppearing()
        {
            Console.WriteLine(Convert.ToInt32((Console.ReadLine() + Console.ReadLine() + Console.ReadLine() + Console.ReadLine()
                              + Console.ReadLine() + Console.ReadLine())) / 6);
            base.OnAppearing();
        }
        private void btnReset_Clicked(object sender, EventArgs e)
        {
            txtFname.Text = txtLname.Text = txtAddress.Text = txtSchool.Text = txtAge.Text = "";
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            if (!checkData())
            {
                try
                {
                    Convert.ToInt32(txtAge.Text);
                }
                catch
                {
                    await DisplayAlert("Error", "Enter Age", "Ok");
                    return;
                }
                await DisplayAlert("Error" , "Please enter all data" , "Ok");
                return;
            }
            try
            {
               
                Student student = new Student();
                student.FirstName = txtFname.Text;
                student.LastName = txtLname.Text;
                student.Address = txtAddress.Text;
                student.PhoneNumber = PhoneNumber;
                student.Age = Convert.ToInt32(txtAge.Text);
                student = CallAPI.PostObjectAndGetObject<Student, Student>(student, "UpdateStudent", student.Id.ToString());
                if (student != null)
                {
                    Settings.StudentId = student.Id.ToString();
                    Settings.StudentPhone = student.PhoneNumber;
                    Settings.FirstName = student.FirstName;
                    Settings.LastName = student.LastName;
                    Settings.Location = student.Address;
                    await DisplayAlert("Done", "operation accomplished successfully", "Ok");
                    App.Current.MainPage = new AppShell();
                }
                else
                    await DisplayAlert("Error", "The operation failed", "Cancel");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Cancel");
            }
        }

        bool checkData()
        {
            if (string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text)
                || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtSchool.Text))
                return false;
            return true;

        }
    }
}