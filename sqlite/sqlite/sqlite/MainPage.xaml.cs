using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using System.IO;

namespace sqlite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"newdb.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<TestTable>();
            DateTime d;
            var item = new TestTable()
            {
                Id = 4,
                Name = "XamarinGuy"

            };

            db.Insert(item);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "newdb.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<TestTable>().Where(a => a.Name.StartsWith("X"));
            foreach (var item in myquery)
            {

                MyLabel.Text =item.Id+" "+item.Name;

            }
        }
    }
}
