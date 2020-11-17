using System;
using System.Collections.Generic;
using AlzuhairiMobile.Services;
using AlzuhairiMobile.Views;
using Models;
using Plugin.SecureStorage;
using Xamarin.Forms;

namespace AlzuhairiMobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            try
            {
                Settings.StudentId = "";
                Settings.StudentPhone = "";
                Settings.RegisterNoteBook = "";
                Settings.FirstName = "";
                Settings.LastName = "";
                Settings.Location = "";
                Settings.NoteBookFeature = "";
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error" , ex.Message , "Cancel");
            }
            await Shell.Current.GoToAsync("//LoginPage");
        } 
    }
}
