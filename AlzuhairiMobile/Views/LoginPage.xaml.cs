using System;
using AlzuhairiMobile.Services;
using Android.Widget;
using Library;
using Models;
using Models.Enums;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Settings = AlzuhairiMobile.Services.Settings;

namespace AlzuhairiMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            txtCode.IsVisible = btnVerify.IsVisible = btnReset.IsVisible = false;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!string.IsNullOrEmpty(Settings.StudentId))
            {
                Application.Current.MainPage = new AppShell();
                return;
            }

        }

        private async void btnSend_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPhoneNumber.Text) || txtPhoneNumber.Text.Length != 10)
                {
                    await DisplayAlert("Error", "Enter A valid Phone Number", "Cancel");
                    return;
                }
                var GetMac = Tools.GetMacAddr();
                var checkCode = CallAPI.GetObjectContent<CheckCode, CheckCode>("CreateCode", txtPhoneNumber.Text, GetMac);
                if (checkCode != null)
                {
                    Toast.MakeText(Android.App.Application.Context, "Send Message To " + txtPhoneNumber.Text, ToastLength.Long).Show();
                    txtCode.IsVisible = btnVerify.IsVisible = btnReset.IsVisible = true;
                    txtPhoneNumber.IsEnabled = btnSend.IsEnabled = false;
                }
                else
                {
                    await DisplayAlert("Error", "re-Send Code Letter", "Ok");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Cancel");
            }
            
        
        }

        private async void btnVerify_Clicked(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrEmpty(txtCode.Text))
                {
                    await DisplayAlert("Error", "Error Code", "Cancel");
                    return;
                }
                CheckCode checkCode = new CheckCode
                {
                    PhoneNumber = txtPhoneNumber.Text,
                    Code = Convert.ToInt32(txtCode.Text)
                };
                RegisterState State = CallAPI.PostObjectAndGetObject<CheckCode, RegisterState>(checkCode, "CheckCodeExists", "7");
                if (State == RegisterState.Blocked)
                {
                    await DisplayAlert("Error", "Your account has been banned", "Cancel");
                    return;
                }
                if (State == RegisterState.NoteFound)
                {
                    await DisplayAlert("Error", "Incorrect code", "Cancel");
                    return;
                }
                if (State == RegisterState.unregistered)
                {
                    await Navigation.PushModalAsync(new RegisterStudent(txtPhoneNumber.Text));
                    return;
                }
                if (State == RegisterState.AlreadyRegistered)
                {
                    Student student = CallAPI.GetObjectContent<Student, Student>("GetStudentByNumber", txtPhoneNumber.Text);
                    Settings.StudentId = student.Id.ToString();
                    Settings.StudentPhone = student.PhoneNumber;
                    Settings.FirstName = student.FirstName;
                    Settings.LastName = student.LastName;
                    Settings.Location = student.Address;
                    App.Current.MainPage = new AppShell();
                }
              
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Cancel");
            }
           
        }

        private void btnReset_Clicked(object sender, EventArgs e)
        {
            txtCode.IsVisible = btnReset.IsVisible = btnVerify.IsVisible = false;
            txtPhoneNumber.IsEnabled = btnSend.IsEnabled = true;
        }
    }
}