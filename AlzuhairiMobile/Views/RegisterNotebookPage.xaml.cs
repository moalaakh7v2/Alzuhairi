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
                txtNotebookInfo.Text = "لايوجد أي نوطة , قم بتصوير الكود في أول صفحة من النوطة لحفظها في الهاتف الخاص بك";
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
                await DisplayAlert("خطأ", ex.Message, "موافق");
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
                        Settings.RegisterNoteBook = noteBookFeatures.First().NoteBookId.ToString();
                        string Features = noteBookFeatures.First().Feature.Title + "\n\n";
                        foreach (var item in noteBookFeatures.Where(x=>x.Id != 1))
                            Features += item.Feature.Title + "\n";
                        Settings.NoteBookFeature = Features;
                        txtNotebookInfo.Text = Features;
                    }
                    else
                    {
                        txtNotebookInfo.Text = "تمت العملية بنجاح";
                    }
                       
                    
                }
                catch (Exception ex)
                {
                     DisplayAlert("خطأ", ex.Message, "موافق");
                }
            }
            catch
            {
                 DisplayAlert("خطأ", "خطأ في قراءة الكود", "موافق");
            }
        }
        
    }
}