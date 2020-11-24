using Android.OS;
using Library;
using Models;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlzuhairiMobile.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                About about = CallAPI.GetObjectContent<About, About>("GetAbout");
                lblEmail.Text = "البريد الالكتروني : " + about.Email;
                lblMobile.Text = "الجوال : " + about.MobileNumber;
                lblLocation.Text = "الموقع : " + about.Address;
            }
            catch(Exception ex)
            {
               await DisplayAlert("Error", ex.Message, "Cancel");
            }
        }
    }
}