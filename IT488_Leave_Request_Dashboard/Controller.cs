using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT488_Leave_Request_Dashboard
{
    public static class Globals
    {
        public static string VarUsername { get; set; }
        public static string VarPassword { get; set; }
        public static string VarServer { get; set; }
        public static string VarDatabase { get; set; }
        public static bool Requesting_Specific_Time_Variable { get; set; }
        public static string Request_Type_Variable { get; set; }
        public static DateTime Start_Date_Variable { get; set; }
        public static DateTime End_Date_Variable { get; set; }
        public static string Start_Time_Variable { get; set; }
        public static string End_Time_Variable { get; set; }
        public static string Note_Variable { get; set; }

    }

    class Controller
    {
        static string connectionString;
        SqlConnection cnn;
        public Controller()
        {
            connectionString = @"Data Source = tcp:" + Globals.VarServer + ";" +
                               "Initial Catalog = leave_request_dashboard;" +
                               "User ID = " + Globals.VarUsername + ";" +
                               "Password = " + Globals.VarPassword + ";";
        }
        //Constructor that takes DB connection string
        public Controller(string conn)
        {
            connectionString = conn;
        }

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

        // SQL Command to get all requests 
        public DataTable GetAllRequests()
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "select * from temprequests;";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // SQL Command to insert a request 
        public bool CreateRequest(string FirstName, string LastName, string Type, string Status, string StartDate, string EndDate)
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "INSERT INTO temprequests (\"First Name\",\"Last Name\",\"Type\",\"Status\",\"ApproverFirstName\",\"ApproverLastName\",\"Start Date\",\"End Date\") VALUES (\'" + FirstName + "\',\'" + LastName + "\',\'" + Type + "\',\'" + Status + "\',\'" + "Joe" + "\',\'" + "Smith" + "\',\'" + StartDate + "\',\'" + EndDate + "\')";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            return true;
        }

        public DataTable GetRole()
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "SELECT roles.NAME, members.NAME FROM sys.database_role_members role_members JOIN sys.database_principals roles ON role_members.role_principal_id = roles.principal_id JOIN sys.database_principals members ON role_members.member_principal_id = members.principal_id";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            string info = da.ToString();

            return dt;
        }

        // Employee Tables
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

    }
}

