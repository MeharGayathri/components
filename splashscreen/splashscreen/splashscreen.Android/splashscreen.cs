using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace splashscreen.Droid
{
    [Activity(Label = "splashscreen", Icon = "@mipmap/icon", Theme = "@style/splashthene", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class splashscreen:Activity
    {
        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            StartActivity(typeof(MainActivity));
            Finish();
            OverridePendingTransition(0,0);
        }
    }
}