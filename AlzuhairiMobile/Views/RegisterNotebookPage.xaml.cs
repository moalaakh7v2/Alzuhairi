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
            //اذا كان يمتلك نوطة في اعداداته
            if (!string.IsNullOrEmpty(Settings.RegisterNoteBook))
            {
                //عرض عنوان النوطة والميزات التي حصل عليها
                txtNotebookInfo.Text = Settings.NoteBookFeature;
            }
            else
            {
                txtNotebookInfo.Text = "There is no Notebook. Scan the code on the first page in the notebook to save it in your application";
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

                ZXingScannerPage ScannerPage = new ZXingScannerPage();
                
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

        void SetUP(string serialIdtext)
        {
            try
            {
                Guid serialId = new Guid(serialIdtext);
                try
                {
                    int studentId = Convert.ToInt32(Settings.StudentId);
                    List<NoteBookFeature> noteBookFeatures = CallAPI.PostObjectAndGetObject<StudentNoteBook, List<NoteBookFeature>>
                                                             (serialId, "SetUpNewNoteBook", studentId.ToString());
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
                     DisplayAlert("Error", ex.Message, "Ok");
                }
            }
            catch
            {
                 DisplayAlert("Error", "Wrong QR code", "Ok");
            }
        }
        
    }
}