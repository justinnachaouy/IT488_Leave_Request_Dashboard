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

        // Customer Tables
        public DataTable GetCustomers()
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "select * from Customers;";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

            // Create DataTable and store our records there
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
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

        public string GetCustomerCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();

            string countQuery = "select count(*) from Customers;";
            SqlDataAdapter da = new SqlDataAdapter(countQuery, cnn);


            //string countQuery = "select count(*) from Customers;";
            //SqlCommand cmd = new SqlCommand(countQuery, cnn);
            try
            {
                count = Convert.ToInt32(da.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count.ToString();
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

        public string GetEmployeeCount()
        {
            Int32 count = 0;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select count(*) from Employees;";
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

        // Order Tables
        public DataTable GetOrders()
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "select * from Orders;";
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

