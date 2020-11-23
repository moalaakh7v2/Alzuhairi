using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlzuhairiMobile.Services
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get { return CrossSettings.Current; }
        }
        

        private const string StudentIdKey = "StudentId_key";
        private static readonly string studentId = string.Empty;
        public static string StudentId
        {
            get { return AppSettings.GetValueOrDefault(StudentIdKey, studentId); }
            set { AppSettings.AddOrUpdateValue(StudentIdKey, value); }
        }

        private const string StudentPhoneKey = "StudentPhone_key";
        private static readonly string studentPhone = string.Empty;
        public static string StudentPhone
        {
            get { return AppSettings.GetValueOrDefault(StudentPhoneKey, studentPhone); }
            set { AppSettings.AddOrUpdateValue(StudentPhoneKey, value); }
        }

        private const string RegisterNoteBookKey = "RegisterNoteBook_key";
        private static readonly string registerNoteBook = string.Empty;
        public static string RegisterNoteBook
        {
            get { return AppSettings.GetValueOrDefault(RegisterNoteBookKey, registerNoteBook); }
            set { AppSettings.AddOrUpdateValue(RegisterNoteBookKey, value); }
        }

        private const string NoteBookFeatureKey = "NoteBookFeature_key";
        private static readonly string noteBookFeature = string.Empty;
        public static string NoteBookFeature
        {
            get { return AppSettings.GetValueOrDefault(NoteBookFeatureKey, noteBookFeature); }
            set { AppSettings.AddOrUpdateValue(NoteBookFeatureKey, value); }
        }

        private const string FirstNameKey = "FirstName_key";
        private static readonly string firstName = string.Empty;
        public static string FirstName
        {
            get { return AppSettings.GetValueOrDefault(FirstNameKey, firstName); }
            set { AppSettings.AddOrUpdateValue(FirstNameKey, value); }
        }

        private const string LastNameKey = "LastName_key";
        private static readonly string lastName = string.Empty;
        public static string LastName
        {
            get { return AppSettings.GetValueOrDefault(LastNameKey, lastName); }
            set { AppSettings.AddOrUpdateValue(LastNameKey, value); }
        }

        private const string LocationKey = "Location_key";
        private static readonly string locationKey = string.Empty;
        public static string Location
        {
            get { return AppSettings.GetValueOrDefault(LocationKey, locationKey); }
            set { AppSettings.AddOrUpdateValue(LocationKey, value); }
        }

        private const string ShcooleKey = "Shcoole_key";
        private static readonly string shcooleKey = string.Empty;
        public static string Shcoole
        {
            get { return AppSettings.GetValueOrDefault(ShcooleKey, ShcooleKey); }
            set { AppSettings.AddOrUpdateValue(ShcooleKey, value); }
        }



    }
    
}
