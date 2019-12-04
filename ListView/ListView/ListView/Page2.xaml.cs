using ListView.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
        public string Name1 { get; set; }
        public string Designation1 { get; set; }
        public string Workson1 { get; set; }
        public string Mentor1 { get; set; }
        public string College1 { get; set; }
        public string EmpId1 { get; set; }
        
        public Page2 ()
		{
			InitializeComponent ();
           // addnew = new Command(Addnewmember);

		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var obj = new TeamList();
            Name1 = name.Text;
            Designation1 = desig.Text;
            EmpId1 = emp.Text;
            College1 = college.Text;
            Mentor1 = men.Text;
            Workson1 = work.Text;
            obj.Addnewmember(Name1, Designation1, EmpId1, College1, Workson1, Mentor1);
        }
    }
}