using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlzuhairiMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayFile : ContentPage
    {
        bool IsVideo;
        string Path;
        public DisplayFile(bool IsVideo, string Path)
        {
            this.IsVideo = IsVideo;
            this.Path = Path;
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (IsVideo)
                Video();
            else
                PDF();
        }

        void Video()
        {
            vidDisplay.IsVisible = true;
            pdfDisplay.IsVisible = false;
            pdfDisplay.Source = "";
            vidDisplay.Source = Path;
        }
        void PDF()
        {
            pdfDisplay.IsVisible = true;
            vidDisplay.IsVisible = false;
            vidDisplay.Source = "";
            pdfDisplay.Source = Path;
        }
    }
}