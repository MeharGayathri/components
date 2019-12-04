using ListView.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListView.ViewModel
{
    public class TeamList:INotifyPropertyChanged
    {
        static ObservableCollection<Team> list=new ObservableCollection<Team>();
        public ObservableCollection<Team> newlist = new ObservableCollection<Team>();
        public Class1 obj;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand displayList { get; set; }
       
       
        public TeamList()
        {
             obj = new Class1();
            //List = new List<Team>();
            displayList = new Command<Team>(GettheList,canExecute);
        }

        private bool canExecute(object arg)
        {
            if (List.Count()==0)
            {
                return true;
            }
            else
                return false;
        }

        public ObservableCollection<Team> List { get { return list; }
            set { list = value;
                DetectChange("List");
            } }
        public void GettheList(Team ob)

        {
            newlist = obj.GetTeamList();
            foreach (var objec in newlist)
            {
                List.Add(objec);
            }
            ((Command)displayList).ChangeCanExecute();
        }
        public void DetectChange(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public void Addnewmember(string EmpId1,string Designation1,string Name,string College1,string Workson1,string Mentor1)
        {

            List.Add(obj.AddnewMem(EmpId1,Designation1,Name,College1,Workson1,Mentor1));
            //obj.AddnewMem(EmpId1, Designation1, Name, College1, Workson1, Mentor1);
            //List = obj.GetTeamList();
        }


    }
}
