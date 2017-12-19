using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenheck_Project.Problem_Domain
{
    class Focus
    {
        private int focusID;
        private string focusName;

        public int FocusID { get => focusID; set => focusID = value; }
        public string FocusName { get => focusName; set => focusName = value; }

        public Focus() { }

        public Focus(int id, string name)
        {
            FocusID = id;
            FocusName = name;
        }
    }
}
