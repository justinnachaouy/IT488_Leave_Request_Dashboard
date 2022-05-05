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
    public partial class MainForm : Form
    {
        private SqlController sqlController;
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public MainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            // Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            if (Globals.VarUsername.Length == 0 || Globals.VarPassword.Length == 0 ||
                Globals.VarServer.Length == 0 || Globals.VarDatabase.Length == 0)
            {
                // Code to handle if login information is null
            }
            else
            {
                sqlController = new SqlController(Globals.sqlConnectionString);
                //ViewingEmployeeRequests = false;
                btnRequests.PerformClick();
            }

            if(Globals.VarRole == "HR")
            {
                btnEmployees.Visible = true;
            }
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Styles.btnMenuSelectedColor;
                currentBtn.ForeColor = Styles.AccentColor;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Styles.AccentColor;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                labelTitleChildForm.Text = currentBtn.Text;

                //  Left Border Button
                leftBorderBtn.BackColor = Styles.AccentColor;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Styles.AccentColor;

                // Close Child Form when we change forms
                if (ActiveMdiChild != null)
                {
                    ActiveMdiChild.Close();
                }


            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Styles.PrimaryColor;
                currentBtn.ForeColor = Styles.fontColor;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Styles.fontColor;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

                // Icon Current Child Form - This sets the child form icon to home and mediumpurple as default
                iconCurrentChildForm.IconChar = IconChar.UmbrellaBeach;
                iconCurrentChildForm.IconColor = Styles.AccentColor;
                labelTitleChildForm.Text = "Leave Request Dashboard";

            }
        }



        // Resets the form and controls
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            // Resets these controls to their default values
            iconCurrentChildForm.IconChar = IconChar.UmbrellaBeach;
            iconCurrentChildForm.IconColor = Styles.AccentColor;
            labelTitleChildForm.Text = "Leave Request Dashboard";
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

        // All Menu Button Clicks
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRequests_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            Globals.ViewingEmployeeRequests = false;

            RequestsForm frm = new RequestsForm();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnBalances_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            AboutForm frm = new AboutForm();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnHolidays_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            AboutForm frm = new AboutForm();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            AboutForm frm = new AboutForm();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            AboutForm frm = new AboutForm();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            EmployeesForm frm = new EmployeesForm();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();

        }
    }
}
