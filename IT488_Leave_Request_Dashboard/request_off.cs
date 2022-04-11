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
    public partial class request_off : Form
    {
        private Controller controller;

        public request_off()
        {
            InitializeComponent();
        
    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "No")
            {
                dateTimePicker1.Visible = false;
                label4.Visible = false;
            }
            else
            {
                dateTimePicker1.Visible = true;
                label4.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancel_butt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Canceled");
            submit_butt.Visible = true;
        }

        private void submit_butt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Succesfully Submitted");
            cancel_butt.Visible = true;
        }

        private void submit_butt_Click_1(object sender, EventArgs e)
        {

        }

        private void request_off_Load(object sender, EventArgs e)
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

        }
    }
    }
    

