using System;
using System.Collections.Generic;
using System.Text;

namespace ListView.Model
{
    public class Team
    {
        string name;
        string designation;
        string workson;
        string mentor;
        string college;
        string empId;
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Workson { get; set; }
        public string Mentor { get; set; }
        public string College { get; set; }
        public string EmpId { get; set; }
        public Team(string name, string designation, string workson, string mentor, string college, string empId)
        {
            Name = name;
         Designation = designation;
            Mentor = mentor;
            Workson = workson;
            College = college;
            EmpId = empId;
        }
    }

}
