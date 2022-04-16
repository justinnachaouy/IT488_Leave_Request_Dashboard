﻿using System;
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
    public partial class requests_form : Form
    {
        private Controller controller;

        new_request_form frmNR;

        public requests_form()
        {
            InitializeComponent();
        }

        void new_request_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmNR = null;  //If form is closed make sure reference is set to null
            Show();
        }


        private void requests_form_Load(object sender, EventArgs e)
        {
            
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

            // Create DataTable and Select all Records in Orders Table
            DataTable dt;
            dt = controller.GetAllRequests();

            // Change the datasource on our dataGridDatabaseViewer to our DataTable and then display on screen
            dataGridView1.DataSource = dt;
        }

        private void requests_form_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmNR == null)
            {
                frmNR = new new_request_form();   //Create form if not created
                frmNR.FormClosed += new_request_form_FormClosed;  //Add eventhandler to cleanup after form closes
            }

            frmNR.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void refreshRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create DataTable and Select all Records in Orders Table
            DataTable dt;
            dt = controller.GetAllRequests();

            // Change the datasource on our dataGridDatabaseViewer to our DataTable and then display on screen
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller = new Controller("Data Source = tcp:" + Globals.VarServer + ";" +
    "Initial Catalog = " + Globals.VarDatabase + ";" +
    "User ID = " + Globals.VarUsername + ";" +
    "Password = " + Globals.VarPassword + ";"
);

            // Create DataTable and Select all Records in Orders Table
            string dt = controller.GetRole();
            MessageBox.Show(dt);
        }
    }
}
