﻿using System;
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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        FocusComments editCommentObject = new FocusComments();

        List<FocusComments> focusList = new List<FocusComments>();
        List<Project> projects = new List<Project>();
        List<Status> statusList = new List<Status>();
        List<Focus> focusCatList = new List<Focus>();
        List<Department> dept = new List<Department>();
        List<Teams> teams = new List<Teams>();

        //Populates the overview table with values
        private void Form1_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void FillTable()
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

            foreach (int year in years)
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
                    dgvOverview.Rows.Add(year, i, notStarted, inProgress, complete, delayed, cancelled);
                }

            }
        }

        //auto-fills the drop-down boxes with existing data from the database
        private void tabOverview_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears contents from department drop-down then refills, preventing multiple instances
            //of a single entity.
            cbOvrYear.SelectedItem = null;
            dgvOverview.Rows.Clear();
            FillTable();
            cbDelDepartment.Items.Clear();
            cbTeamID.Items.Clear();
            cbDelTeam.Items.Clear();
            cbFocusYear.Items.Clear();
            cbFocusQuarter.Items.Clear();
            cbFocusProject.Items.Clear();
            cbFocusStatus.Items.Clear();
            cbStatus.Items.Clear();
            cbDelStatus.Items.Clear();
            cbDelFocus.Items.Clear();
            cbDelProject.Items.Clear();
            txtFocusComments.Clear();
            chkFocus.Items.Clear();
            chkAddProjectFocus.Items.Clear();
            chkDepartment.Items.Clear();

            dept = DataRetrievalClass.GetDepartment();
            projects = DataRetrievalClass.GetProjects();
            focusList = DataRetrievalClass.GetFocusComments();
            statusList = DataRetrievalClass.GetStatus();
            focusCatList = DataRetrievalClass.GetFocusCat();
            teams = DataRetrievalClass.GetTeams();


            foreach (Department d in dept)
            {
                cbDelDepartment.Items.Add(d.DeptName);
                chkDepartment.Items.Add(d.DeptName);
            }

            //clears contents from delete project and focus project drop-down then refills, preventing multiple instances
            //of a single entity.
            
            foreach (Teams t in teams)
            {
                cbTeamID.Items.Add(t.name);
                cbDelTeam.Items.Add(t.name);
            }

            if (!cbFocusYear.Items.Contains(DataRetrievalClass.GetFiscalYear()))
            {
                cbFocusYear.Items.Add(DataRetrievalClass.GetFiscalYear());
            }

            foreach(Project p in projects)
            {
                if (!cbFocusProject.Items.Contains(p.ProjectName))
                {
                    cbFocusProject.Items.Add(p.ProjectName);
                    cbDelProject.Items.Add(p.ProjectName);
                }
                
            }

            foreach(Status s in statusList)
            {
                if (!cbFocusStatus.Items.Contains(s.StatusName))
                {
                    cbFocusStatus.Items.Add(s.StatusName);
                    cbStatus.Items.Add(s.StatusName);
                    cbDelStatus.Items.Add(s.StatusName);
                }
                
            }

            foreach(Focus f in focusCatList)
            {
                if (!chkFocus.Items.Contains(f.FocusName))
                {
                    chkFocus.Items.Add(f.FocusName);
                    chkAddProjectFocus.Items.Add(f.FocusName);
                    cbDelFocus.Items.Add(f.FocusName);
                }

            }

            for(int i = 1; i<5; i++)
            {
                cbFocusQuarter.Items.Add(i);
            }

            if (!cbFocusYear.Items.Contains(DataRetrievalClass.GetFiscalYear()))
            {
                cbFocusYear.Items.Add(DataRetrievalClass.GetFiscalYear());
            }
            
            foreach(FocusComments comment in focusList)
            {
                if (!cbFocusYear.Items.Contains(comment.FiscalYear))
                {
                    cbFocusYear.Items.Add(comment.FiscalYear);
                }
            }
        }

        //Creates a new entry in TeamTable
        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            //Create a new Team object from data provided in the text and combo boxes
            Teams t = new Teams();
            t.id= DataRetrievalClass.GenerateTeamID() +1;
            t.name = txtTeamName.Text;
            
            //Check to see if a team with the same name or id exists. If so, display message and prevent creation.
            if (DataRetrievalClass.TeamExists(txtTeamName.Text))
            {
                MessageBox.Show("The name of this team already exists, please choose another.");
            }
            else
            {
                List<int> departments = new List<int>();
                for(int i = 0; i < chkDepartment.Items.Count; i++)
                {
                    if (chkDepartment.GetItemChecked(i))
                    {
                        departments.Add(i);
                    }
                }
                //int dep = Int32.Parse(cbDeptID.SelectedItem.ToString());
                //DataRetrievalClass.CreateTeam(t.id, t.name, dep);
                DataRetrievalClass.CreateTeam(t.id, t.name, departments);
                MessageBox.Show( txtTeamName.Text + " successfully created.");
                txtTeamName.Clear();
                for (int i = 0; i < chkDepartment.Items.Count; i++)
                {
                    chkDepartment.SetItemChecked(i, false);
                }
            }
        }

        //Deletes a team from the database. Currently does not deal with foreign key constraint entries.
        private void btnDelTeam_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to remove " + cbDelTeam.SelectedItem.ToString() + "?";
            string caption = "Team Removal";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Retrieve the ID of a team from the database by searching for the selected name in the drop-down.
            int teamID = DataRetrievalClass.GetTeamByName(cbDelTeam.SelectedItem.ToString());
            string name = cbDelTeam.SelectedItem.ToString();
            cbDelTeam.Items.Remove(cbDelTeam.SelectedItem.ToString());

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                //Deletes team from database and shows a confirmation message.
                DataRetrievalClass.DeleteTeam(teamID);
                MessageBox.Show(name + " has been removed.");
            }

            //Repopulates the drop-down list after removal.
            cbDelTeam.SelectedItem = null;
            

            //List<Project> projects = DataRetrievalClass.GetProjects();
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
                if (dgvOverview.CurrentCell.RowIndex > 0)
                {
                    editCommentObject.FiscalYear = Int32.Parse(dgvOverview.CurrentRow.Cells[0].Value.ToString());
                    editCommentObject.Quarter = Int32.Parse(dgvOverview.CurrentRow.Cells[1].Value.ToString());
                    editCommentObject.StatusID = dgvOverview.CurrentCell.ColumnIndex - 1;

                    Details next = new Details(editCommentObject);

                    next.ShowDialog();

                    if (next.DialogResult == DialogResult.OK)
                    {
                        tabOverview.SelectedIndex = 1;
                        cbFocusYear.SelectedItem = editCommentObject.FiscalYear;
                        cbFocusQuarter.SelectedItem = editCommentObject.Quarter;
                        cbFocusProject.SelectedItem = projects[editCommentObject.ProjectID - 1].ProjectName;
                        cbFocusStatus.SelectedItem = statusList[editCommentObject.StatusID - 1].StatusName;
                        txtFocusComments.Text = editCommentObject.Comments.ToString();
                        string[] focuses = editCommentObject.FocusID.Split(',');
                        for (int i = 0; i < focuses.Length - 1; i++)
                        {
                            focuses[i].Trim();
                            chkFocus.SetItemChecked(Int32.Parse(focuses[i]), true);
                        }
                    }
                }
                else
                {
                    editCommentObject.FiscalYear = Int32.Parse(dgvOverview.CurrentRow.Cells[0].Value.ToString());
                    editCommentObject.Quarter = Int32.Parse(dgvOverview.CurrentRow.Cells[1].Value.ToString());
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvOverview.Rows.Clear();
            if(cbOvrYear.SelectedItem == null)
            {
                FillTable();
            }
            else {

                int selectedYear = Int32.Parse(cbOvrYear.SelectedItem.ToString());
                List<Quarter> selected = DataRetrievalClass.GetQuarter(selectedYear);

                for (int i = 1; i <= DataRetrievalClass.FindQuarter(selectedYear); i++)
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
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            //Create a new Project object from data provided in the text and combo boxes
            Project project = new Project();
            project.ProjectID = DataRetrievalClass.GenerateProjectID() + 1;

            foreach(Teams t in teams)
            {
                if(t.name == cbTeamID.SelectedItem.ToString())
                {
                    project.TeamID = t.id;
                }
            }
            project.ProjectName = txtProjectName.Text;

            foreach(Status s in statusList)
            {
                if(s.StatusName == cbStatus.SelectedItem.ToString())
                {
                    project.Status = s.StatusID;
                }
            }
            bool[] focuscheck = new bool[chkAddProjectFocus.Items.Count];
            for(int i = 0; i < chkAddProjectFocus.Items.Count; i++)
            {
                if (chkAddProjectFocus.GetItemChecked(i))
                {
                    focuscheck[i] = true;
                }
            }

            //Check to see if a Project with the same name exists. If so, display message and prevent creation.
            if (DataRetrievalClass.ProjectExists(txtProjectName.Text))
            {
                MessageBox.Show("The name of this project already exists, please choose another.");
            }
            else
            {
                //int dep = Int32.Parse(cbDeptID.SelectedItem.ToString());
                DataRetrievalClass.CreateProject(project.ProjectID, project.ProjectName, project.Status, project.TeamID, focuscheck);
                MessageBox.Show(txtProjectName.Text + " successfully created.");

                txtProjectName.Clear();
                cbTeamID.SelectedItem = null;
                cbStatus.SelectedItem = null;

                for (int i = 0; i < chkAddProjectFocus.Items.Count; i++)
                {
                    chkAddProjectFocus.SetItemChecked(i, false);
                }
            }
        }

        //Deletes a project from the database. Currently does not deal with foreign key constraint entries.
        private void btnDelProject_Click(object sender, EventArgs e)
        {

            string message = "Are you sure you want to remove " + cbDelProject.SelectedItem.ToString() + "?";
            string caption = "Project Removal";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Retrieve the ID of a project from the database by searching for the selected name in the drop-down.
            int projectID = -1;

            string name = cbDelProject.SelectedItem.ToString();

            foreach(Project p in projects)
            {
                if(p.ProjectName == cbDelProject.SelectedItem.ToString())
                {
                    projectID = p.ProjectID;
                }
            }

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                //Deletes project from database and shows a confirmation message.
                DataRetrievalClass.DeleteProject(projectID);
                MessageBox.Show(name + " has been removed.");
            }

            //Repopulates the drop-down list after removal.
            cbDelProject.SelectedItem = null;
            cbDelProject.Items.Clear();
            cbTeamID.SelectedItem = null;
            cbStatus.SelectedItem = null;

            //List<Project> projects = DataRetrievalClass.GetProjects();
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
            if (DataRetrievalClass.DepartmentExists(txtDepartmentName.Text))
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

        //Deletes a department from the database. Currently does not deal with foreign key constraint entries.
        private void btnDelDepartment_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to remove " + cbDelDepartment.SelectedItem.ToString() + "?";
            string caption = "Department Removal";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Retrieve the ID of a department from the database by searching for the selected name in the drop-down.
            int departmentID = DataRetrievalClass.GetDeptID(cbDelDepartment.SelectedItem.ToString());
            string name = cbDelDepartment.SelectedItem.ToString();
            cbDelDepartment.Items.Remove(cbDelDepartment.SelectedItem.ToString());

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                //Deletes department from database and shows a confirmation message.
                DataRetrievalClass.DeleteDepartment(departmentID);
                MessageBox.Show(name + " has been removed.");
            }

            //Repopulates the drop-down list after removal.
            cbDelDepartment.Items.Clear();

            List<Department> departments = DataRetrievalClass.GetDepartment();
            foreach (Department d in departments)
            {
                cbDelDepartment.Items.Add(d.DeptName);
            }
        }

        private void btnFocusUpdate_Click(object sender, EventArgs e)
        {
            int selectedfocusprojectid = -1;
            int selectedfocusstatusid = -1;
            string selectedfocus = "";

            foreach (Project p in projects)
            {
                if (p.ProjectName == cbFocusProject.SelectedItem.ToString())
                {
                    selectedfocusprojectid = p.ProjectID;
                }
            }

            foreach (Status s in statusList)
            {
                if (s.StatusName == cbFocusStatus.SelectedItem.ToString())
                {
                    selectedfocusstatusid = s.StatusID;
                }
            }

            for (int i = 0; i < chkFocus.Items.Count; i++)
            {
                if (chkFocus.GetItemChecked(i))
                {
                    selectedfocus += i + ", ";
                }
            }

            try
            {
                DataRetrievalClass.UpdateFocusComment(Int32.Parse(cbFocusYear.SelectedItem.ToString()), Int32.Parse(cbFocusQuarter.SelectedItem.ToString()),
                    selectedfocusprojectid, selectedfocusstatusid, txtFocusComments.Text, selectedfocus);
            }

            catch (Exception)
            {
                Console.WriteLine("Something broke");
            }

            finally
            {
                MessageBox.Show("Data successfully updated!");
                cbFocusYear.SelectedItem = null;
                cbFocusStatus.SelectedItem = null;
                cbFocusQuarter.SelectedItem = null;
                cbFocusProject.SelectedItem = null;
                txtFocusComments.Text = "";

                for (int i = 0; i < chkFocus.Items.Count; i++)
                {
                    chkFocus.SetItemChecked(i, false);
                }
            }
        }

        private void btnCommAdd_Click(object sender, EventArgs e)
        {
            int selectedfocusprojectid = -1;
            int selectedfocusstatusid = -1;
            string selectedfocus = "";

            foreach (Project p in projects)
            {
                if (p.ProjectName == cbFocusProject.SelectedItem.ToString())
                {
                    selectedfocusprojectid = p.ProjectID;
                }
            }

            foreach (Status s in statusList)
            {
                if (s.StatusName == cbFocusStatus.SelectedItem.ToString())
                {
                    selectedfocusstatusid = s.StatusID;
                }
            }

            for (int i = 0; i < chkFocus.Items.Count; i++)
            {
                if (chkFocus.GetItemChecked(i))
                {
                    selectedfocus += i + ", ";
                }
            }

            try
            {
                DataRetrievalClass.CreateFocusComments(Int32.Parse(cbFocusYear.SelectedItem.ToString()), Int32.Parse(cbFocusQuarter.SelectedItem.ToString()), selectedfocusprojectid, selectedfocusstatusid, selectedfocus, txtFocusComments.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Something broke");
            }
            finally
            {
                MessageBox.Show("Data entered successfuly.");
                cbFocusYear.SelectedItem = null;
                cbFocusStatus.SelectedItem = null;
                cbFocusQuarter.SelectedItem = null;
                cbFocusProject.SelectedItem = null;
                txtFocusComments.Text = "";

                for (int i = 0; i < chkFocus.Items.Count; i++)
                {
                    chkFocus.SetItemChecked(i, false);
                }
            }
        }

        private void btnDelFocusComment_Click(object sender, EventArgs e)
        {
            int selectedproject = -1;

            foreach (Project p in projects)
            {
                if (p.ProjectName == cbFocusProject.SelectedItem.ToString())
                {
                    selectedproject = p.ProjectID;
                }
            }

            try
            {
                DataRetrievalClass.DeleteFocusComment(Int32.Parse(cbFocusYear.SelectedItem.ToString()), Int32.Parse(cbFocusQuarter.SelectedItem.ToString()), selectedproject);
            }

            catch (Exception)
            {
                Console.WriteLine("Something broke!");
            }

            finally
            {
                MessageBox.Show("Data successfully removed.");
                cbFocusYear.SelectedItem = null;
                cbFocusStatus.SelectedItem = null;
                cbFocusQuarter.SelectedItem = null;
                cbFocusProject.SelectedItem = null;
                txtFocusComments.Text = "";

                for (int i = 0; i < chkFocus.Items.Count; i++)
                {
                    chkFocus.SetItemChecked(i, false);
                }
            }
        }

        private void dgvOverview_MouseHover(object sender, EventArgs e)
        {
            ToolTip trial = new ToolTip();
            trial.ShowAlways = true;
            trial.SetToolTip(dgvOverview, "Clicking on a cell will\nbring up a detailed\nview for the given status\nat the given time.");
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            cbOvrYear.SelectedItem = null;
            dgvOverview.Rows.Clear();
            FillTable();
        }

        private void btnAddStatus_Click(object sender, EventArgs e)
        {
            //Check to see if a Status with the same name exists. If so, display message and prevent creation.
            if (DataRetrievalClass.StatusExists(txtStatusName.Text))
            {
                MessageBox.Show("The name of this status already exists, please choose another.");
            }
            else
            {
                DataRetrievalClass.CreateStatus(txtStatusName.Text);
                MessageBox.Show(txtStatusName.Text + " successfully created.");

                txtStatusName.Clear();
            }
        }

        private void btnAddFocus_Click(object sender, EventArgs e)
        {
            //Check to see if a focus with the same name exists. If so, display message and prevent creation.
            if (DataRetrievalClass.FocusExists(txtFocusName.Text))
            {
                MessageBox.Show("The name of this focus already exists, please choose another.");
            }
            else
            {
                DataRetrievalClass.CreateFocus(txtFocusName.Text);
                MessageBox.Show(txtFocusName.Text + " successfully created.");

                txtFocusName.Clear();
            }
        }

        private void btnDelStatus_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to remove " + cbDelStatus.SelectedItem.ToString() + "?";
            string caption = "Status Removal";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Retrieve the ID of a status from the database by searching for the selected name in the drop-down.
            string name = cbDelStatus.SelectedItem.ToString();
            cbDelStatus.Items.Remove(cbDelStatus.SelectedItem.ToString());

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                //Deletes status from database and shows a confirmation message.
                DataRetrievalClass.DeleteStatus(name);
                MessageBox.Show(name + " has been removed.");
            }

            //Repopulates the drop-down list after removal.
            cbDelStatus.Items.Clear();

            List<Status> status = DataRetrievalClass.GetStatus();
            foreach (Status s in status)
            {
                cbDelStatus.Items.Add(s.StatusName);
            }
        }

        private void btnDelFocus_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to remove " + cbDelFocus.SelectedItem.ToString() + "?";
            string caption = "Focus Removal";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Retrieve the ID of a focus from the database by searching for the selected name in the drop-down.
            string name = cbDelFocus.SelectedItem.ToString();
            cbDelFocus.Items.Remove(cbDelFocus.SelectedItem.ToString());

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                //Deletes status from database and shows a confirmation message.
                DataRetrievalClass.DeleteFocus(name);
                MessageBox.Show(name + " has been removed.");
            }

            //Repopulates the drop-down list after removal.
            cbDelFocus.Items.Clear();

            List<Focus> focus = DataRetrievalClass.GetFocusCat();
            foreach (Focus f in focus)
            {
                cbDelFocus.Items.Add(f.FocusName);
            }
        }
    }
}
