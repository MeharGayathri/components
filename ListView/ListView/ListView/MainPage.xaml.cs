using ListView.Model;
using ListView.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace ListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new TeamList();
            
            //var obj = new TeamList();
            //listview.ItemsSource = obj.meth();
        }

        private void Listview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var remainDetails = e.Item as Team;
            Navigation.PushAsync(new Page1(remainDetails.Workson,remainDetails.Mentor,remainDetails.EmpId));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
