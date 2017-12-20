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
        //The connection string for the database, should be changed upon implementation at Greenheck
        private const string dbA = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sholm299\Downloads\Greenheck2-master\Greenheck2-master\Greenheck-master\Greenheck Project\Database\Database1.mdf";

        //Gets a connection to the database based on the above connection string and returns an open connection.
        public static SqlConnection GetConn()
        {
            SqlConnection thing = new SqlConnection(dbA);
            thing.Open();
            return thing;
        }

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
                me.id = Convert.ToInt32(lists["TeamID"]);
                me.name = lists["TeamName"].ToString();
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
                me.id = Convert.ToInt32(lists["TeamID"]);
                me.name = lists["TeamName"].ToString();
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

        public static void RemoveTeamFromProjects(int id)
        {
            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "UPDATE ProjectTable SET TeamID = null WHERE TeamID = @param1";
            rem.Parameters.AddWithValue("@param1", id);

            rem.ExecuteNonQuery();

            rem.Connection.Close();
        }

        //Logic test to determine wether a team name or ID already exists in the database
        public static bool TeamExists(string name)
        {
            List<Teams> test = GetTeams();
            bool exist = false;

            foreach(Teams t in test)
            {
                if(t.name == name)
                {
                    exist = true;
                }
            }

            return exist;
        }

        //Adds a new row to the TeamTable in the database based on data passed in through text boxes
        public static void CreateTeam(int id, string name , int dept)
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

        public static void CreateTeam(int id, string name, List<int> departments)
        {
            SqlCommand put = new SqlCommand();
            put.Connection = GetConn();
            put.CommandText = "INSERT INTO TeamTable VALUES(@param1, @param2)";
            put.Parameters.AddWithValue("@param1", id);
            put.Parameters.AddWithValue("@param2", name);

            put.ExecuteNonQuery();

            foreach (int x in departments) {
                CreateDepartmentTeamBridge(id, x + 1);
            }

            put.Connection.Close();
        }

        public static void CreateDepartmentTeamBridge(int id, int department)
        {
            SqlCommand put = new SqlCommand();
            put.Connection = GetConn();

            put.CommandText = "INSERT INTO DepartmentTeamBridge VALUES(@param1, @param2)";
            put.Parameters.AddWithValue("@param1", department);
            put.Parameters.AddWithValue("@param2", id);

            put.ExecuteNonQuery();

            put.Connection.Close();
        }

        //Deletes a team from the databased based on a passed ID.
        public static void DeleteTeam(int id)
        {
            DeleteDepartmentTeamBridgeByTeam(id);
            RemoveTeamFromProjects(id);

            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "DELETE FROM TeamTable WHERE TeamID = @param1";
            rem.Parameters.Add(new SqlParameter("@param1", id));

            rem.ExecuteNonQuery();

            rem.Connection.Close();
        }

        public static void DeleteDepartmentTeamBridgeByTeam(int id)
        {
            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "DELETE FROM DepartmentTeamBridge WHERE TeamID = @param1";
            rem.Parameters.Add(new SqlParameter("@param1", id));

            rem.ExecuteNonQuery();

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
        public static List<Department> GetDepartment()
        {
            List<Department> them = new List<Department>();

            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();
            fetch.CommandText = "SELECT * FROM DepartmentTable";

            SqlDataReader list = fetch.ExecuteReader();

            while (list.Read())
            {
                Department us = new Department();
                us.DeptID = Convert.ToInt32(list["DepartmentID"]);
                us.DeptName = list["DepartmentName"].ToString();
                them.Add(us);
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

        public static bool DepartmentExists(string name)
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT * FROM DepartmentTable WHERE DepartmentName = @param1";
            fetch.Parameters.AddWithValue("@param1", name);

            bool exist = false;

            int rows = fetch.ExecuteNonQuery();
            fetch.Connection.Close();

            if (rows > 0)
            {
                exist = true;
            }

            return exist;
        }

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

        public static void DeleteDepartment(int id)
        {
            DeleteDepartmentTeamBridgeByDepartment(id);

            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "DELETE FROM DepartmentTable WHERE DepartmentID = @param1";
            rem.Parameters.Add(new SqlParameter("@param1", id));

            rem.ExecuteNonQuery();

            rem.Connection.Close();
        }

        public static void DeleteDepartmentTeamBridgeByDepartment(int id)
        {
            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "DELETE FROM DepartmentTeamBridge WHERE DepartmentID = @param1";
            rem.Parameters.Add(new SqlParameter("@param1", id));

            rem.ExecuteNonQuery();

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
            List<Project> projects = new List<Project>();

            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT * FROM ProjectTable";

            SqlDataReader list = fetch.ExecuteReader();

            while (list.Read())
            {
                Project p = new Project(Int32.Parse(list["ProjectID"].ToString()),
                    list["ProjectName"].ToString(),
                    Int32.Parse(list["TeamID"].ToString()), 
                    Int32.Parse(list["CurrentStatus"].ToString()));
                projects.Add(p);
            }

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

        public static int GetProjectIDbyName(string name)
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT ProjectID FROM ProjectTable WHERE ProjectName = @param1";
            fetch.Parameters.AddWithValue("@param1", name);

            int id = Int32.Parse(fetch.ExecuteScalar().ToString());

            return id;
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

        public static void CreateProject(int pid, string pname, int status, int tid, bool[] focus)
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

            for(int i = 0; i < focus.Length; i++)
            {
                if (focus[i])
                {
                    CreateFocusProjectBridge(pid, i+1);
                }
            }
        }

        public static void CreateFocusProjectBridge(int pid, int focus)
        {
            SqlCommand put = new SqlCommand();
            put.Connection = GetConn();

            put.CommandText = "INSERT INTO ProjectFocusBridge VALUES(@param1, @param2)";
            put.Parameters.AddWithValue("@param1", pid);
            put.Parameters.AddWithValue("@param2", focus);

            put.ExecuteNonQuery();

            put.Connection.Close();
        }

        public static void DeleteProject(int id)
        {
            DeleteFromProjectFocusBridge(id);

            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "DELETE FROM ProjectTable WHERE ProjectID = @param1";
            rem.Parameters.Add(new SqlParameter("@param1", id));

            rem.ExecuteNonQuery();

            rem.Connection.Close();   
        }

        public static void DeleteFromProjectFocusBridge(int id)
        {
            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "DELETE FROM ProjectFocusBridge WHERE ProjectID = @param1";
            rem.Parameters.AddWithValue("@param1", id);

            rem.ExecuteNonQuery();
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
                Quarter q = new Quarter();
                q.fiscYear = Convert.ToInt32(list["FiscalYear"]);
                q.fiscQuarter = Convert.ToInt32(list["Quarter"]);
                q.projectID = Convert.ToInt32(list["ProjectID"]);
                q.statusID = Convert.ToInt32(list["StatusID"]);
                q.comments = list["Comments"].ToString();

                quarterList.Add(q);
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

        public static string GetStatusName(int id)
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT StatusName from StatusTable WHERE StatusId = @param1";
            fetch.Parameters.AddWithValue("@param1", id);

            string name = fetch.ExecuteScalar().ToString();

            fetch.Connection.Close();

            return name;
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

        //Logic test to determine wether a Status name or ID already exists in the database
        public static bool StatusExists(string name)
        {
            List<Status> test = GetStatus();
            bool exist = false;

            foreach (Status s in test)
            {
                if (s.StatusName == name)
                {
                    exist = true;
                }
            }

            return exist;
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

        #region Focus Category Methods

        public static void CreateFocus(string name)
        {
            SqlCommand put = new SqlCommand();
            put.Connection = GetConn();

            put.CommandText = "INSERT INTO FocusCategoryTable VALUES(@param1, @param2)";
            put.Parameters.AddWithValue("@param1", GenerateFocusID()+1);
            put.Parameters.AddWithValue("@param2", name);

            put.ExecuteNonQuery();
            put.Connection.Close();

        }

        public static List<Focus> GetFocusCat()
        {
            List<Focus> focusList = new List<Focus>();

            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT * FROM FocusCategoryTable";

            SqlDataReader list = fetch.ExecuteReader();

            while (list.Read())
            {
                Focus current = new Focus(Int32.Parse(list["CategoryID"].ToString()), list["CategoryName"].ToString());
                focusList.Add(current);
            }

            fetch.Connection.Close();

            return focusList;
        }

        public static void DeleteFocus(string name)
        {
            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "DELETE FROM FocusCategoryTable WHERE CategoryName = @param1";
            rem.Parameters.AddWithValue("@param1", name);

            rem.ExecuteNonQuery();

            rem.Connection.Close();
        }

        //Logic test to determine wether a focus name or ID already exists in the database
        public static bool FocusExists(string name)
        {
            List<Focus> test = GetFocusCat();
            bool exist = false;

            foreach (Focus f in test)
            {
                if (f.FocusName == name)
                {
                    exist = true;
                }
            }

            return exist;
        }

        public static int GenerateFocusID()
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT MAX(CategoryID) FROM FocusCategoryTable";

            return Int32.Parse(fetch.ExecuteScalar().ToString());
        }


        #endregion

        #region Focus Comments Methods
        public static List<FocusComments> GetFocusComments()
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

                comments.Add(comment);
            }

            fetch.Connection.Close();

            return comments;
        }

        //public static FocusComments GetFocusComment(int year, int quarter, int projID)
        //{
        //    SqlCommand fetch = new SqlCommand();
        //    fetch.Connection = GetConn();

        //    fetch.CommandText = "SELECT * FROM FocusCommentsTable WHERE FiscalYear = @param1 AND Quarter = @param2 AND ProjectID = @param3";
        //    fetch.Parameters.AddWithValue("@param1", year);
        //    fetch.Parameters.AddWithValue("@param2", quarter);
        //    fetch.Parameters.AddWithValue("@param3", projID);

        //    SqlDataReader item = fetch.ExecuteReader();

        //    FocusComments comment = new FocusComments();

        //    while (item.Read())
        //    {
        //        comment.FiscalYear = Int32.Parse(item["FiscalYear"].ToString());
        //        comment.Quarter = Int32.Parse(item["Quarter"].ToString());
        //        comment.ProjectID = Int32.Parse(item["ProjectID"].ToString());
        //        comment.FocusID = item["FocusID"].ToString();
        //        comment.StatusID = Int32.Parse(item["StatusID"].ToString());
        //        comment.Comments = item["Comments"].ToString();
        //    }

        //    return comment;
        //}

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

        public static void CreateFocusComments(int fiscalyear, int quarter, int projectId, int status, string focus, string comments)
        {
            SqlCommand put = new SqlCommand();
            put.Connection = GetConn();
            put.CommandText = "INSERT INTO FocusCommentsTable VALUES(@param1, @param2, @param3, @param4, @param5, @param6)";
            put.Parameters.AddWithValue("@param1", fiscalyear);
            put.Parameters.AddWithValue("@param2", quarter);
            put.Parameters.AddWithValue("@param3", projectId);
            put.Parameters.AddWithValue("@param4", status);
            put.Parameters.AddWithValue("@param5", focus);
            put.Parameters.AddWithValue("@param6", comments);

            put.ExecuteNonQuery();

            put.Connection.Close();
        }

        public static void UpdateFocusComment(int year, int quarter, int projID, int status, string comment, string focus)
        {
            SqlCommand put = new SqlCommand();
            put.Connection = GetConn();

            put.CommandText = "UPDATE FocusCommentsTable SET StatusID = @param4, FocusID = @param5, Comments = @param6 WHERE " +
                "FiscalYear = @param1 AND Quarter = @param2 AND ProjectID = @param3";
            put.Parameters.AddWithValue("@param1", year);
            put.Parameters.AddWithValue("@param2", quarter);
            put.Parameters.AddWithValue("@param3", projID);
            put.Parameters.AddWithValue("@param4", status);
            put.Parameters.AddWithValue("@param5", focus);
            put.Parameters.AddWithValue("@param6", comment);

            put.ExecuteNonQuery();

            put.Connection.Close();
        }

        public static void DeleteFocusComment(int year, int quarter, int projectID)
        {
            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "DELETE FROM FocusCommentsTable WHERE FiscalYear = @param1 AND Quarter = @param2 AND ProjectID = @param3";
            rem.Parameters.AddWithValue("@param1", year);
            rem.Parameters.AddWithValue("@param2", quarter);
            rem.Parameters.AddWithValue("@param3", projectID);

            rem.ExecuteNonQuery();

            rem.Connection.Close();
        }

        #endregion

        #region Status Methods

        public static void CreateStatus(string name)
        {
            SqlCommand put = new SqlCommand();
            put.Connection = GetConn();

            put.CommandText = "INSERT INTO StatusTable VALUES(@param1, @param2)";
            put.Parameters.AddWithValue("@param1", GenerateStatusID()+1);
            put.Parameters.AddWithValue("@param2", name);

            put.ExecuteNonQuery();

            put.Connection.Close();
        }

        public static void DeleteStatus(string name)
        {
            SqlCommand rem = new SqlCommand();
            rem.Connection = GetConn();

            rem.CommandText = "DELETE FROM StatusTable WHERE StatusName = @param1";
            rem.Parameters.AddWithValue("@param1", name);

            rem.ExecuteNonQuery();

            rem.Connection.Close();
        }

        public static int GenerateStatusID()
        {
            SqlCommand fetch = new SqlCommand();
            fetch.Connection = GetConn();

            fetch.CommandText = "SELECT MAX(StatusID) FROM StatusTable";

            return Int32.Parse(fetch.ExecuteScalar().ToString());
        }

        #endregion


        //Determines the current fiscal year based on the current month.
        public static int GetFiscalYear()
        {
            DateTime when = DateTime.Now;
            int year = when.Year;
            if (when.Month > 9)
            {
                return (year+1);
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

            if(when.Month > 9)
            {
                q = 1;
            }
            else
            {
                if(when.Month > 6)
                {
                    q = 4;
                }
                else
                {
                    if(when.Month > 3)
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
