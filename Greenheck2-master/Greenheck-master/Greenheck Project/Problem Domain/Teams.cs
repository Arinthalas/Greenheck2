using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenheck_Project.Problem_Domain
{
    class Teams
    {
        public int TeamID;
        public string TeamName;

        //Creates a team with passed values
        public Teams(int ident, string who)
        {
            TeamID = ident;
            TeamName = who;
        }

        //Creates an empty Team object
        public Teams() { }
    }
}
