using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT488_Leave_Request_Dashboard
{
    public partial class login_form : Form
    {

        private Controller controller;


        public login_form()
        {
            InitializeComponent();
        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
            Globals.VarUsername = UsernameText.Text;
            Globals.VarPassword = PasswordText.Text;
            Globals.VarServer = @"127.0.0.1";
            Globals.VarDatabase = "leave_request_dashboard";

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
                    controller = new Controller("Data Source = tcp:" + Globals.VarServer + ";" +
                    "Initial Catalog = " + Globals.VarDatabase + ";" +
                    "User ID = " + Globals.VarUsername + ";" +
                    "Password = " + Globals.VarPassword + ";"
                    );
                    validTest = controller.TestConnection();
                }

                // Report the test as successful and close the connection
                if (validTest)
                {
                    MessageBox.Show("Connection to " + Globals.VarServer + " was successful!");
                    MessageBox.Show("Login Successful!");

                    // Open the Form_RecordEditor
                    requests_form f2 = new requests_form();
                    this.Hide();
                    f2.Show();

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
    }
}
