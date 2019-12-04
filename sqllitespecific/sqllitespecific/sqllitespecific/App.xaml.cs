using sqllitespecific.Views;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace sqllitespecific
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
           // Task.Run(async () => { await Init(); }).Wait();
            MainPage = new NavigationPage(new OrderPurchaseListPage());
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
