using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT488_Leave_Request_Dashboard
{
    public partial class LoginForm : Form
    {

        private SqlController sqlController;


        public LoginForm()
        {
            InitializeComponent();
        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
            Globals.VarUsername = txtUsername.Text;
            Globals.VarPassword = txtPassword.Text;
            Globals.sqlConnectionString = "Data Source =" + Globals.VarServer + ";" + "Network Library = DBMSSOCN;" + "Initial Catalog =" + Globals.VarDatabase + ";" + "User ID =" + Globals.VarUsername + ";" + "Password =" + Globals.VarPassword + ";";
            try
            {
                // Open a connection to the Local SQL Server and choose the Northwind Database
                bool isValid = true;
                bool validTest = false;

                if (Globals.VarUsername.Length == 0 || Globals.VarPassword.Length == 0 ||
                Globals.VarServer.Length == 0 || Globals.VarDatabase.Length == 0)
                {
                    isValid = false;
                    MessageBox.Show("You must enter user name, password, server, and database values");
                }
                if (isValid)
                {
                    sqlController = new SqlController(Globals.sqlConnectionString);
                    validTest = sqlController.TestConnection();
                }

                // Report the test as successful and close the connection
                if (validTest)
                {
                    MessageBox.Show("Connection to " + Globals.VarServer + " was successful!");
                    MessageBox.Show("Login Successful!");

                    // Check User
                    Globals.SQLUsername = sqlController.Check_User().ToString();
                    MessageBox.Show(Globals.SQLUsername.ToString());
                    // End of Check User

                    // Check Role

                    if (sqlController.Check_Role_HR())
                    {
                        Globals.VarRole = "HR";
                    }
                    else
                    {
                        if (sqlController.Check_Role_Manager())
                        {
                            Globals.VarRole = "Manager";
                        }
                        else
                        {
                            if (sqlController.Check_Role_Employee())
                            {
                                Globals.VarRole = "Employee";
                            }
                            else
                            {
                                Globals.VarRole = "Unknown";
                            }
                        }
                    }
                    MessageBox.Show(Globals.VarRole.ToString());
                    // End of Check Role


                    // Open the Form_RecordEditor
                    MainForm mainform = new MainForm();  
                    this.Hide();
                    mainform.Show();

                }
                else
                {
                    MessageBox.Show("Error! Connection to " + Globals.VarServer + " was not successful!" + "\n" + "Please double check your login information and try again!", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception ex)
            {
                // Displays the error message
                MessageBox.Show("Error! Please check the error message:" + "\n" + ex.Message);
            }

        }



        // Allows the window to be dragged
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Use this method on the controls under the MouseDown event
        private void moveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Closes the application when x button is clicked
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
