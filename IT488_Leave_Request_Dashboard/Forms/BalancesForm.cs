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
    public partial class BalancesForm : Form
    {
        private SqlController sqlController;

        public BalancesForm()
        {
            InitializeComponent();

            // Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void BalancesForm_Load(object sender, EventArgs e)
        {
            if (Globals.VarUsername.Length == 0 || Globals.VarPassword.Length == 0 ||
                Globals.VarServer.Length == 0 || Globals.VarDatabase.Length == 0)
            {
                // Code to display if login information is null
            }
            else
            {
                sqlController = new SqlController(Globals.sqlConnectionString);
            }
            // Create DataTable and Select all Records in Requests Table
            bool BalancesByEmployee;
            BalancesByEmployee = sqlController.BalancesByEmployee();

            // Create a new DataTable.
            System.Data.DataTable table = new DataTable("Balances");
            // Declare variables for DataColumn and DataRow objects.
            DataColumn column;
            DataRow row;

            // Create new DataColumn, set DataType,
            // ColumnName and add to DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LeaveType";
            column.AutoIncrement = false;
            column.Caption = "Leave Type";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Earned";
            column.Caption = "Earned";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the table.
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Used";
            column.Caption = "Used";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the table.
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Scheduled";
            column.Caption = "Scheduled";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the table.
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Remaining";
            column.Caption = "Remaining";
            column.ReadOnly = true;
            column.Unique = false;
            // Add the column to the table.
            table.Columns.Add(column);

            // Make the ID column the primary key column.
            //DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            //PrimaryKeyColumns[0] = table.Columns["id"];
            //table.PrimaryKey = PrimaryKeyColumns;

            // Instantiate the DataSet variable.
            DataSet dataSet = new DataSet();
            // Add the new DataTable to the DataSet.
            dataSet.Tables.Add(table);

            // Create three new DataRow objects and add
            // them to the DataTable
            row = table.NewRow();
            row["LeaveType"] = "Paid Time Off";
            row["Earned"] = BalanceModel.EarnedPTO;
            row["Used"] = BalanceModel.UsedPTO;
            row["Scheduled"] = BalanceModel.ScheduledPTO;
            row["Remaining"] = BalanceModel.RemainingPTO;
            table.Rows.Add(row);

            row = table.NewRow();
            row["LeaveType"] = "Medical Leave";
            row["Earned"] = BalanceModel.EarnedMedical;
            row["Used"] = BalanceModel.UsedMedical;
            row["Scheduled"] = BalanceModel.ScheduledMedical;
            row["Remaining"] = BalanceModel.RemainingMedical;
            table.Rows.Add(row);

            row = table.NewRow();
            row["LeaveType"] = "Leave of Absence";
            row["Earned"] = BalanceModel.EarnedLOA;
            row["Used"] = BalanceModel.UsedLOA;
            row["Scheduled"] = BalanceModel.ScheduledLOA;
            row["Remaining"] = BalanceModel.RemainingLOA;
            table.Rows.Add(row);



        }

        private void refreshRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Globals.ViewingEmployeeRequests)
            {
                if (Globals.VarRole == "HR")
                {
                    // Create DataTable and Select all Records in Requests Table
                    DataTable GetAllRequests;
                    GetAllRequests = sqlController.GetAllRequests();

                    // Change the datasource on our dataGridDatabaseViewer to our DataTable and then display on screen
                    dataGridDatabaseViewer.DataSource = GetAllRequests;
                }
                else
                {
                    if (Globals.VarRole == "Manager")
                    {
                        // Create DataTable and Select all Records that match ManagerUsername in Requests Table
                        DataTable AllMyEmployeeRequests;
                        AllMyEmployeeRequests = sqlController.GetAllMyEmployeeRequests();

                        // Change the datasource on our dataGridDatabaseViewer to our DataTable and then display on screen
                        dataGridDatabaseViewer.DataSource = AllMyEmployeeRequests;
                    }
                    else
                    {
                        // Create DataTable and Select all Records that match EmployeeUsername in Requests Table
                        DataTable GetAllMyRequests;
                        GetAllMyRequests = sqlController.GetAllMyRequests();

                        // Change the datasource on our dataGridDatabaseViewer to our DataTable and then display on screen
                        dataGridDatabaseViewer.DataSource = GetAllMyRequests;
                        Globals.ViewingEmployeeRequests = false;
                    }
                }
            }
            else 
            {
                // Create DataTable and use GetAllRequests command
                DataTable GetAllMyRequests;
                GetAllMyRequests = sqlController.GetAllMyRequests();

                // Change the datasource on our dataGridDatabaseViewer to our DataTable and then display on screen
                dataGridDatabaseViewer.DataSource = GetAllMyRequests;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dataGridDatabaseViewer.CurrentRow;
            Console.WriteLine(cell.ToString());
        }

        #region btnMax_Click() // Maximizes the window when clicked
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        #endregion // Maximizes the window when clicked

        #region btnMin_Click() // Minimizes the window when clicked
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion // Minimizes the window when clicked

        #region moveWindow_MouseDown() // Allows the window to be moved when clicked
        // Code to import DLLs that allow the window to be moved when clicked
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void moveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       #endregion // Allows the window to be moved when clicked

        #region FormMainMenu_Resize() // Removes the border when window is maximized
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
        #endregion // Removes the border when window is maximized


    }
}
