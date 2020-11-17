using AlzuhairiMobile.Services;
using Library;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlzuhairiMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                txtFname.Text = Settings.FirstName;
                txtLname.Text = Settings.LastName;
                txtLocation.Text = Settings.Location;
            }
            catch(Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Cancel");
            }
           
        }

        private void btnReset_Clicked(object sender, EventArgs e)
        {
            txtFname.Text = txtLname.Text = txtLocation.Text = "";
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            try
            {
                Student student = CallAPI.GetObjectContent<Student, Student>("GetStudentByNumber", Settings.StudentPhone);
                student.FirstName = txtFname.Text;
                student.LastName = txtLname.Text;
                student.Address = txtLocation.Text;
                student = CallAPI.PostObjectAndGetObject<Student, Student>(student, "UpdateStudent", Settings.StudentId);
                if (student != null)
                {
                    Settings.FirstName = student.FirstName;
                    Settings.LastName = student.LastName;
                    Settings.Location = student.Address;
                    await DisplayAlert("Done", "operation accomplished successfully", "Ok");
                }
                else
                    await DisplayAlert("Error", "The operation failed", "Cancel");
            }
           catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Cancel");
            }

        }
    }
}