using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using sqllitespecific.Droid.Implementation;
using sqllitespecific.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(android_sqlite))]
namespace sqllitespecific.Droid.Implementation
{
   
    class android_sqlite:Isqlite
    {
        
        public SQLiteConnection sqlConnection()
        {
            var sqliteFilename = "SqliteExample.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);

            // Create the connection
            var conn = new SQLiteConnection(path);

            // Return the database connection
            return conn;
        }
    }
}