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

namespace IT488_Leave_Request_Dashboard
{
    public partial class new_requests_form : Form
    {

        private Controller controller;

        public new_requests_form()
        {
            InitializeComponent();
        }

        private void requests_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leave_request_dashboardDataSet1.temprequests' table. You can move, or remove it, as needed.
            this.temprequestsTableAdapter1.Fill(this.leave_request_dashboardDataSet1.temprequests);
            if (Globals.VarUsername.Length == 0 || Globals.VarPassword.Length == 0 ||
                Globals.VarServer.Length == 0 || Globals.VarDatabase.Length == 0)
            {
       
            }
            else
            {
                controller = new Controller("Data Source = tcp:" + Globals.VarServer + ";" +
                "Initial Catalog = " + Globals.VarDatabase + ";" +
                "User ID = " + Globals.VarUsername + ";" +
                "Password = " + Globals.VarPassword + ";"
                );
            }

        }

        private void TsbtnRefreshDatabase_Click(object sender, EventArgs e)
        {



        }

        private void requests_form_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create DataTable and Select all Records in Orders Table
            //DataTable dt;
            //string text = controller.GetRole();
            //MessageBox.Show(text);



            // Create DataTable and Select all Records in Orders Table
            DataTable dt;
            dt = controller.GetRole();

            // Change the datasource on our dataGridDatabaseViewer to our DataTable and then display on screen
            dataGridView1.DataSource = dt;

        }
    }
}
