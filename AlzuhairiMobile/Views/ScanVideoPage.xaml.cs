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
            vidDisplay.IsVisible = false;
        }
        private void btnScanVideo_Clicked(object sender, EventArgs e)
        {
            vidDisplay.IsVisible = true;
            //https://res.cloudinary.com/dagpkl64s/video/upload/v1606168600/Facebook_w18iav.mp4
            Scanner();
        }

        private void btnScanExc_Clicked(object sender, EventArgs e)
        {
            //
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
                await DisplayAlert("خطأ", ex.Message, "خروج");
            }
        }

        void setUp(string VideoIdText)
        {
            try
            {
                Guid VideoId = new Guid(VideoIdText);
                DisplayAlert("تم", "انتظر قليلا ريثما يتم تحضير الفيديو", "موافق");
                try
                {
                    int studentId = Convert.ToInt32(Settings.StudentId);
                    Video video = CallAPI.PostObjectAndGetObject<Video, Video>(VideoId, "GetVideo", studentId.ToString());
                    vidDisplay.Source = video.Path;
                }
                catch (Exception ex)
                {
                     DisplayAlert("خطأ", ex.Message, "خروج");
                }
            }
            catch
            {
                 DisplayAlert("خطأ", "خطأ في قراءة الكود", "خروج");
            }
        }


    }
}