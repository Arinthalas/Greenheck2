using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenheck_Project.Problem_Domain
{
    class Department
    {
        public string deptName;
        public int deptID;

        //Creates an empty Department
        public Department() { }

        //Creates a Department with passed values.
        public Department(string who, int what)
        {
            deptName = who;
            deptID = what;
        }
    }
}
