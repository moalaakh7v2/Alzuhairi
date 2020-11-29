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
            vidDisplay.IsVisible = pdfDisplay.IsVisible = false;
        }
        private void btnScanVideo_Clicked(object sender, EventArgs e)
        {
            pdfDisplay.IsVisible = false;
            vidDisplay.IsVisible = true;
            //https://res.cloudinary.com/dagpkl64s/video/upload/v1606168600/Facebook_w18iav.mp4
            Scanner();
        }

        private void btnScanExc_Clicked(object sender, EventArgs e)
        {
            vidDisplay.IsVisible = false
            pdfDisplay.IsVisible = true;
            //https://drive.google.com/file/d/1bY1y3xTcwU75nFuPnFUL5wHfem3zxMv9/view?usp=sharing
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
                    File video = CallAPI.PostObjectAndGetObject<File, File>(VideoId, "GetVideo", studentId.ToString());
                    if (video.IsVideo)
                        vidDisplay.Source = video.Path;
                    else
                        pdfDisplay.Source = video.Path;
                    
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