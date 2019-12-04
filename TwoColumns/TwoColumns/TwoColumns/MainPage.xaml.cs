using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TwoColumns
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ModelView();
        }

        

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
           await DisplayAlert("alert","msg","ok");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("alert2","message","cancel");
        }
    }
}
