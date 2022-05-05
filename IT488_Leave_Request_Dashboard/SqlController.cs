using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT488_Leave_Request_Dashboard
{

    class SqlController
    {
        static string connectionString;
        SqlConnection cnn;
        public SqlController()
        {
            connectionString = Globals.sqlConnectionString;
        }

        //Constructor that takes DB connection string
        public SqlController(string conn)
        {
            connectionString = conn;
        }
        
        // SQL Command used to Test SQL Connection
        public bool TestConnection()
        {

            using (cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

        }
        
        #region // SQL Commands to View Requests
        

        // All Employees - Will return all requests that match EmployeeUsername 
        public DataTable GetAllMyRequests()
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "select * from Requests where EmployeeUsername = '" + Globals.VarUsername.ToString() + "';";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // Manager Only - Will return all requests that match ManagerUsername 
        public DataTable GetAllMyEmployeeRequests()
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "select * from Requests where ManagerUsername = '" + Globals.VarUsername.ToString() + "';";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // HR Only - Will return all requests
        public DataTable GetAllRequests()
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "select * from Requests";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        #endregion // End of SQL Commands to View Requests



        #region // SQL Commands to Populate Reports
        public DataTable RequestsByMonthReport()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = string.Format("SELECT FORMAT(CONVERT(datetime,EndDate), 'MMMM') AS Month,COUNT(*) AS 'Requests' FROM [Requests] GROUP BY FORMAT(CONVERT(datetime,EndDate), 'MMMM')");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable RequestsByStatusReport()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = string.Format("SELECT Status,COUNT(*) AS 'Requests' FROM [Requests] GROUP BY Status");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public DataTable RequestsByMonthsdfasdfReport()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = string.Format("SELECT FORMAT(CONVERT(datetime,EndDate), 'MMMM') AS Month,COUNT(*) AS 'Requests' FROM [Requests] GROUP BY FORMAT(CONVERT(datetime,EndDate), 'MMMM')");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable RequestsByMonthssssssReport()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = string.Format("SELECT FORMAT(CONVERT(datetime,EndDate), 'MMMM') AS Month,COUNT(*) AS 'Requests' FROM [Requests] GROUP BY FORMAT(CONVERT(datetime,EndDate), 'MMMM')");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }




        #endregion // SQL Commands to Populate Reports






        //
        // SQL Commands to View Employees
        //

        // Manager Only - Will return all requests that match ManagerUsername 
        public DataTable GetAllMyEmployees()
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "select * from Employees where ManagerUsername = '" + Globals.VarUsername.ToString() + "';";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // HR Only - Will return all requests
        public DataTable GetAllEmployees()
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "select * from Employees";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //
        // End of SQL Commands to View Requests
        //





        // SQL Command to insert a request 
        public bool CreateRequest(string employeeUsername, string type, string status, string startDate, string startHours, string endDate, string endHours, int hours, string requestingSpecificTime, string managerUsername, string comments)
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = string.Format("INSERT \"Requests\"(\"EmployeeUsername\",\"Type\",\"Status\",\"StartDate\",\"StartHours\",\"EndDate\",\"EndHours\",\"Hours\",\"RequestingSpecificTime\",\"ManagerUsername\",\"Comments\") VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}','{9}','{10}')", employeeUsername, type, status, startDate, startHours, endDate, endHours, hours, requestingSpecificTime, managerUsername, comments);
            SqlCommand da = new SqlCommand(sql, cnn);

            try
            {
                da.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }

        public bool UpdateRequest(int requestID, string employeeUsername, string type, string status, string startDate, string startHours, string endDate, string endHours, int hours, string requestingSpecificTime, string managerUsername, string comments)
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = string.Format("Use IT488_Leave_Request_db UPDATE [dbo].[Requests] SET [EmployeeUsername] = '{0}', [Type] = '{1}', [Status] = '{2}', [StartDate] = '{3}', [StartHours] = '{4}', [EndDate] = '{5}', [EndHours] = '{6}', [Hours] = {7}, [RequestingSpecificTime] = '{8}', [ManagerUsername] = '{9}', [Comments] = '{10}' WHERE RequestID = {11}", employeeUsername, type, status, startDate, startHours, endDate, endHours, hours, requestingSpecificTime, managerUsername, comments, requestID);
            SqlCommand da = new SqlCommand(sql,cnn);

            try
            {
                da.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }




        public String GetRole()
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "IF IS_MEMBER ('HR_Role') = 1 PRINT 'true' else PRINT 'false'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            //SqlDataReader dar = new SqlDataReader();

            return da.ToString();
        }

        public bool Check_Role_HR()
        {
            cnn = new SqlConnection(connectionString);
            using (cnn)
            {
                SqlCommand command = new SqlCommand("SELECT IS_MEMBER ('HR_Role')", cnn);
                cnn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string hr_result = reader[0].ToString();

                    if (hr_result == "1")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                return false;
            }
        }

        public bool Check_Role_Manager()
        {
            cnn = new SqlConnection(connectionString);
            using (cnn)
            {
                SqlCommand command = new SqlCommand("SELECT IS_MEMBER ('Manager_Role')", cnn);
                cnn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string hr_result = reader[0].ToString();

                    if (hr_result == "1")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                return false;
            }
        }

        public bool Check_Role_Employee()
        {
            cnn = new SqlConnection(connectionString);
            using (cnn)
            {
                SqlCommand command = new SqlCommand("SELECT IS_MEMBER ('Employee_Role')", cnn);
                cnn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string hr_result = reader[0].ToString();

                    if (hr_result == "1")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                return false;
            }
        }

        public string Check_User()
        {
            cnn = new SqlConnection(connectionString);
            using (cnn)
            {
                SqlCommand command = new SqlCommand("SELECT CURRENT_USER", cnn);
                // ADD EXCEPTION FOR System.Data.SqlClient.SqlException
                cnn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string user_result = reader[0].ToString();
                    return user_result;
                }

                return "Error";

            }
        }




        // Code to be Deleted
        public DataTable GetEmployees()
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "select * from Employees;";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public string GetOrderCount()
        {
            Int32 count = 0;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select count(*) from Orders;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }

        // End of Code to be Deleted

    }
}

