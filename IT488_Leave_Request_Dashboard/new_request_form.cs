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
    public partial class new_request_form : Form
    {

        private Controller controller;

        public new_request_form()
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




        private void TsbtnRefreshDatabase_Click(object sender, EventArgs e)
        {



        }

        private void AllDayLeave_TextChanged(object sender, EventArgs e)
        {
            if (AllDayLeave_combo.Text == "No")
            {
                dateTimePicker2.Visible = false;
                EndDate_label.Visible = false;
            }
            else
            {
                dateTimePicker2.Visible = true;
                EndDate_label.Visible = true;
            }
            
            
            
        }


        private void requests_form_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
