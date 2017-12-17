using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Greenheck_Project.Problem_Domain;

namespace Greenheck_Project.Database
{
    class DataRetrievalClass
    {
        #region Connection String

        //The connection string for the database, should be changed upon implementation at Greenheck
        private const string dbA = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tleac021\Downloads\Greenheck2-master\Greenheck2-master\Greenheck-master\Greenheck Project\Database\Database1.mdf";

        //Gets a connection to the database based on the above connection string and returns an open connection.
        public static SqlConnection GetConn()
        {
            SqlConnection thing = new SqlConnection(dbA);
            thing.Open();
            return thing;
        }

        #endregion

        #region Team Methods
        //Fetches all the teams from the database and returns them in a list.
        public static List<Teams> GetTeams()
        {
            //List to be returned
            List<Teams> them = new List<Teams>();

            //Defines SQL command
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();
            fetch.CommandText = "Select * FROM TeamTable";

            SqlDataReader lists = fetch.ExecuteReader();

            //Creates team objects, adds data to them and adds the object to the list while data
            //can still be retrieved from the database
            while (lists.Read())
            {
                Teams me = new Teams();
                me.TeamID = Convert.ToInt32(lists["TeamID"]);
                me.TeamName = lists["TeamName"].ToString();
                them.Add(me);
            }

            fetch.Connection.Close();

            return them;
        }

        //Gets teams filtered by department
        public static List<Teams> GetTeams(int depID)
        {

            List<Teams> them = new List<Teams>();

            //Defines the SQL command
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();
            fetch.CommandText = "SELECT TeamName, TeamID FROM TeamTable WHERE DeptID = @param1";
            fetch.Parameters.AddWithValue("@param1", depID);

            SqlDataReader lists = fetch.ExecuteReader();

            while (lists.Read())
            {
                Teams me = new Teams();
                me.TeamID = Convert.ToInt32(lists["TeamID"]);
                me.TeamName = lists["TeamName"].ToString();
                them.Add(me);
            }

            fetch.Connection.Close();

            return them;
        }

        //Fetches and returns a team ID based on a selected name
        public static int GetTeamByName(string name)
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT TeamId FROM TeamTable WHERE TeamName = @param1";
            fetch.Parameters.AddWithValue("@param1", name);

            int id = Convert.ToInt32(fetch.ExecuteScalar());

            fetch.Connection.Close();

            return id;
        }

        public static string GetTeamsByID(int id)
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT TeamName FROM TeamTable WHERE TeamID = @param1";
            fetch.Parameters.AddWithValue("@param1", id);

            string name = fetch.ExecuteScalar().ToString();
            return name;
        }

        //Logic test to determine wether a team name or ID already exists in the database
        public static bool TeamExists(string name)
        {
            List<Teams> test = GetTeams();
            bool exist = false;

            foreach (Teams t in test)
            {
                if (t.TeamName == name)
                {
                    exist = true;
                }
            }

            return exist;
        }

        //Adds a new row to the TeamTable in the database based on data passed in through text boxes
        public static void CreateTeam(int id, string name, int dept)
        {
            SqlCommand put = new SqlCommand();
            put.Connection = GetConn();
            put.CommandText = "INSERT INTO TeamTable VALUES(@param1, @param2, @param3)";
            put.Parameters.AddWithValue("@param1", id);
            put.Parameters.AddWithValue("@param2", name);
            put.Parameters.AddWithValue("@param3", dept);

            put.ExecuteNonQuery();

            put.Connection.Close();
        }

        //Deletes a team from the databased based on a passed ID.
        public static void DeleteTeam(int id)
        {
            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "DELETE FROM TeamTable WHERE TeamID = @param1";
            rem.Parameters.Add(new SqlParameter("@param1", id));

            rem.ExecuteNonQuery();

            rem.CommandText = "DELETE FROM DeptartmentTeamBridge WHERE TeamID = @param1";

            rem.Connection.Close();
        }

        public static int GenerateTeamID()
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT MAX(TeamID) FROM TeamTable";

            return Int32.Parse(fetch.ExecuteScalar().ToString());
        }

        #endregion

        #region Department Methods
        //Fetches Department data from the database and returns it in a list
        public static List<Department> GetDeptartment()
        {
            List<Department> them = new List<Department>();

            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();
            fetch.CommandText = "SELECT * FROM DepartmentTable";

            SqlDataReader list = fetch.ExecuteReader();

            while (list.Read())
            {
                Department department = new Department();
                department.DeptID = Convert.ToInt32(list["DepartmentID"]);
                department.DeptName = list["DepartmentName"].ToString();
                department.DeptHead = list["DepartmentHead"].ToString();

                them.Add(department);
            }

            fetch.Connection.Close();

            return them;
        }

        //Fetches the ID of a specified department.
        public static int GetDeptID(string name)
        {
            List<Department> them = new List<Department>();

            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();
            fetch.CommandText = "SELECT DepartmentID FROM DepartmentTable WHERE DepartmentName = @param1";
            fetch.Parameters.AddWithValue("@param1", name);

            SqlDataReader list = fetch.ExecuteReader();

            while (list.Read())
            {
                Department us = new Department();
                us.DeptID = Convert.ToInt32(list["DepartmentID"]);
                them.Add(us);
            }
            fetch.Connection.Close();

            return them[0].DeptID;
        }

        public static string GetDepartmentByID(int id)
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT DepartmentName FROM DepartmentTable WHERE DepartmentID = @param1";
            fetch.Parameters.AddWithValue("@param1", id);

            string name = fetch.ExecuteScalar().ToString();
            return name;
        }

        //Logic test to determine wether a department name or id already exists in the database
        public static bool DepartmentExists(string name)
        {
            List<Department> test = GetDeptartment();
            bool exist = false;

            foreach (Department d in test)
            {
                if (d.DeptName == name)
                {
                    exist = true;
                }
            }

            return exist;
        }

        //Adds a new row to the DepartmentTable in the database based on data passed in through text boxes
        public static void CreateDepartment(int id, string name, string head)
        {
            SqlCommand put = new SqlCommand();
            put.Connection = GetConn();
            put.CommandText = "INSERT INTO DepartmentTable VALUES(@param1, @param2, @param3)";
            put.Parameters.AddWithValue("@param1", id);
            put.Parameters.AddWithValue("@param2", name);
            put.Parameters.AddWithValue("@param3", head);

            put.ExecuteNonQuery();

            put.Connection.Close();
        }

        //Deletes a department from the databased based on a passed ID.
        public static void DeleteDepartment(int id)
        {
            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "DELETE FROM DepartmentTable WHERE DepartmentID = @param1";
            rem.Parameters.Add(new SqlParameter("@param1", id));

            rem.ExecuteNonQuery();

            rem.CommandText = "DELETE FROM DeptartmentTeamBridge WHERE DepartmentID = @param1";

            rem.Connection.Close();
        }

        public static int GenerateDepartmentID()
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT MAX(DepartmentID) FROM DepartmentTable";

            return Int32.Parse(fetch.ExecuteScalar().ToString());
        }

        #endregion

        #region Project Methods

        public static List<Project> GetProjects()
        {
            //List to be returned
            List<Project> projects = new List<Project>();

            //Defines SQL command
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();
            fetch.CommandText = "Select * FROM ProjectTable";

            SqlDataReader lists = fetch.ExecuteReader();

            //Creates project objects, adds data to them and adds the object to the list while data
            //can still be retrieved from the database
            while (lists.Read())
            {
                Project project = new Project();
                project.ProjectID = Convert.ToInt32(lists["ProjectID"]);
                project.ProjectName = lists["ProjectName"].ToString();
                project.Status = Convert.ToInt32(lists["CurrentStatus"]);
                project.TeamID = Convert.ToInt32(lists["TeamID"]);
                projects.Add(project);
            }

            fetch.Connection.Close();

            return projects;
        }

        public static string GetProjectName(int id)
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT ProjectName FROM ProjectTable WHERE ProjectID = @param1";
            fetch.Parameters.AddWithValue("@param1", id);

            string result = fetch.ExecuteScalar().ToString();

            return result;
        }

        //Fetches the ID of a specified project.
        public static int GetProjectIDbyName(string name)
        {
            List<Project> projects = new List<Project>();

            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();
            fetch.CommandText = "SELECT ProjectID FROM ProjectTable WHERE ProjectName = @param1";
            fetch.Parameters.AddWithValue("@param1", name);

            SqlDataReader list = fetch.ExecuteReader();

            while (list.Read())
            {
                Project project = new Project();
                project.ProjectID = Convert.ToInt32(list["ProjectID"]);
                projects.Add(project);
            }
            fetch.Connection.Close();

            return projects[0].ProjectID;
        }

        //Logic test to determine wether a project name or id already exists in the database
        public static bool ProjectExists(string name)
        {
            List<Project> test = GetProjects();
            bool exist = false;

            foreach (Project p in test)
            {
                if (p.ProjectName == name)
                {
                    exist = true;
                }
            }

            return exist;
        }

        //Adds a new row to the ProjectTable in the database based on data passed in through text boxes and combo boxes
        public static void CreateProject(int pid, string pname, int status, int tid)
        {
            SqlCommand put = new SqlCommand();
            put.Connection = GetConn();
            put.CommandText = "INSERT INTO ProjectTable VALUES(@param1, @param2, @param3, @param4)";
            put.Parameters.AddWithValue("@param1", pid);
            put.Parameters.AddWithValue("@param2", pname);
            put.Parameters.AddWithValue("@param3", status);
            put.Parameters.AddWithValue("@param4", tid);

            put.ExecuteNonQuery();

            put.Connection.Close();
        }

        //Deletes a project from the database based on a passed ID.
        public static void DeleteProject(int id)
        {
            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "DELETE FROM ProjectTable WHERE ProjectID = @param1";
            rem.Parameters.Add(new SqlParameter("@param1", id));

            rem.ExecuteNonQuery();

            rem.CommandText = "DELETE FROM ProjectFocusBridge WHERE ProjectID = @param1";

            rem.Connection.Close();
        }

        public static int GenerateProjectID()
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT MAX(ProjectID) FROM ProjectTable";

            return Int32.Parse(fetch.ExecuteScalar().ToString());
        }

        #endregion

        #region Quarter Methods

        //Fetches data from previous quarters and returns it as a list.
        public static List<Quarter> GetQuarter()
        {
            List<Quarter> quarterList = new List<Quarter>();
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT FiscalYear, Quarter, ProjectID, StatusID, Comments FROM FocusCommentsTable";

            SqlDataReader list = fetch.ExecuteReader();

            while (list.Read())
            {
                Quarter thus = new Quarter();
                thus.fiscYear = Convert.ToInt32(list["FiscalYear"]);
                thus.fiscQuarter = Convert.ToInt32(list["Quarter"]);
                thus.projectID = Convert.ToInt32(list["ProjectID"]);
                thus.statusID = Convert.ToInt32(list["StatusID"]);
                thus.comments = list["Comments"].ToString();

                quarterList.Add(thus);
            }

            return quarterList;
        }

        public static List<Quarter> GetQuarter(int year)
        {
            List<Quarter> quarterList = new List<Quarter>();
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT FiscalYear, Quarter, ProjectID, StatusID, Comments FROM FocusCommentsTable WHERE FiscalYear = @param1";
            fetch.Parameters.AddWithValue("@param1", year);
            SqlDataReader list = fetch.ExecuteReader();

            while (list.Read())
            {
                Quarter thus = new Quarter();
                thus.fiscYear = Convert.ToInt32(list["FiscalYear"]);
                thus.fiscQuarter = Convert.ToInt32(list["Quarter"]);
                thus.projectID = Convert.ToInt32(list["ProjectID"]);
                thus.statusID = Convert.ToInt32(list["StatusID"]);
                thus.comments = list["Comments"].ToString();

                quarterList.Add(thus);
            }

            return quarterList;
        }

        #endregion

        #region Status Methods

        public static List<Status> GetStatus()
        {
            //List to be returned
            List<Status> statuses = new List<Status>();

            //Defines SQL command
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();
            fetch.CommandText = "Select * FROM StatusTable";

            SqlDataReader lists = fetch.ExecuteReader();

            //Creates team objects, adds data to them and adds the object to the list while data
            //can still be retrieved from the database
            while (lists.Read())
            {
                Status status = new Status();
                status.StatusID = Convert.ToInt32(lists["StatusId"]);
                status.StatusName = lists["StatusName"].ToString();

                statuses.Add(status);
            }
            fetch.Connection.Close();
            return statuses;
        }

        public static void CreateStatus(int id, string name)
        {
            SqlCommand put = new SqlCommand();
            put.Connection = GetConn();
            put.CommandText = "INSERT INTO StatusTable VALUES(@param1, @param2)";
            put.Parameters.AddWithValue("@param1", id);
            put.Parameters.AddWithValue("@param2", name);

            put.ExecuteNonQuery();

            put.Connection.Close();
        }

        //Fetches and returns the number of projects that share a specified status.
        public static int GetStatus(int num)
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT COUNT(ProjectID) FROM ProjectTable WHERE CurrentStatus = @param1";
            fetch.Parameters.AddWithValue("@param1", num);

            int x = Convert.ToInt32(fetch.ExecuteScalar());

            fetch.Connection.Close();

            return x;
        }

        //Counts the number of unique statuses from the StatusTable
        public static int CountStatus()
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT COUNT(StatusID) FROM StatusTable";

            int x = Convert.ToInt32(fetch.ExecuteScalar());

            fetch.Connection.Close();

            return x;
        }

        #endregion

        //public static List<T> GetDetailedStatus()
        //{
        //    List<Teams> teams = new List<Teams>();
        //    List<Project> projects = new List<Project>();
        //    List<Status> status = new List<Status>();

        //    SqlCommand fetch = new SqlCommand();
        //    fetch.Connection = GetConn();

        //    fetch.CommandText = "SELECT T.TeamName, P.ProjectName, S.StatusName FROM TeamTable T, ProjectTable P, StatusTable S WHERE T.TeamID = P.TeamID AND P.StatusID = S.StatusID AND S.StatusID = @param1";

        //    SqlDataReader things = fetch.ExecuteReader();

        //    List<T> data = new List<T>();
        //    while (things.Read())
        //    {
        //        GenClass detail = new GenClass();
        //        detail.status = things["StatusName"].ToString();
        //        detail.project = things["ProjectName"].ToString();
        //        detail.team = things["TeamName"].ToString();
        //        data.Add(detail);
        //    }

        //    return data;
        //}

        //public static List<> GetDetails()
        //{

        //}

        //public static List<Project> GetProject(int year, int quarter, int status)
        //{
        //    List<Project> projects = new List<Project>();

        //    SqlCommand fetch = new SqlCommand();
        //    fetch.Connection = GetConn();

        //    fetch.CommandText = "SELECT * FROM ProjectTable WHERE "
        //}

        public static List<FocusComments> GetComments()
        {
            List<FocusComments> comments = new List<FocusComments>();

            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT * FROM FocusCommentsTable";

            SqlDataReader list = fetch.ExecuteReader();

            while (list.Read())
            {
                FocusComments comment = new FocusComments();
                comment.FiscalYear = Int32.Parse(list["FiscalYear"].ToString());
                comment.Quarter = Int32.Parse(list["Quarter"].ToString());
                comment.ProjectID = Int32.Parse(list["ProjectID"].ToString());
                comment.FocusID = list["FocusID"].ToString();
                comment.Comments = list["Comments"].ToString();
                comment.StatusID = Int32.Parse(list["StatusID"].ToString());

                comments.Add(comment);
            }

            fetch.Connection.Close();

            return comments;
        }

        public static FocusComments GetComment(int year, int quarter, int projID)
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT * FROM FocusCommentsTable WHERE FiscalYear = @param1 AND Quarter = @param2 AND ProjectID = @param3";
            fetch.Parameters.AddWithValue("@param1", year);
            fetch.Parameters.AddWithValue("@param2", quarter);
            fetch.Parameters.AddWithValue("@param3", projID);

            SqlDataReader item = fetch.ExecuteReader();

            FocusComments comment = new FocusComments();

            while (item.Read())
            {
                comment.FiscalYear = Int32.Parse(item["FiscalYear"].ToString());
                comment.Quarter = Int32.Parse(item["Quarter"].ToString());
                comment.ProjectID = Int32.Parse(item["ProjectID"].ToString());
                comment.FocusID = item["FocusID"].ToString();
                comment.StatusID = Int32.Parse(item["StatusID"].ToString());
                comment.Comments = item["Comments"].ToString();
            }

            return comment;
        }

        //Adds a new row to the FocusCommentsTable in the database based on data passed in through text boxes and combo boxes
        public static void CreateComments(int fiscalyear, int quarter, int pid, int sid, string focusid, string comments)
        {
            SqlCommand put = new SqlCommand();
            put.Connection = GetConn();
            put.CommandText = "INSERT INTO FocusCommentsTable VALUES(@param1, @param2, @param3, @param4, @param5, param6)";
            put.Parameters.AddWithValue("@param1", fiscalyear);
            put.Parameters.AddWithValue("@param2", quarter);
            put.Parameters.AddWithValue("@param3", pid);
            put.Parameters.AddWithValue("@param4", sid);
            put.Parameters.AddWithValue("@param6", focusid);
            put.Parameters.AddWithValue("@param6", comments);

            put.ExecuteNonQuery();

            put.Connection.Close();
        }

        public static List<FocusComments> GetDetails(int year, int quarter, int status)
        {
            List<FocusComments> comments = new List<FocusComments>();

            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT * FROM FocusCommentsTable WHERE FiscalYear = @param1 AND Quarter = @param2 AND StatusID = @param3";

            fetch.Parameters.AddWithValue("@param1", year);
            fetch.Parameters.AddWithValue("@param2", quarter);
            fetch.Parameters.AddWithValue("@param3", status);

            SqlDataReader list = fetch.ExecuteReader();

            while (list.Read())
            {
                FocusComments comment = new FocusComments();
                comment.ProjectID = Int32.Parse(list["ProjectID"].ToString());
                comment.FocusID = list["FocusID"].ToString();
                comment.Comments = list["Comments"].ToString();

                comments.Add(comment);
            }

            fetch.Connection.Close();

            return comments;
        }

        //Determines the current fiscal year based on the current month.
        public static int GetFiscalYear()
        {
            DateTime when = DateTime.Now;
            int year = when.Year;
            if (when.Month > 9)
            {
                return (year + 1);
            }
            else
            {
                return year;
            }

        }

        public static List<int> GetYears()
        {
            List<int> years = new List<int>();
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT DISTINCT FiscalYear FROM FocusCommentsTable ORDER BY FiscalYear DESC";

            SqlDataReader reader = fetch.ExecuteReader();

            while (reader.Read())
            {
                int year = Int32.Parse(reader["FiscalYear"].ToString());
                years.Add(year);
            }

            return years;
        }

        public static int FindQuarter(int year)
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT MAX(Quarter) FROM FocusCommentsTable WHERE FiscalYear = @param1";

            fetch.Parameters.AddWithValue("@param1", year);

            return Int32.Parse(fetch.ExecuteScalar().ToString());
        }

        public static int GetFiscalQuarter()
        {
            int q;
            DateTime when = DateTime.Now;

            if (when.Month > 9)
            {
                q = 1;
            }
            else
            {
                if (when.Month > 6)
                {
                    q = 4;
                }
                else
                {
                    if (when.Month > 3)
                    {
                        q = 3;
                    }
                    else
                    {
                        q = 2;
                    }
                }
            }

            return q;
        }
    }
}