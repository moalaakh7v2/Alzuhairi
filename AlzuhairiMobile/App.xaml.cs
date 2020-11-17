using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AlzuhairiMobile.Services;
using AlzuhairiMobile.Views;
using Models;

namespace AlzuhairiMobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        public static void SaveProp(Student student)
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
