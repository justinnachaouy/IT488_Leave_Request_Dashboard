namespace request_leave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_ControlAdded(object sender, ControlEventArgs e)
        {
            comboBox1.Items.Add("Yes");
            comboBox1.Items.Add("No");
        }

        private void comboBox2_ControlAdded(object sender, ControlEventArgs e)
        {
            comboBox2.Items.Add("Leave of Absence");
            comboBox2.Items.Add("Maternity Leave");
            comboBox2.Items.Add("Family Emergency");
            comboBox2.Items.Add("Personal Leave");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void submit_butt_ControlAdded(object sender, ControlEventArgs e)
        {
            this.Controls.Add(submit_butt);
        }

        private void submit_butt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Succesfully Submitted");
            cancel_butt.Visible = true;
        }

        private void cancel_butt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Canceled");
            submit_butt.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}