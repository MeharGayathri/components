using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace dbimages
{
    public partial class App : Application
    {
         static Class1 db;
        public static Class1 Db
        {
            get
            {
                if(db==null)
                db = new Class1(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "dbimage.db3"));
                return db;
            }

        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
