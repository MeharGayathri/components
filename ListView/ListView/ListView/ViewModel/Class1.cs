using ListView.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListView.ViewModel
{
   public class Class1
    {
        static ObservableCollection<Team> TeamList = new ObservableCollection<Team>() { new Team("Aravind", "trainee", "xamarin", "Aravind", "rvr&jc", "2345"),
        new Team("Aravind", "trainee", "xamarin", "Aravind", "pullareddy", "2346"),
        new Team("Gayathri", "trainee", "xamarin", "Aravind", "vignan", "2347"),
        new Team("srinivas", "trainee", "xamarin", "Aravind", "GVP", "2348")    };
        public ObservableCollection<Team> GetTeamList()
        {
            ////TeamList.Add(new Team("Aravind", "trainee", "xamarin", "Aravind", "rvr&jc", "2345"));
            ////TeamList.Add(new Team("Aravind", "trainee", "xamarin", "Aravind", "pullareddy", "2346"));
            ////TeamList.Add(new Team("Gayathri", "trainee", "xamarin", "Aravind", "vignan", "2347"));
            ////TeamList.Add(new Team("srinivas", "trainee", "xamarin", "Aravind", "GVP", "2348"));
            return TeamList;

        }
        public Team AddnewMem(string name,string desig,string empId,string college,string work,string mentor)
        {
           return  new Team(name, desig, empId, college, work, mentor);
        }
    }
}
