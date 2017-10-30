using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenheck_Project.Problem_Domain
{
    class Project
    {
        public int projectID;
        public string projectName;
        public int teamID;
        public int status;

        //Creates an empty Project object
        public Project()
        {

        }

        //Creates a project with passed values
        public Project(int id, string name, int team, int stat)
        {
            projectID = id;
            projectName = name;
            teamID = team;
            status = stat;
        }
    }
}
