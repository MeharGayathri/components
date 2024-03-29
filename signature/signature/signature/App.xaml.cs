﻿using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace signature
{
    public partial class App : Application
    {
        static Class2 db;
        public static Class2 Db
        {
            get
            {
                if (db == null)
                    db = new Class2(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "signatu.db3"));
                return db;
            }

        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
