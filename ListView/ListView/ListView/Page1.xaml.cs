using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 (string college,string mentor,string empid)
		{
			InitializeComponent ();
            Workson.Text = college;
            Mentor.Text = mentor;
            EmpId.Text = empid;
		}
	}
}