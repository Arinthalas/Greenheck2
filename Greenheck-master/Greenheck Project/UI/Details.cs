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
using Greenheck_Project.Database;

namespace Greenheck_Project.UI
{
    public partial class Details : Form
    {

        public int passedInfo;
        public int passedYear;
        public int passedQuarter;
        FocusComments editComment;


        public Details()
        {
            InitializeComponent();
        }

        public Details(int year, int quarter, int status)
        {
            InitializeComponent();

            List<FocusComments> list = DataRetrievalClass.GetDetails(year, quarter, status);

            foreach (FocusComments c in list)
            {
                dgvDetail.Rows.Add(DataRetrievalClass.GetProjectName(c.ProjectID), c.StatusID, c.Comments);
            }

        }

        public Details(FocusComments editObject)
        {
            InitializeComponent();
            editComment = editObject;
            List<FocusComments> list = DataRetrievalClass.GetDetails(editObject.FiscalYear, editObject.Quarter, editObject.StatusID);

            foreach (FocusComments c in list)
            {
                dgvDetail.Rows.Add(DataRetrievalClass.GetProjectName(c.ProjectID), c.FocusID, c.Comments);
            }


        }

    private void Details_Load(object sender, EventArgs e)
        {
            List<FocusComments> list = DataRetrievalClass.GetDetails(passedYear, passedQuarter, passedInfo);

            foreach (FocusComments c in list)
            {
                dgvDetail.Rows.Add(DataRetrievalClass.GetProjectName(c.ProjectID), c.StatusID, c.Comments);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            editComment.ProjectID = DataRetrievalClass.GetProjectIDbyName(dgvDetail.CurrentRow.Cells[0].Value.ToString());
            editComment.FocusID = dgvDetail.CurrentRow.Cells[1].Value.ToString();
            editComment.Comments = dgvDetail.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
