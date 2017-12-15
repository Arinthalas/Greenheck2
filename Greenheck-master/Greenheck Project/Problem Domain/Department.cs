using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenheck_Project.Problem_Domain
{
    class Department
    {
        private string deptName;
        private int deptID;

        public string DeptName { get => deptName; set => deptName = value; }
        public int DeptID { get => deptID; set => deptID = value; }


        //Creates an empty Department
        public Department() { }

        //Creates a Department with passed values.
        public Department(string who, int what)
        {
            DeptName = who;
            DeptID = what;
        }
    }
}
