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
                cbDept.Items.Add(d.deptName);
                cbDeptID.Items.Add(d.deptID);
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

            //populate team id drop-down with values that do not already exist.
            cbTeamID.Items.Clear();
            int[] ids = new int[them.Count];

            for(int i=0; i < them.Count; i++)
            {
                ids[i] = them[i].id;
            }
            for(int i = 1; i < 50; i++)
            {
                if (!ids.Contains(i))
                {
                    cbTeamID.Items.Add(i);
                }
            }
            
            
        }

        //Filter method, when a department is chosen it filters the teams in the team drop-down
        //Fills with teams associated with selected department
        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTeams.Items.Clear();
            Department current = new Department();
            current.deptName = cbDept.SelectedItem.ToString();
            current.deptID = Database.DataRetrievalClass.GetDeptID(current.deptName);
            List<Teams> them = Database.DataRetrievalClass.GetTeams(current.deptID);
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
            here.id= Int32.Parse(cbTeamID.SelectedItem.ToString());
            here.name = txtTeamName.Text;
            
            //Check to see if a team with the same name or id exists. If so, display message and prevent creation.
            if (Database.DataRetrievalClass.TeamExists(Convert.ToInt32(cbTeamID.SelectedValue), txtTeamName.Text))
            {
                MessageBox.Show("The name of this team already exists, please choose another.");
            }
            else
            {
                int dep = Int32.Parse(cbDeptID.SelectedItem.ToString());
                DataRetrievalClass.CreateTeam(here.id, here.name, dep);
                MessageBox.Show( txtTeamName.Text + " successfully created.");
                cbTeamID.Refresh();
                cbDeptID.Refresh();
                txtTeamName.Clear();
            }
        }

        //Deletes a team from the database. Currently does not deal with foreign key constraint entries.
        private void btnDelTeam_Click(object sender, EventArgs e)
        {
            //Retrieve the ID of a team from the database by searching for the selected name in the drop-down.
            int teamID = DataRetrievalClass.GetTeamByName(cbDelTeam.SelectedItem.ToString());
            cbDelTeam.Items.Remove(cbDelTeam.SelectedItem.ToString());
            //Deletes team from database and shows a confirmation message.
            DataRetrievalClass.DeleteTeam(teamID);
            MessageBox.Show(cbDelTeam.SelectedItem + " has been terminated.");

            //Repopulates the drop-down list after removal.
            cbDelTeam.Items.Clear();
            List<Teams> them = Database.DataRetrievalClass.GetTeams();
            foreach (Teams t in them)
            {
                cbDelTeam.Items.Add(t.name);
            }
        }

        //Populates the overview table with values
        private void Form1_Load(object sender, EventArgs e)
        {

            //Fetches previous quarter data from the database and current statuses of projects.
            List<Quarter> times = DataRetrievalClass.GetQuarter();
            string[] status = new string[DataRetrievalClass.CountStatus()];

            //Adds data from previous quarters to the table
            int notStarted = 0;
            int inProgress = 0;
            int complete = 0;
            int delayed = 0;
            int cancelled = 0;

            for (int i = 0; i < DataRetrievalClass.CountStatus(); i++)
            {
                status[i] = DataRetrievalClass.GetStatus(i).ToString();
            }

            dgvOverview.Rows.Add(DateTime.Now.Year, (DateTime.Now.Month / 3), status[0], status[1], status[2], status[3], status[4]);

            foreach(Quarter q in times)
            {
                
                switch (q.statusID)
                {
                    case 1:
                        notStarted++;
                        break;

                    case 2:
                        inProgress++;
                        break;

                    case 3:
                        complete++;
                        break;

                    case 4:
                        delayed++;
                        break;

                    case 5:
                        cancelled++;
                        break;

                    default:
                        break;
                }
            }
            foreach(Quarter q in times)
            {
                dgvOverview.Rows.Add(q.fiscYear.Year, q.fiscQuarter, notStarted, inProgress, complete, delayed, cancelled);
            }

            //Adds current project status to the table.
            
            
        }

        private void dgvOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Details next = new Details();

            next.passedInfo = Int32.Parse(dgvOverview.CurrentCell.Value.ToString());
            next.passedYear = Int32.Parse(dgvOverview.CurrentRow.Cells[0].Value.ToString());
            next.passedQuarter = Int32.Parse(dgvOverview.CurrentRow.Cells[1].Value.ToString());

            next.Show();
        }
    }
}
