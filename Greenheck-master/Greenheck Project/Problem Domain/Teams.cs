using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenheck_Project.Problem_Domain
{
    class Teams
    {
        public int id;
        public string name;

        //Creates a team with passed values
        public Teams(int ident, string who)
        {
            id = ident;
            name = who;
        }

        //Creates an empty Team object
        public Teams() { }
    }
}
