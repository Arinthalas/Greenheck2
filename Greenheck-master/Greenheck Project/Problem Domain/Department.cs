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
        private string deptHead;

        public string DeptName { get => deptName; set => deptName = value; }
        public int DeptID { get => deptID; set => deptID = value; }
        public string DeptHead { get => deptHead; set => deptHead = value; }


        //Creates an empty Department
        public Department() { }

        //Creates a Department with passed values.
        public Department(string name, int id, string head)
        {
            DeptName = name;
            DeptID = id;
            DeptHead = head;
        }
    }
}
