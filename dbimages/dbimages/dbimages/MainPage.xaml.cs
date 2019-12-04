using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace dbimages
{
    public partial class MainPage : ContentPage
    {
        public List<Class2> lis { get; set; }
        public List<string> str { get; set; }
        public MainPage()
        {
            InitializeComponent();
            App.Db.saveClass2(new Class2 { imgsrc="add.png",text="add",content="a"});
            App.Db.saveClass2(new Class2 { imgsrc = "grid.png", text = "grid", content = "a" });
            App.Db.saveClass2(new Class2 { imgsrc = "bg.png", text = "bg", content = "b" });
            App.Db.saveClass2(new Class2 { imgsrc = "add.png", text = "add", content = "b" });
            App.Db.saveClass2(new Class2 { imgsrc = "https://cdn.pixabay.com/photo/2018/10/30/16/06/water-lily-3784022__340.jpg", text = "lilly", content = "frs" });
            lis = App.Db.getClass2List();
            iii.ItemsSource = lis;
            str = new List<string>();
            foreach (var i in lis)
            {
                if(!str.Contains(i.content))
                str.Add(i.content);
            }
            pick.ItemsSource = str;
        }

        private void Pick_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int stri = picker.SelectedIndex;
            string pickedItem = str[stri];
            lis = App.Db.GetContentRecords(pickedItem);
            iii.ItemsSource = lis;
        }
    }
}
