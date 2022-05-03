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
    public partial class NewRequestsForm : Form
    {
        private SqlController sqlController;
        bool requesting_specific_time = false;

        public NewRequestsForm()
        {
            InitializeComponent();
            menuStrip2.Renderer = new MyRenderer();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.LightGray; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.LightGray; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.LightGray; }
            }
        }


        private void new_request_form_Load(object sender, EventArgs e)
        {
            sqlController = new SqlController("Data Source = tcp:" + Globals.VarServer + ";" +
            "Initial Catalog = " + Globals.VarDatabase + ";" +
            "User ID = " + Globals.VarUsername + ";" +
            "Password = " + Globals.VarPassword + ";"
            );

        }


        private void AllDayLeave_TextChanged(object sender, EventArgs e)
        {
            if (RequestingSpecificTime_combo.Text == "No")
            {
                EndDate_picker.Visible = true;
                EndDate_label.Visible = true;
                StartTime_label.Visible = false;
                EndTime_label.Visible = false;
                StartTime_combo.Visible = false;
                EndTime_combo.Visible = false;
                requesting_specific_time = false;
            }
            else
            {
                EndDate_picker.Visible = false;
                EndDate_label.Visible = false;
                StartTime_label.Visible = true;
                EndTime_label.Visible = true;
                StartTime_combo.Visible = true;
                EndTime_combo.Visible = true;
                requesting_specific_time = true;
            }
            
            
            
        }
         
        private void myLeaveRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlController = new SqlController("Data Source = tcp:" + Globals.VarServer + ";" +
                "Initial Catalog = " + Globals.VarDatabase + ";" +
                "User ID = " + Globals.VarUsername + ";" +
                "Password = " + Globals.VarPassword + ";" 
            );

            // Create DataTable and Select all Records in Orders Table
            sqlController.CreateRequest("HR", "Manager", "Personal", "Pending", "01/01/2022", "01/01/2022");
            MessageBox.Show("Request Submitted Succesfully!");
            this.Close();

        }
    }
}
