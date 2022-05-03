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
                catch (SqlException)
                {
                    return false;
                }
            }

        }
        //
        // SQL Commands to View Requests
        //

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

        //
        // End of SQL Commands to View Requests
        //





        // SQL Command to insert a request 
        public bool CreateRequest(string FirstName, string LastName, string Type, string Status, string StartDate, string EndDate)
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "INSERT INTO Requests (\"First Name\",\"Last Name\",\"Type\",\"Status\",\"ApproverFirstName\",\"ApproverLastName\",\"Start Date\",\"End Date\") VALUES (\'" + FirstName + "\',\'" + LastName + "\',\'" + Type + "\',\'" + Status + "\',\'" + "Joe" + "\',\'" + "Smith" + "\',\'" + StartDate + "\',\'" + EndDate + "\')";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            return true;
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

