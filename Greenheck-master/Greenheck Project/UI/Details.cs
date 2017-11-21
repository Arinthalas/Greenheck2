using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Greenheck_Project.Problem_Domain;

namespace Greenheck_Project.UI
{
    public partial class Details : Form
    {

        public int passedInfo;
        public int passedYear;
        public int passedQuarter;

        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            List<FocusComments> list = Database.DataRetrievalClass.GetComments();

            foreach(FocusComments c in list)
            {
                if(c.FiscalYear == passedYear && c.Quarter == passedQuarter && c.FocusID == passedInfo)
                {
                    dgvDetail.Rows.Add(c.ProjectID, c.FocusID, c.Comments);
                }
            }
        }
    }
}
