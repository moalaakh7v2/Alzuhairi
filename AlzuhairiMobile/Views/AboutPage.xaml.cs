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
                lblEmail.Text = "Email : " + about.Email;
                lblMobile.Text = "Mobile : " + about.MobileNumber;
                lblLocation.Text = "Location : " + about.Address;
            }
            catch(Exception ex)
            {
               await DisplayAlert("Error", ex.Message, "Cancel");
            }
           
        }

        private async void btnContacrUs_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}