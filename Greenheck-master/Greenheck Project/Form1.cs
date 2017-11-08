using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Greenheck_Project.Database;
using Greenheck_Project.Problem_Domain;
using Greenheck_Project.UI;

namespace Greenheck_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<FocusComments> focusList = new List<FocusComments>();

        //Populates the overview table with values
        private void Form1_Load(object sender, EventArgs e)
        {

            //Fetches previous quarter data from the database and current statuses of projects.
            List<Quarter> times = DataRetrievalClass.GetQuarter();
            int[] status = new int[DataRetrievalClass.CountStatus()];

            ////Adds data from previous quarters to the table
            //int notStarted = 0;
            //int inProgress = 0;
            //int complete = 0;
            //int delayed = 0;
            //int cancelled = 0;

            for (int i = 0; i < status.Length; i++)
            {
                status[i] = DataRetrievalClass.GetStatus(i);
            }

            dgvOverview.Rows.Add(DataRetrievalClass.GetFiscalYear(), DataRetrievalClass.GetFiscalQuarter(), 
                                                    status[0], status[1], status[2], status[3], status[4]);
            cbOvrYear.Items.Add(DataRetrievalClass.GetFiscalYear());

            foreach (Quarter q in times)
            {
                if (!cbOvrYear.Items.Contains(q.fiscYear))
                {
                    cbOvrYear.Items.Add(q.fiscYear);
                }

                //if (Int32.Parse(dgvOverview.Rows.ToString()) != q.fiscYear)
                //{
                //    dgvOverview.Rows.Add(q.fiscYear, q.fiscQuarter, notStarted, inProgress, complete, delayed, cancelled);
                //}
                //dgvOverview.Rows.Add(q.fiscYear, q.fiscQuarter, notStarted, inProgress, complete, delayed, cancelled);
            }

            //Adds current project status to the table.


        }

        //auto-fills the drop-down boxes with existing data from the database
        private void tabOverview_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears contents from department drop-down then refills, preventing multiple instances
            //of a single entity.
            cbDept.Items.Clear();
            cbDeptID.Items.Clear();
            List<Department> dept = Database.DataRetrievalClass.GetDept();
            foreach (Department d in dept)
            {
                cbDept.Items.Add(d.DeptName);
                cbDeptID.Items.Add(d.DeptID);
            }


            //same process as above, but for the team drop-down.
            cbTeams.Items.Clear();
            List<Teams> them = Database.DataRetrievalClass.GetTeams();
            foreach (Teams t in them)
            {
                cbTeams.Items.Add(t.name);
            }

            cbQuarter.Items.Clear();

            //same process as above, but for the deletion combo box.
            cbDelTeam.Items.Clear();
            foreach (Teams t in them)
            {
                cbDelTeam.Items.Add(t.name);
            }

            cbFocusYear.Items.Clear();
            cbFocusQuarter.Items.Clear();
            cbFocusProject.Items.Clear();
            cbFocus.Items.Clear();
            txtFocusComments.Clear();

           

            focusList = DataRetrievalClass.GetComments();

            if (!cbFocusYear.Items.Contains(DateTime.Now.Year))
            {
                cbFocusYear.Items.Add(DateTime.Now.Year);
            }
            
            foreach(FocusComments comment in focusList)
            {
                if (!cbFocusYear.Items.Contains(comment.FiscalYear.Year))
                {
                    cbFocusYear.Items.Add(comment.FiscalYear.Year);
                }

                if (!cbFocusProject.Items.Contains(comment.ProjectID))
                {
                    cbFocusProject.Items.Add(comment.ProjectID);
                }

                if (!cbFocusQuarter.Items.Contains(comment.Quarter))
                {
                    cbFocusQuarter.Items.Add(comment.Quarter);
                }

            }
        }

        //Filter method, when a department is chosen it filters the teams in the team drop-down
        //Fills with teams associated with selected department
        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTeams.Items.Clear();
            Department current = new Department();
            current.DeptName = cbDept.SelectedItem.ToString();
            current.DeptID = Database.DataRetrievalClass.GetDeptID(current.DeptName);
            List<Teams> them = Database.DataRetrievalClass.GetTeams(current.DeptID);
            foreach (Teams t in them)
            {
                cbTeams.Items.Add(t.name);
            }
        }

        //Creates a new entry in TeamTable
        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            //Create a new Team object from data provided in the text and combo boxes
            Teams here = new Teams();
            here.id= DataRetrievalClass.GenerateTeamID() +1;
            here.name = txtTeamName.Text;
            
            //Check to see if a team with the same name or id exists. If so, display message and prevent creation.
            if (Database.DataRetrievalClass.TeamExists(txtTeamName.Text))
            {
                MessageBox.Show("The name of this team already exists, please choose another.");
            }
            else
            {
                int dep = Int32.Parse(cbDeptID.SelectedItem.ToString());
                DataRetrievalClass.CreateTeam(here.id, here.name, dep);
                MessageBox.Show( txtTeamName.Text + " successfully created.");
                cbDeptID.Refresh();
                txtTeamName.Clear();
            }
        }

        //Deletes a team from the database. Currently does not deal with foreign key constraint entries.
        private void btnDelTeam_Click(object sender, EventArgs e)
        {
            //Retrieve the ID of a team from the database by searching for the selected name in the drop-down.
            int teamID = DataRetrievalClass.GetTeamByName(cbDelTeam.SelectedItem.ToString());
            string name = cbDelTeam.SelectedItem.ToString();
            cbDelTeam.Items.Remove(cbDelTeam.SelectedItem.ToString());
            //Deletes team from database and shows a confirmation message.
            DataRetrievalClass.DeleteTeam(teamID);
            MessageBox.Show(name + " has been terminated.");

            //Repopulates the drop-down list after removal.
            cbDelTeam.Items.Clear();
            List<Teams> them = Database.DataRetrievalClass.GetTeams();
            foreach (Teams t in them)
            {
                cbDelTeam.Items.Add(t.name);
            }
        }

        //Generates a detailed report of Projects with a given status at a given time
        private void dgvOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOverview.CurrentCell.ColumnIndex > 1)
            {
                Details next = new Details();

                next.passedInfo = Int32.Parse(dgvOverview.CurrentCell.Value.ToString());
                next.passedYear = Int32.Parse(dgvOverview.CurrentRow.Cells[0].Value.ToString());
                next.passedQuarter = Int32.Parse(dgvOverview.CurrentRow.Cells[1].Value.ToString());

                next.Show();
            }
        }

        private void cbFocusYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvOverview.Rows.Clear();
            List<Quarter> selected = new List<Quarter>();

            //selected = DataRetrievalClass.
        }
    }
}
