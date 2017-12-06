using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenheck_Project.Problem_Domain
{
    class Status
    {
        private string statusName;
        private int status;

        public string StatusName { get => statusName; set => statusName = value; }

        public int StatusID { get => status; set => status = value; }

        //Creates an empty Project object
        public Status() { }

        //Creates a project with passed values
        public Status(int id, string name)
        {
            status = id;
            statusName = name;
        }
    }
}
