using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace IT488_Leave_Request_Dashboard
{
    public partial class ReportsForm : Form
    {
        private SqlController sqlController;

        public ReportsForm()
        {
            InitializeComponent();

            // Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

            if (Globals.VarUsername.Length == 0 || Globals.VarPassword.Length == 0 ||
                Globals.VarServer.Length == 0 || Globals.VarDatabase.Length == 0)
            {
                // Code to display if login information is null
            }
            else
            {
                sqlController = new SqlController(Globals.sqlConnectionString);
                Globals.ViewingEmployeeRequests = false;
            }

            // Run command on SQL
            DataTable RequestsByMonthReport;
            RequestsByMonthReport = sqlController.RequestsByMonthReport();

            // Change the datasource on the chart
            chartRequestsByMonth.DataSource = RequestsByMonthReport;

            chartRequestsByMonth.Series["Requests"].XValueMember = "Month";
            chartRequestsByMonth.Series["Requests"].YValueMembers = "Requests";
            chartRequestsByMonth.Titles.Add("Requests by Month");


            // Run command on SQL
            DataTable RequestsByStatusReport;
            RequestsByStatusReport = sqlController.RequestsByStatusReport();

            // Change the datasource on the chart
            chartRequestsByStatus.DataSource = RequestsByStatusReport;

            chartRequestsByStatus.Series["Requests"].XValueMember = "Status";
            chartRequestsByStatus.Series["Requests"].YValueMembers = "Requests";
            chartRequestsByStatus.Titles.Add("Requests by Status");





        }

    }
}
