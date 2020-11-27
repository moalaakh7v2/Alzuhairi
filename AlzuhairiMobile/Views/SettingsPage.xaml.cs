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

namespace AlzuhairiMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                txtFname.Text = Settings.FirstName;
                txtLname.Text = Settings.LastName;
                txtLocation.Text = Settings.Location;
            }
            catch(Exception ex)
            {
                DisplayAlert("خطأ", ex.Message, "خروج");
            }
           
        }

        private void btnReset_Clicked(object sender, EventArgs e)
        {
            txtFname.Text = txtLname.Text = txtLocation.Text = "";
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            if (!CheckData())
                return;
            try
            {
                Student student = CallAPI.GetObjectContent<Student, Student>("GetStudentByNumber", Settings.StudentPhone);
                student.FirstName = txtFname.Text;
                student.LastName = txtLname.Text;
                student.Address = txtLocation.Text;
                student = CallAPI.PostObjectAndGetObject<Student, Student>(student, "UpdateStudent", Settings.StudentId);
                if (student != null)
                {
                    Settings.FirstName = student.FirstName;
                    Settings.LastName = student.LastName;
                    Settings.Location = student.Address;
                    await DisplayAlert("تم", "تمت العملية بنجاح", "موافق");
                }
                else
                    await DisplayAlert("خطأ", "فشلت المهمة", "خروج");
            }
           catch(Exception ex)
            {
                await DisplayAlert("خطأ", ex.Message, "خروج");
            }

        }

        bool CheckData()
        {
            if (string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtFname.Text))
            {
                DisplayAlert("خطأ", "يرجى إدخال كافة البيانات", "خروج");
                return false;
            }
            if (txtFname.Text == Settings.FirstName && txtLname.Text == Settings.LastName && txtLocation.Text == Settings.Location)
            {
                DisplayAlert("خطأ", "يم يتم تغير أي نوع من المعلومات", "خروج");
                return false;
            }
            return true;
        }
    }
}