using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace picker
{
    public partial class MainPage : ContentPage
    {
        public List<Class1> li;
       public MainPage()
        {
            InitializeComponent();
            li = new List<Class1>();
            li.Add(new Class1 { item = "sbfk", check=false });
            li.Add(new Class1 { item = "a", check = false });
            li.Add(new Class1 { item = "sfk", check = false });
            li.Add(new Class1 { item = "sff", check = false });
            //List<string> items = new List<string> { "Xamarin.Forms", "Xamarin.iOS", "Xamarin.Android", "Xamarin Monkeys" };
            //imgMonkey.Source = ImageSource.FromResource("XamarinCustomPopup.images.monkey-MVP.png");
            //imgPopup.Source = ImageSource.FromResource("XamarinCustomPopup.images.xammonkey.png");
            sampleList.ItemsSource = li;
        }

        private void Picker_Focused(object sender, FocusEventArgs e)
        {
            popupListView.IsVisible = true;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            popupListView.IsVisible = true;
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            popupListView.IsVisible = true;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            popupListView.IsVisible = false;
            label.Text = "you selected";
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].check)
                {
                    label.Text = label.Text +" "+ li[i].item;
                }
            }
        }

        private void SampleList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (sender is ListView lv) lv.SelectedItem = null;

        }
    }
}
