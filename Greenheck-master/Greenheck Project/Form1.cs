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
        List<Project> project = new List<Project>();
        FocusComments editCommentObject = new FocusComments();

        internal FocusComments EditCommentObject { get => editCommentObject; set => editCommentObject = value; }

        //Populates the overview table with values
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvOverview.AutoGenerateColumns = true;

            //Fetches previous quarter data from the database and current statuses of projects.
            List<Quarter> times = DataRetrievalClass.GetQuarter();
            int[] status = new int[DataRetrievalClass.CountStatus()];

            List<int> years = DataRetrievalClass.GetYears();

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
            }

            foreach(int year in years)
            {
                List<Quarter> qYear = DataRetrievalClass.GetQuarter(year);
                for (int i = 1; i <= DataRetrievalClass.FindQuarter(year); i++)
                {
                    //Adds data from previous quarters to the table
                    int notStarted = 0;
                    int inProgress = 0;
                    int complete = 0;
                    int delayed = 0;
                    int cancelled = 0;

                    foreach (Quarter q in qYear)
                    {
                        if(q.fiscQuarter == i)
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
                            }
                        }
                    }
                    dgvOverview.Rows.Add(year, i, notStarted, inProgress, complete, delayed, cancelled);
                }
            }
        }

        //auto-fills the drop-down boxes with existing data from the database
        private void tabOverview_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears contents from department drop-down then refills, preventing multiple instances
            //of a single entity.
            cbDept.Items.Clear();
            cbDeptID.Items.Clear();
            cbDelDepartment.Items.Clear();
            List<Department> dept = Database.DataRetrievalClass.GetDeptartment();
            foreach (Department d in dept)
            {
                cbDelDepartment.Items.Add(d.DeptName);
                cbDept.Items.Add(d.DeptName);
                cbDeptID.Items.Add(d.DeptID);
            }

            //clears contents from status drop-down then refills, preventing multiple instances
            //of a single entity.
            cbStatus.Items.Clear();
            List<Status> status = Database.DataRetrievalClass.GetStatus();
            foreach (Status s in status)
            {
                cbStatus.Items.Add(s.StatusID);
            }

            //clears contents from delete project and focus project drop-down then refills, preventing multiple instances
            //of a single entity.
            cbDelProject.Items.Clear();
            cbFocusProject.Items.Clear();
            List<Project> projects = Database.DataRetrievalClass.GetProjects();
            foreach (Project p in projects)
            {
                cbDelProject.Items.Add(p.ProjectName);
                cbFocusProject.Items.Add(p.ProjectName);
            }

            //clears contents from teamID drop-down then refills, preventing multiple instances
            //of a single entity.
            cbTeamID.Items.Clear();
            List<Teams> team = Database.DataRetrievalClass.GetTeams();
            foreach (Teams t in team)
            {
                cbTeamID.Items.Add(t.TeamID);
            }

            //same process as above, but for the team drop-down.
            cbTeams.Items.Clear();
            List<Teams> teams = Database.DataRetrievalClass.GetTeams();
            foreach (Teams t in teams)
            {
                cbTeams.Items.Add(t.TeamName);
            }

            cbQuarter.Items.Clear();

            //same process as above, but for the deletion combo box.
            cbDelTeam.Items.Clear();
            foreach (Teams t in teams)
            {
                cbDelTeam.Items.Add(t.TeamName);
            }

            cbFocusYear.Items.Clear();
            cbFocusQuarter.Items.Clear();
            cbFocus.Items.Clear();
            txtFocusComments.Clear();

            focusList = DataRetrievalClass.GetComments();

            if (!cbFocusYear.Items.Contains(DateTime.Now.Year))
            {
                cbFocusYear.Items.Add(DateTime.Now.Year);
            }

            foreach (FocusComments comment in focusList)
            {
                if (!cbFocusYear.Items.Contains(comment.FiscalYear))
                {
                    cbFocusYear.Items.Add(comment.FiscalYear);
                }

                if (!cbFocusQuarter.Items.Contains(comment.Quarter))
                {
                    cbFocusQuarter.Items.Add(comment.Quarter);
                }

                if (!cbFocus.Items.Contains(comment.FocusID))
                {
                    cbFocus.Items.Add(comment.FocusID);
                }

                if (!chkFocus.Items.Contains(comment.FocusID))
                {
                    chkFocus.Items.Add(comment.FocusID);
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
                cbTeams.Items.Add(t.TeamName);
            }
        }

        //Creates a new entry in TeamTable
        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            //Create a new Team object from data provided in the text and combo boxes
            Teams here = new Teams();
            here.TeamID= DataRetrievalClass.GenerateTeamID() +1;
            here.TeamName = txtTeamName.Text;
            
            //Check to see if a team with the same name or id exists. If so, display message and prevent creation.
            if (Database.DataRetrievalClass.TeamExists(txtTeamName.Text))
            {
                MessageBox.Show("The name of this team already exists, please choose another.");
            }
            else
            {
                int dep = Int32.Parse(cbDeptID.SelectedItem.ToString());
                DataRetrievalClass.CreateTeam(here.TeamID, here.TeamName, dep);
                MessageBox.Show( txtTeamName.Text + " successfully created.");
                cbDeptID.Refresh();
                txtTeamName.Clear();
            }
        }

        //Deletes a team from the database. Currently does not deal with foreign key constraint entries.
        private void btnDelTeam_Click(object sender, EventArgs e)
        {

            string message = "Are you sure you want to delete " + cbDelTeam.SelectedItem.ToString() + "?";
            string caption = "Team Deletion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Retrieve the ID of a team from the database by searching for the selected name in the drop-down.
            int teamID = DataRetrievalClass.GetTeamByName(cbDelTeam.SelectedItem.ToString());
            string name = cbDelTeam.SelectedItem.ToString();
            cbDelTeam.Items.Remove(cbDelTeam.SelectedItem.ToString());

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //Deletes project from database and shows a confirmation message.
                DataRetrievalClass.DeleteTeam(teamID);
                MessageBox.Show(name + " has been deleted.");
            }

            //Repopulates the drop-down list after removal.
            cbDelTeam.Items.Clear();
            List<Teams> them = Database.DataRetrievalClass.GetTeams();
            foreach (Teams t in them)
            {
                cbDelTeam.Items.Add(t.TeamName);
            }
        }

        //Creates a new entry in ProjectTable
        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            //Create a new Project object from data provided in the text and combo boxes
            Project project = new Project();
            project.ProjectID = DataRetrievalClass.GenerateProjectID() + 1;
            project.ProjectName = txtProjectName.Text;
            project.TeamID = Convert.ToInt32(cbTeamID.SelectedItem);
            project.Status = Convert.ToInt32(cbStatus.SelectedItem);

            //Check to see if a Project with the same name exists. If so, display message and prevent creation.
            if (Database.DataRetrievalClass.ProjectExists(txtProjectName.Text))
            {
                MessageBox.Show("The name of this project already exists, please choose another.");
            }
            else
            {
                //int dep = Int32.Parse(cbDeptID.SelectedItem.ToString());
                DataRetrievalClass.CreateProject(project.ProjectID, project.ProjectName, project.Status, project.TeamID);
                MessageBox.Show(txtProjectName.Text + " successfully created.");

                txtProjectName.Clear();
            }
        }

        //Deletes a project from the database. Currently does not deal with foreign key constraint entries.
        private void btnDelProject_Click(object sender, EventArgs e)
        {

            string message = "Are you sure you want to delete " + cbDelProject.SelectedItem.ToString() + "?";
            string caption = "Project Deletion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Retrieve the ID of a project from the database by searching for the selected name in the drop-down.
            int projectID = DataRetrievalClass.GetProjectIDbyName(cbDelProject.SelectedItem.ToString());
            string name = cbDelProject.SelectedItem.ToString();
            cbDelProject.Items.Remove(cbDelProject.SelectedItem.ToString());

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //Deletes project from database and shows a confirmation message.
                DataRetrievalClass.DeleteProject(projectID);
                MessageBox.Show(name + " has been deleted.");
            }

            //Repopulates the drop-down list after removal.
            cbDelProject.Items.Clear();
            cbTeamID.Refresh();
            cbStatus.Refresh();

            List<Project> projects = Database.DataRetrievalClass.GetProjects();
            foreach (Project p in projects)
            {
                cbDelProject.Items.Add(p.ProjectName);
            }
        }

        //Creates a new entry in DepartmentTable
        private void btnCreateDepartment_Click(object sender, EventArgs e)
        {
            //Create a new Department object from data provided in the text and combo boxes
            Department department = new Department();
            department.DeptID = DataRetrievalClass.GenerateDepartmentID() + 1;
            department.DeptName = txtDepartmentName.Text;
            department.DeptHead = txtDepartmentHead.Text;

            //Check to see if a department with the same name exists. If so, display message and prevent creation.
            if (Database.DataRetrievalClass.DepartmentExists(txtDepartmentName.Text))
            {
                MessageBox.Show("The name of this department already exists, please choose another.");
            }
            else
            {
                //int dep = Int32.Parse(cbDeptID.SelectedItem.ToString());
                DataRetrievalClass.CreateDepartment(department.DeptID, department.DeptName, department.DeptHead);
                MessageBox.Show(txtDepartmentName.Text + " successfully created.");

                txtDepartmentName.Clear();
                txtDepartmentHead.Clear();
            }
        }

        //Deletes a project from the database. Currently does not deal with foreign key constraint entries.
        private void btnDelDepartment_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete " + cbDelDepartment.SelectedItem.ToString() + "?";
            string caption = "Department Deletion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Retrieve the ID of a department from the database by searching for the selected name in the drop-down.
            int departmentID = DataRetrievalClass.GetDeptID(cbDelDepartment.SelectedItem.ToString());
            string name = cbDelDepartment.SelectedItem.ToString();
            cbDelDepartment.Items.Remove(cbDelDepartment.SelectedItem.ToString());

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //Deletes department from database and shows a confirmation message.
                DataRetrievalClass.DeleteDepartment(departmentID);
                MessageBox.Show(name + " has been deleted.");
            }

            //Repopulates the drop-down list after removal.
            cbDelDepartment.Items.Clear();

            List<Department> departments = Database.DataRetrievalClass.GetDeptartment();
            foreach (Department d in departments)
            {
                cbDelDepartment.Items.Add(d.DeptName);
            }
        }

        private void btnCommAdd_Click(object sender, EventArgs e)
        {
            //    //Create a new Comment object from data provided in the text and combo boxes
            //    FocusComments comments = new FocusComments();
            //    comments.FiscalYear = Convert.ToInt32(cbFocusYear.SelectedIndex);
            //    comments.Quarter = Convert.ToInt32(cbFocusQuarter.SelectedIndex);
            //    comments.ProjectID = Convert.ToInt32(cbFocusProject.SelectedIndex);
            //    comments.FocusID = Convert.ToInt32(cbFocus.SelectedIndex);

            //    //Check to see if a department with the same name exists. If so, display message and prevent creation.
            //    if (Database.DataRetrievalClass.DepartmentExists(txtDepartmentName.Text))
            //    {
            //        MessageBox.Show("The name of this department already exists, please choose another.");
            //    }
            //    else
            //    {
            //        //int dep = Int32.Parse(cbDeptID.SelectedItem.ToString());
            //        DataRetrievalClass.CreateDepartment(comments.DeptID, comments.DeptName, comments.DeptHead);
            //        MessageBox.Show(txtDepartmentName.Text + " successfully created.");

            //        txtDepartmentName.Clear();
            //        txtDepartmentHead.Clear();
            //    }
        }

        //Generates a detailed report of Projects with a given status at a given time
        private void dgvOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOverview.CurrentCell.ColumnIndex > 1)
            {
                Details next = new Details(Int32.Parse(dgvOverview.CurrentRow.Cells[0].Value.ToString()),
                    Int32.Parse(dgvOverview.CurrentRow.Cells[1].Value.ToString()), dgvOverview.CurrentCell.ColumnIndex - 2);

                next.passedInfo = dgvOverview.CurrentCell.ColumnIndex -1;
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
            int selectedYear = Int32.Parse(cbOvrYear.SelectedItem.ToString());
            List<Quarter> selected = DataRetrievalClass.GetQuarter(selectedYear);

            for(int i = 1; i <= DataRetrievalClass.FindQuarter(selectedYear); i++)
            {
                int notStarted = 0;
                int inProgress = 0;
                int complete = 0;
                int delayed = 0;
                int cancelled = 0;

                foreach (Quarter q in selected)
                {
                    if (q.fiscQuarter == i)
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
                        }
                    }
                }
                dgvOverview.Rows.Add(selectedYear, i, notStarted, inProgress, complete, delayed, cancelled);
            }
        }
        //public void GrabItem(FocusComments item)
        //{

        //}
    }
}
