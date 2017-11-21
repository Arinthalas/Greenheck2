using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenheck_Project.Problem_Domain
{
    class FocusComments
    {
        private int fiscalYear;
        private int quarter;
        private int focusID;
        private int projectID;
        private int statusID;
        private string comments;

        public int FiscalYear { get => fiscalYear; set => fiscalYear = value; }
        public int Quarter { get => quarter; set => quarter = value; }
        public int FocusID { get => focusID; set => focusID = value; }
        public int ProjectID { get => projectID; set => projectID = value; }
        public string Comments { get => comments; set => comments = value; }
        public int StatusID { get => statusID; set => statusID = value; }

        public FocusComments()
        {

        }

        public FocusComments(int year, int q, int focus, int stat, int proj, string comment)
        {
            FiscalYear = year;
            Quarter = q;
            FocusID = focus;
            ProjectID = proj;
            Comments = comment;
            StatusID = stat;
        }
    }
}
