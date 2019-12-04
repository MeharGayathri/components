using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using sqlite.Interfaces;
using SQLite;

namespace sqlite.Droid.Implementation
{
   public class sqlite_android:Isqlite
    {
        public SQLiteConnection sqlConnection()
        {
            throw new NotImplementedException();
        }
    }
}