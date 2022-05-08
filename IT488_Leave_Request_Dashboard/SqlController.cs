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

        public DataTable RequestsByTypeReport()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = string.Format("SELECT Type,COUNT(*) AS 'Requests' FROM [Requests] GROUP BY Type");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable RequestsByEmployeeReport()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = string.Format("SELECT EmployeeUsername,COUNT(*) AS 'Requests' FROM [Requests] GROUP BY EmployeeUsername");
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




        public bool BalancesByEmployee()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = string.Format("SELECT t1.EmployeeUsername, COALESCE([LOA Hours Used], 0) AS [LOA Hours Used], COALESCE([Medical Hours Used], 0) AS [Medical Hours Used], COALESCE([PTO Hours Used], 0) AS [PTO Hours Used], COALESCE([LOAScheduled], 0) AS [LOAScheduled], COALESCE([MedicalScheduled], 0) AS [MedicalScheduled], COALESCE([PTOScheduled], 0) AS [PTOScheduled], COALESCE([PTOEarned], 0) AS [PTOEarned], COALESCE([MedicalEarned], 0) AS [MedicalEarned], COALESCE([LOAEarned], 0) AS [LOAEarned] FROM (SELECT EmployeeUsername FROM [Requests] where EmployeeUsername = '{0}' GROUP BY EmployeeUsername) t1  LEFT JOIN (SELECT EmployeeUsername, SUM(Hours) AS 'LOA Hours Used' FROM [Requests] where EmployeeUsername = '{0}' AND Type = 'LOA' AND StartDate <= GETDATE() GROUP BY EmployeeUsername) t2 ON t1.EmployeeUsername = t2.EmployeeUsername LEFT JOIN (SELECT EmployeeUsername, SUM(Hours) AS 'Medical Hours Used' FROM [Requests] where EmployeeUsername = '{0}' AND Type = 'Medical' AND StartDate <= GETDATE() GROUP BY EmployeeUsername) t3 ON t1.EmployeeUsername = t3.EmployeeUsername LEFT JOIN (SELECT EmployeeUsername, SUM(Hours) AS 'PTO Hours Used' FROM [Requests] where EmployeeUsername = '{0}' AND Type = 'PaidTimeOff' AND StartDate <= GETDATE() GROUP BY EmployeeUsername) t4 ON t1.EmployeeUsername = t4.EmployeeUsername LEFT JOIN (SELECT EmployeeUsername, SUM(Hours) AS 'LOAScheduled' FROM [Requests] where EmployeeUsername = '{0}' AND Type = 'LOA' AND StartDate > GETDATE() GROUP BY EmployeeUsername) t5 ON t1.EmployeeUsername = t5.EmployeeUsername LEFT JOIN (SELECT EmployeeUsername, SUM(Hours) AS 'MedicalScheduled' FROM [Requests] where EmployeeUsername = '{0}' AND Type = 'Medical' AND StartDate > GETDATE() GROUP BY EmployeeUsername) t6 ON t1.EmployeeUsername = t6.EmployeeUsername LEFT JOIN (SELECT EmployeeUsername, SUM(Hours) AS 'PTOScheduled' FROM [Requests] where EmployeeUsername = '{0}' AND Type = 'PaidTimeOff' AND StartDate > GETDATE() GROUP BY EmployeeUsername) t7 ON t1.EmployeeUsername = t7.EmployeeUsername LEFT JOIN (SELECT EmployeeUsername, SUM([PaidTimeOff]) AS 'PTOEarned' FROM Employees where EmployeeUsername = '{0}' GROUP BY EmployeeUsername) t8 ON t1.EmployeeUsername = t8.EmployeeUsername LEFT JOIN (SELECT EmployeeUsername, SUM([LOA]) AS 'LOAEarned' FROM Employees where EmployeeUsername = '{0}' GROUP BY EmployeeUsername) t9 ON t1.EmployeeUsername = t9.EmployeeUsername LEFT JOIN (SELECT EmployeeUsername, SUM([Medical]) AS 'MedicalEarned' FROM Employees where EmployeeUsername = '{0}' GROUP BY EmployeeUsername) t10 ON t1.EmployeeUsername = t10.EmployeeUsername",Globals.VarUsername.ToString());
            //SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            SqlCommand da = new SqlCommand(sql, cnn);

            
                SqlDataReader reader = da.ExecuteReader();
                while (reader.Read())
                {

                    BalanceModel.UsedPTO = Convert.ToInt32(reader[3].ToString());
                    BalanceModel.UsedMedical = Convert.ToInt32(reader[2].ToString());
                    BalanceModel.UsedLOA = Convert.ToInt32(reader[1].ToString());

                    BalanceModel.ScheduledPTO = Convert.ToInt32(reader[6].ToString());
                    BalanceModel.ScheduledMedical = Convert.ToInt32(reader[5].ToString());
                    BalanceModel.ScheduledLOA = Convert.ToInt32(reader[4].ToString());

                    BalanceModel.EarnedPTO = Convert.ToInt32(reader[7].ToString());
                    BalanceModel.EarnedMedical = Convert.ToInt32(reader[8].ToString());
                    BalanceModel.EarnedLOA = Convert.ToInt32(reader[9].ToString());


                    
                    BalanceModel.RemainingPTO = Convert.ToInt32(reader[7].ToString()) - (Convert.ToInt32(reader[6].ToString()) + Convert.ToInt32(reader[2].ToString()));
                    BalanceModel.RemainingMedical = Convert.ToInt32(reader[8].ToString()) - (Convert.ToInt32(reader[5].ToString()) + Convert.ToInt32(reader[2].ToString()));
                    BalanceModel.RemainingLOA = Convert.ToInt32(reader[9].ToString()) - (Convert.ToInt32(reader[4].ToString()) + Convert.ToInt32(reader[1].ToString()));
                    return true;
                }

            return false;
        }




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

    }
}

