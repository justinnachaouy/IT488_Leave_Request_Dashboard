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
        public request_off()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
