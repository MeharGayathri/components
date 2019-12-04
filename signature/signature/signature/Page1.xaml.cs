using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace signature
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        List<ImageSource> newli { get; set; }
		public Page1 ()
		{
			InitializeComponent ();
            newli = new List<ImageSource>();
            var g = App.Db.GetStreams();
            foreach (var i in g)
            {
                Stream stream = new MemoryStream(i.stream);
                var imageSource = ImageSource.FromStream(()=>stream);
                newli.Add(imageSource);
            }
            liview.ItemsSource = newli;
		}
	}
}