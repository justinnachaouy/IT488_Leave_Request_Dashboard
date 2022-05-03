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
    public partial class Balance_Form : Form
    {

        public Balance_Form()
        {
            InitializeComponent();
        }

        private void Approve_butt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leave Approved");
        }

        private void Deny_butt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leave has been Denied");
        }

        private void Cancel_butt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Canceled");
        }

        private void groupBox1_TextChanged(object sender, EventArgs e)
        {
            if ("User_HR" == groupBox1.Text) ;


        }

       
        }
    }
    

