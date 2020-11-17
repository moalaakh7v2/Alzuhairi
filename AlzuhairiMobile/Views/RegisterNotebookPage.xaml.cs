using AlzuhairiMobile.Services;
using Library;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace AlzuhairiMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterNotebookPage : ContentPage
    {
        public RegisterNotebookPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!string.IsNullOrEmpty(Settings.NoteBookFeature))
            {
                txtNotebookInfo.Text = Settings.NoteBookFeature;
            }
            else
            {
                txtNotebookInfo.Text = "There are no Notebook registered in your account";
            }
        }
        private void btnGetNew_Clicked(object sender, EventArgs e)
        {
            Scanner();

        }
        public async void Scanner()
        {
            try
            {
             
                var ScannerPage = new ZXingScannerPage();
                
                ScannerPage.OnScanResult += (result) =>
                {
                    ScannerPage.IsScanning = false;
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Navigation.PopModalAsync();
                        SetUP(result.Text);
                    });
                };
                await Navigation.PushModalAsync(ScannerPage);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        async void SetUP(string id)
        {
            try
            {
                Guid serialId = new Guid(id);
                await DisplayAlert("Done", "The code read was successful. Wait a while for the notebook to be registered\n"+serialId.ToString(), "Ok");
                try
                {
                    int studentId = Convert.ToInt32(Settings.StudentId);
                    var noteBookFeatures = CallAPI.PostObjectAndGetObject<StudentNoteBook, List<NoteBookFeature>>(serialId, "SetUpNewNoteBook", studentId.ToString());
                    if (noteBookFeatures.Any())
                    {
                        Settings.RegisterNoteBook = noteBookFeatures[0].NoteBookId.ToString();
                        string Features = noteBookFeatures[0] + "\n\n";
                        foreach (var item in noteBookFeatures)
                            Features += item.Feature.Title + "\n";
                        txtNotebookInfo.Text = Features;
                        Settings.NoteBookFeature = Features;
                    }
                    else
                        txtNotebookInfo.Text = "Done";
                    
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