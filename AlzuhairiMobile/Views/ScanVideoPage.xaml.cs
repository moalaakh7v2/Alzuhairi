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
        bool IsVideo;
        public ScanVideoPage()
        {
            InitializeComponent();
            //vidDisplay.IsVisible = pdfDisplay.IsVisible = false;
        }
        private void btnScanVideo_Clicked(object sender, EventArgs e)
        {
            //pdfDisplay.IsVisible = false;
            //vidDisplay.IsVisible = true;
            IsVideo = true;
            //pdfDisplay.Source = "";
            Scanner();
        }

        private void btnScanExc_Clicked(object sender, EventArgs e)
        {
            //vidDisplay.IsVisible = false;
            //pdfDisplay.IsVisible = true;
            IsVideo = false;
            //vidDisplay.Source = "";
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
                await DisplayAlert("خطأ", ex.Message, "خروج");
            }
        }

        async void setUp(string VideoIdText)
        {
            try
            {
                await DisplayAlert("تم", "انتظر قليلا ريثما يتم تحضير الملف لعرضه", "موافق");
                Guid VideoId = new Guid(VideoIdText);
                try
                {
                    int studentId = Convert.ToInt32(Settings.StudentId);
                    File video = CallAPI.PostObjectAndGetObject<File, File>(VideoId, "GetVideo", studentId.ToString(), IsVideo.ToString());
                    await Navigation.PushModalAsync(new DisplayFile(video.IsVideo, video.Path));
                }
                catch (Exception ex)
                {
                    await DisplayAlert("خطأ", ex.Message, "خروج");
                }
            }
            catch
            {
                 await DisplayAlert("خطأ", "خطأ في قراءة الكود", "خروج");
            }
        }


    }
}