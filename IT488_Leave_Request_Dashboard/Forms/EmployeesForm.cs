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
    public partial class EmployeesForm : Form
    {
        private SqlController sqlController;

        public EmployeesForm()
        {
            InitializeComponent();

            // Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void RequestsForm_Load(object sender, EventArgs e)
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

            if (Globals.VarRole == "HR")
            {
                // Create DataTable and Select all Records in Requests Table
                DataTable GetAllEmployees;
                GetAllEmployees = sqlController.GetAllEmployees();

                // Change the datasource on our dataGridDatabaseViewer to our DataTable and then display on screen
                dataGridDatabaseViewer.DataSource = GetAllEmployees;
            }
            else
            {
                if (Globals.VarRole == "Manager")
                {
                    // Create DataTable and Select all Records that match ManagerUsername in Requests Table
                    DataTable GetAllMyEmployees;
                    GetAllMyEmployees = sqlController.GetAllMyEmployees();

                    // Change the datasource on our dataGridDatabaseViewer to our DataTable and then display on screen
                    dataGridDatabaseViewer.DataSource = GetAllMyEmployees;
                }
            }

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
