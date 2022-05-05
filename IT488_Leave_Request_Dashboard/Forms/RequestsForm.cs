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
    public partial class RequestsForm : Form
    {
        private SqlController sqlController;

        public RequestsForm()
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
                Globals.ViewingEmployeeRequests = false;
            }

            // Create DataTable and Select all Records in Orders Table
            DataTable AllMyRequests;
            AllMyRequests = sqlController.GetAllMyRequests();

            // Change the datasource on our dataGridDatabaseViewer to our DataTable and then display on screen
            dataGridDatabaseViewer.DataSource = AllMyRequests;
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
            Globals.SelectedRow = dataGridDatabaseViewer.CurrentRow;
            btnEditRequest.Visible = true;
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

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            txtRequestID.Text = "";
            comboRequestType.Text = "Paid Time Off";
            txtRequestStatus.Text = "Pending";
            StartDate_picker.Text = DateTime.Now.ToString();
            EndDate_picker.Text = DateTime.Now.ToString();
            comboStartHour.Text = "7:00 AM";
            comboEndHour.Text = "8:00 AM";
            labelHours.Text = "1";
            comboSpecificTime.Text = "Yes";
            txtManager.Text = "";
            txtComments.Text = "";

            // We are not editing
            Globals.IsEdit = false;

            // Lets hide the requests table and show the details form
            panelRequestDetails.Visible = true;
            dataGridDatabaseViewer.Visible = false;

            btnCancel.Visible = true;
            btnSaveChanges.Visible = true;

            btnNewRequest.Visible = false;
            btnRefreshRequests.Visible = false;
            btnFilterRequests.Visible = false;
            btnViewEmployeeRequests.Visible = false;
            btnEditRequest.Visible = false;
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            Globals.IsEdit = true;

            panelRequestDetails.Visible = true;
            dataGridDatabaseViewer.Visible = false;

            btnCancel.Visible = true;
            btnSaveChanges.Visible = true;

            btnNewRequest.Visible = false;
            btnRefreshRequests.Visible = false;
            btnFilterRequests.Visible = false;
            btnViewEmployeeRequests.Visible = false;
            btnEditRequest.Visible = false;


            txtRequestID.Text = Globals.SelectedRow.Cells[0].Value.ToString();
            //txt"Employee Username" Globals.SelectedRow.Cells[1].Value.ToString();
            comboRequestType.Text = ConvertRequestTypeToEdit(Globals.SelectedRow.Cells[2].Value.ToString());
            txtRequestStatus.Text = Globals.SelectedRow.Cells[3].Value.ToString();
            StartDate_picker.Text = Globals.SelectedRow.Cells[4].Value.ToString();
            EndDate_picker.Text = Globals.SelectedRow.Cells[5].Value.ToString();
            comboStartHour.Text = Globals.SelectedRow.Cells[6].Value.ToString();
            comboEndHour.Text = Globals.SelectedRow.Cells[7].Value.ToString();
            labelHours.Text = Globals.SelectedRow.Cells[8].Value.ToString();
            comboSpecificTime.Text = Globals.SelectedRow.Cells[9].Value.ToString();
            txtManager.Text = Globals.SelectedRow.Cells[10].Value.ToString();
            txtComments.Text = Globals.SelectedRow.Cells[11].Value.ToString();
        }


        private string ConvertRequestTypeToEdit(string type)
        {
            if (type == "PaidTimeOff")
            {
                return "Paid Time Off";
            }
            else
            {
                if (type == "LOA")
                {
                    return "Leave of Absence";
                }
                else
                {
                    if (type == "Medical")
                    {
                        return "Medical Leave";
                    }
                    else 
                    {
                        return "Error!";
                    }
                }
            }
        }

        private string ConvertRequestTypeToSave(string type)
        {
            if (type == "Paid Time Off")
            {
                return "PaidTimeOff";
            }
            else
            {
                if (type == "Leave of Absence")
                {
                    return "LOA";
                }
                else
                {
                    if (type == "Medical Leave")
                    {
                        return "Medical";
                    }
                    else
                    {
                        return "Error!";
                    }
                }
            }
        }





        private void btnViewEmployeeRequests_Click(object sender, EventArgs e)
        {
            Globals.ViewingEmployeeRequests = true;
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

        private void panelRequestDetails_VisibleChanged(object sender, EventArgs e)
        {
            
            if (!panelRequestDetails.Visible)
            {
                txtRequestID.Text = "";
                comboRequestType.Text = "Paid Time Off";
                txtRequestStatus.Text = "Pending";
                StartDate_picker.Text = DateTime.Now.ToString();
                EndDate_picker.Text = DateTime.Now.ToString();
                comboStartHour.Text = "7:00 AM";
                comboEndHour.Text = "8:00 AM";
                labelHours.Text = "1";
                comboSpecificTime.Text = "Yes";
                txtManager.Text = "";
                txtComments.Text = "";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // We are not editing anymore
            Globals.IsEdit = false;

            // Lets hide the details form and show the requests table again
            panelRequestDetails.Visible = false;
            dataGridDatabaseViewer.Visible = true;

            // Since we canceled lets reset the values
            txtRequestID.Text = "";
            comboRequestType.Text = "Paid Time Off";
            txtRequestStatus.Text = "Pending";
            StartDate_picker.Text = DateTime.Now.ToString();
            EndDate_picker.Text = DateTime.Now.ToString();
            comboStartHour.Text = "7:00 AM";
            comboEndHour.Text = "8:00 AM";
            labelHours.Text = "1";
            comboSpecificTime.Text = "Yes";
            txtManager.Text = "";
            txtComments.Text = "";

            btnCancel.Visible = false;
            btnSaveChanges.Visible = false;

            btnNewRequest.Visible = true;
            btnRefreshRequests.Visible = true;
            btnFilterRequests.Visible = false;
            btnViewEmployeeRequests.Visible = true;
            btnEditRequest.Visible = false;


        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string startDateFormatted = StartDate_picker.Value.Month.ToString() + "/" + StartDate_picker.Value.Day.ToString() + "/" + StartDate_picker.Value.Year.ToString();
            string endDateFormatted = EndDate_picker.Value.Month.ToString() + "/" + EndDate_picker.Value.Day.ToString() + "/" + EndDate_picker.Value.Year.ToString();

            if (Globals.IsEdit)
            {
                try
                {
                    sqlController.UpdateRequest(Convert.ToInt32(Globals.SelectedRow.Cells[0].Value.ToString()), Globals.SelectedRow.Cells[1].Value.ToString(), ConvertRequestTypeToSave(comboRequestType.Text), txtRequestStatus.Text, startDateFormatted, comboStartHour.Text, endDateFormatted, comboEndHour.Text, Convert.ToInt32(labelHours.Text), comboSpecificTime.Text, txtManager.Text, txtComments.Text);
                    MessageBox.Show("Updating the request was sucessful");

                    // We are not editing anymore
                    Globals.IsEdit = false;
                    btnRefreshRequests.PerformClick();

                    // Lets hide the details form and show the requests table again
                    panelRequestDetails.Visible = false;
                    dataGridDatabaseViewer.Visible = true;

                    

                    btnCancel.Visible = false;
                    btnSaveChanges.Visible = false;

                    btnNewRequest.Visible = true;
                    btnRefreshRequests.Visible = true;
                    btnFilterRequests.Visible = false;
                    btnViewEmployeeRequests.Visible = true;
                    btnEditRequest.Visible = false;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
            else
            {
                sqlController.CreateRequest(Globals.VarUsername.ToString(), ConvertRequestTypeToSave(comboRequestType.Text), txtRequestStatus.Text, startDateFormatted, comboStartHour.Text, endDateFormatted, comboEndHour.Text, Convert.ToInt32(labelHours.Text), comboSpecificTime.Text, txtManager.Text, txtComments.Text);
                MessageBox.Show("Updating the request was sucessful");

                // Lets hide the details form and show the requests table again
                panelRequestDetails.Visible = false;
                btnRefreshRequests.PerformClick();
                dataGridDatabaseViewer.Visible = true;

                btnCancel.Visible = false;
                btnSaveChanges.Visible = false;

                btnNewRequest.Visible = true;
                btnRefreshRequests.Visible = true;
                btnFilterRequests.Visible = false;
                btnViewEmployeeRequests.Visible = true;
                btnEditRequest.Visible = false;
            }



        }

        private void comboSpecificTime_TextUpdate(object sender, EventArgs e)
        {
            if (comboSpecificTime.Text == "No")
            {
                EndDate_picker.Visible = true;
                EndDate_label.Visible = true;
                StartTime_label.Visible = false;
                EndTime_label.Visible = false;
                comboStartHour.Visible = false;
                comboEndHour.Visible = false;
            }
            else if (comboSpecificTime.Text == "Yes")
            {
                EndDate_picker.Visible = false;
                EndDate_label.Visible = false;
                StartTime_label.Visible = true;
                EndTime_label.Visible = true;
                comboStartHour.Visible = true;
                comboEndHour.Visible = true;
            }

        }

        private void CalculateHoursUsed(object sender, EventArgs e)
        {
            if (StartDate_picker.Value > EndDate_picker.Value)
            {
                //EndDate_picker.Value = StartDate_picker.Value;
                labelError.Visible = true;
                labelError.Text = "Please select an end date that is on or after the start date of this request.";
                Globals.IsRequestValid = false;
            }

            if (StartDate_picker.Value < DateTime.Today || EndDate_picker.Value < DateTime.Today)
            {
                //StartDate_picker.Value = DateTime.Now;
                //EndDate_picker.Value = DateTime.Now;
                labelError.Visible = true;
                labelError.Text = "You cannot select a date that has already past. Please select another date.";
                Globals.IsRequestValid = false;
                //MessageBox.Show("You cannot select a date that has already past. Please select another date.");
            }
            if (StartDate_picker.Value < EndDate_picker.Value || StartDate_picker.Value >= DateTime.Today || EndDate_picker.Value >= DateTime.Today)
            {
                labelError.Visible = false;
                Globals.IsRequestValid = true;
            }


            if (comboSpecificTime.Text == "Yes")
            {
                string startTimeString = comboStartHour.Text;
                string endTimeString = comboEndHour.Text;
                DateTime startTime;
                DateTime endTime;

                DateTime.TryParse(startTimeString, out startTime);
                DateTime.TryParse(endTimeString, out endTime);

                DateTime StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, startTime.Hour, startTime.Minute, 00);
                DateTime EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, endTime.Hour, endTime.Minute, 00);
                TimeSpan ts = EndDate - StartDate;
                labelHours.Text = ts.TotalHours.ToString();
                //MessageBox.Show("No. of Hours (Difference) = " + ts.TotalHours.ToString());
            }
            else if (comboSpecificTime.Text == "No")
            {
                DateTime StartDate = new DateTime(StartDate_picker.Value.Year, StartDate_picker.Value.Month, StartDate_picker.Value.Day, 00, 00, 00);
                DateTime EndDate = new DateTime(EndDate_picker.Value.Year, EndDate_picker.Value.Month, EndDate_picker.Value.Day, 00, 00, 00);
                double businessDays = GetBusinessDays(StartDate, EndDate);
                //TimeSpan ts = EndDate - StartDate;
                //labelHours.Text = ((ts.TotalDays + 1) * 8).ToString();
                labelHours.Text = (businessDays * 8).ToString();

            }

        }

        public static double GetBusinessDays(DateTime startD, DateTime endD)
        {
            double calcBusinessDays =
                1 + ((endD - startD).TotalDays * 5 -
                (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7;

            if (endD.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
            if (startD.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

            return calcBusinessDays;
        }




    }
}
