using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenheck_Project.Problem_Domain
{
    class Project
    {
        private int projectID;
        private string projectName;
        private int teamID;
        private int status;

        public int ProjectID { get => projectID; set => projectID = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
        public int TeamID { get => teamID; set => teamID = value; }
        public int Status { get => status; set => status = value; }

        //Creates an empty Project object
        public Project() { }

        //Creates a project with passed values
        public Project(int id, string name, int team, int stat)
        {
            ProjectID = id;
            ProjectName = name;
            TeamID = team;
            Status = stat;
        }

    }
}
