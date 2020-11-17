using AlzuhairiMobile.Services;
using Library;
using MediaManager;
using Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace AlzuhairiMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanVideoPage : ContentPage
    {
        public ScanVideoPage()
        {
            InitializeComponent();
        }

        private void btnScanVideo_Clicked(object sender, EventArgs e)
        {
            Scanner();
        }
        public async void Scanner()
        {
            try
            {
                int studentId = Convert.ToInt32(Settings.StudentId);
                var ScannerPage = new ZXingScannerPage();
                ScannerPage.OnScanResult += (result) =>
                {
                    ScannerPage.IsScanning = false;
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Navigation.PopModalAsync();
                        setUp(result.Text);
                    });
                };


                await Navigation.PushModalAsync(ScannerPage);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        async void setUp(string id)
        {
            try
            {
                Guid serialId = new Guid(id);
                await DisplayAlert("Done", "The code was read successful. Wait for the video to view", "Ok");
                try
                {
                    int studentId = Convert.ToInt32(Settings.StudentId);
                    Video video = CallAPI.PostObjectAndGetObject<Video, Video>(id, "GetVideo", studentId.ToString());
                    vidDisplay.Source = video.Path;
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", ex.Message, "Ok");
                }
            }
            catch
            {
                await DisplayAlert("Error", "Wrong QR code", "Ok");
            }
        }


    }
}