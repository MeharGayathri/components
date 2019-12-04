using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using signature.Droid;
using Android.Widget;
using Xamarin.Forms;


[assembly: Dependency(typeof(StoreData_Android))]
namespace signature.Droid
{
    class StoreData_Android : IStorage
    {
        public string SaveImage(byte[] byteData)
        {
            string path = System.IO.Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, "Signature_" + DateTime.UtcNow.ToBinary().ToString() + ".png");
            File.WriteAllBytes(path, byteData);
            return path;
        }
    }
}