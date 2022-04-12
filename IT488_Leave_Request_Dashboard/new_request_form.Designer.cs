
namespace IT488_Leave_Request_Dashboard
{
    partial class new_request_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.createRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temprequestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.leave_request_dashboardDataSet1 = new IT488_Leave_Request_Dashboard.leave_request_dashboardDataSet1();
            this.leave_request_dashboardDataSet = new IT488_Leave_Request_Dashboard.leave_request_dashboardDataSet();
            this.temprequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temprequestsTableAdapter = new IT488_Leave_Request_Dashboard.leave_request_dashboardDataSetTableAdapters.temprequestsTableAdapter();
            this.temprequestsTableAdapter1 = new IT488_Leave_Request_Dashboard.leave_request_dashboardDataSet1TableAdapters.temprequestsTableAdapter();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.myLeaveRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myLeaveBalancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyHolidaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartDate_picker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EndTime_label = new System.Windows.Forms.Label();
            this.StartTime_label = new System.Windows.Forms.Label();
            this.StartTime_combo = new System.Windows.Forms.ComboBox();
            this.EndTime_combo = new System.Windows.Forms.ComboBox();
            this.EndDate_label = new System.Windows.Forms.Label();
            this.EndDate_picker = new System.Windows.Forms.DateTimePicker();
            this.StartDate_label = new System.Windows.Forms.Label();
            this.RequestingSpecificTime_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createRequestToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip2.Size = new System.Drawing.Size(1070, 42);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // createRequestToolStripMenuItem
            // 
            this.createRequestToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.createRequestToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.createRequestToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.createRequestToolStripMenuItem.Name = "createRequestToolStripMenuItem";
            this.createRequestToolStripMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.createRequestToolStripMenuItem.Size = new System.Drawing.Size(106, 32);
            this.createRequestToolStripMenuItem.Text = "Submit Request";
            this.createRequestToolStripMenuItem.Click += new System.EventHandler(this.createRequestToolStripMenuItem_Click);
            // 
            // temprequestsBindingSource1
            // 
            this.temprequestsBindingSource1.DataMember = "temprequests";
            this.temprequestsBindingSource1.DataSource = this.leave_request_dashboardDataSet1;
            // 
            // leave_request_dashboardDataSet1
            // 
            this.leave_request_dashboardDataSet1.DataSetName = "leave_request_dashboardDataSet1";
            this.leave_request_dashboardDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leave_request_dashboardDataSet
            // 
            this.leave_request_dashboardDataSet.DataSetName = "leave_request_dashboardDataSet";
            this.leave_request_dashboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temprequestsBindingSource
            // 
            this.temprequestsBindingSource.DataMember = "temprequests";
            this.temprequestsBindingSource.DataSource = this.leave_request_dashboardDataSet;
            // 
            // temprequestsTableAdapter
            // 
            this.temprequestsTableAdapter.ClearBeforeFill = true;
            // 
            // temprequestsTableAdapter1
            // 
            this.temprequestsTableAdapter1.ClearBeforeFill = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // myLeaveRequestsToolStripMenuItem
            // 
            this.myLeaveRequestsToolStripMenuItem.Name = "myLeaveRequestsToolStripMenuItem";
            this.myLeaveRequestsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myLeaveRequestsToolStripMenuItem.Size = new System.Drawing.Size(141, 33);
            this.myLeaveRequestsToolStripMenuItem.Text = "My Leave Requests";
            this.myLeaveRequestsToolStripMenuItem.Click += new System.EventHandler(this.myLeaveRequestsToolStripMenuItem_Click);
            // 
            // myLeaveBalancesToolStripMenuItem
            // 
            this.myLeaveBalancesToolStripMenuItem.Name = "myLeaveBalancesToolStripMenuItem";
            this.myLeaveBalancesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myLeaveBalancesToolStripMenuItem.Size = new System.Drawing.Size(141, 33);
            this.myLeaveBalancesToolStripMenuItem.Text = "My Leave Balances";
            // 
            // companyHolidaysToolStripMenuItem
            // 
            this.companyHolidaysToolStripMenuItem.Name = "companyHolidaysToolStripMenuItem";
            this.companyHolidaysToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyHolidaysToolStripMenuItem.Size = new System.Drawing.Size(141, 33);
            this.companyHolidaysToolStripMenuItem.Text = "Company Holidays";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 33);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(141, 33);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myLeaveRequestsToolStripMenuItem,
            this.myLeaveBalancesToolStripMenuItem,
            this.companyHolidaysToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 42);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(154, 579);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(162, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comments/Notes:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(895, 257);
            this.textBox1.TabIndex = 0;
            // 
            // StartDate_picker
            // 
            this.StartDate_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate_picker.Location = new System.Drawing.Point(41, 51);
            this.StartDate_picker.Name = "StartDate_picker";
            this.StartDate_picker.Size = new System.Drawing.Size(200, 20);
            this.StartDate_picker.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EndTime_label);
            this.groupBox2.Controls.Add(this.StartTime_label);
            this.groupBox2.Controls.Add(this.StartTime_combo);
            this.groupBox2.Controls.Add(this.EndTime_combo);
            this.groupBox2.Controls.Add(this.EndDate_label);
            this.groupBox2.Controls.Add(this.EndDate_picker);
            this.groupBox2.Controls.Add(this.StartDate_label);
            this.groupBox2.Controls.Add(this.StartDate_picker);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(162, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 153);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Date/Time";
            // 
            // EndTime_label
            // 
            this.EndTime_label.AutoSize = true;
            this.EndTime_label.Location = new System.Drawing.Point(406, 88);
            this.EndTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndTime_label.Name = "EndTime_label";
            this.EndTime_label.Size = new System.Drawing.Size(64, 13);
            this.EndTime_label.TabIndex = 13;
            this.EndTime_label.Text = "End Time:";
            this.EndTime_label.Visible = false;
            // 
            // StartTime_label
            // 
            this.StartTime_label.AutoSize = true;
            this.StartTime_label.Location = new System.Drawing.Point(38, 88);
            this.StartTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartTime_label.Name = "StartTime_label";
            this.StartTime_label.Size = new System.Drawing.Size(69, 13);
            this.StartTime_label.TabIndex = 12;
            this.StartTime_label.Text = "Start Time:";
            this.StartTime_label.Visible = false;
            // 
            // StartTime_combo
            // 
            this.StartTime_combo.FormattingEnabled = true;
            this.StartTime_combo.Items.AddRange(new object[] {
            "07:00 AM",
            "07:15 AM",
            "07:30 AM",
            "07:45 AM",
            "08:00 AM",
            "08:15 AM",
            "08:30 AM",
            "08:45 AM",
            "09:00 AM",
            "09:15 AM",
            "09:30 AM",
            "09:45 AM",
            "10:00 AM",
            "10:15 AM",
            "10:30 AM",
            "10:45 AM",
            "11:00 AM",
            "11:15 AM",
            "11:30 AM",
            "11:45 AM",
            "12:00 PM",
            "12:15 PM",
            "12:30 AM",
            "12:45 AM",
            "12:00 PM",
            "12:15 PM",
            "12:30 AM",
            "12:45 AM"});
            this.StartTime_combo.Location = new System.Drawing.Point(41, 111);
            this.StartTime_combo.Name = "StartTime_combo";
            this.StartTime_combo.Size = new System.Drawing.Size(200, 21);
            this.StartTime_combo.TabIndex = 10;
            this.StartTime_combo.Visible = false;
            // 
            // EndTime_combo
            // 
            this.EndTime_combo.FormattingEnabled = true;
            this.EndTime_combo.Items.AddRange(new object[] {
            "07:00 PM",
            "07:15 PM",
            "07:30 PM",
            "07:45 PM",
            "08:00 PM",
            "08:15 PM",
            "08:30 PM",
            "08:45 PM",
            "09:00 PM",
            "09:15 PM",
            "09:30 PM",
            "09:45 PM",
            "10:00 PM",
            "10:15 PM",
            "10:30 PM",
            "10:45 PM",
            "11:00 PM",
            "11:15 PM",
            "11:30 PM",
            "11:45 PM",
            "12:00 PM",
            "12:15 PM",
            "12:30 PM",
            "12:45 PM",
            "12:00 PM",
            "12:15 PM",
            "12:30 PM",
            "12:45 PM"});
            this.EndTime_combo.Location = new System.Drawing.Point(409, 111);
            this.EndTime_combo.Name = "EndTime_combo";
            this.EndTime_combo.Size = new System.Drawing.Size(200, 21);
            this.EndTime_combo.TabIndex = 11;
            this.EndTime_combo.Visible = false;
            // 
            // EndDate_label
            // 
            this.EndDate_label.AutoSize = true;
            this.EndDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate_label.Location = new System.Drawing.Point(406, 28);
            this.EndDate_label.Name = "EndDate_label";
            this.EndDate_label.Size = new System.Drawing.Size(64, 13);
            this.EndDate_label.TabIndex = 8;
            this.EndDate_label.Text = "End Date:";
            // 
            // EndDate_picker
            // 
            this.EndDate_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate_picker.Location = new System.Drawing.Point(409, 51);
            this.EndDate_picker.Name = "EndDate_picker";
            this.EndDate_picker.Size = new System.Drawing.Size(200, 20);
            this.EndDate_picker.TabIndex = 7;
            // 
            // StartDate_label
            // 
            this.StartDate_label.AutoSize = true;
            this.StartDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate_label.Location = new System.Drawing.Point(38, 28);
            this.StartDate_label.Name = "StartDate_label";
            this.StartDate_label.Size = new System.Drawing.Size(69, 13);
            this.StartDate_label.TabIndex = 6;
            this.StartDate_label.Text = "Start Date:";
            // 
            // RequestingSpecificTime_combo
            // 
            this.RequestingSpecificTime_combo.Cursor = System.Windows.Forms.Cursors.Default;
            this.RequestingSpecificTime_combo.FormattingEnabled = true;
            this.RequestingSpecificTime_combo.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.RequestingSpecificTime_combo.Location = new System.Drawing.Point(41, 66);
            this.RequestingSpecificTime_combo.Name = "RequestingSpecificTime_combo";
            this.RequestingSpecificTime_combo.Size = new System.Drawing.Size(200, 21);
            this.RequestingSpecificTime_combo.TabIndex = 7;
            this.RequestingSpecificTime_combo.Text = "No";
            this.RequestingSpecificTime_combo.TextChanged += new System.EventHandler(this.AllDayLeave_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Requesting leave for a specific time?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Request Type";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Leave of Abscence",
            "Paid Time Off",
            "Maternity ",
            "Personal",
            "Sick",
            "Family"});
            this.comboBox3.Location = new System.Drawing.Point(409, 66);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RequestingSpecificTime_combo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(162, 51);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(901, 116);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Request Info";
            // 
            // new_request_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 621);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "new_request_form";
            this.Text = "Leave Request Dashboard";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private leave_request_dashboardDataSet leave_request_dashboardDataSet;
        private System.Windows.Forms.BindingSource temprequestsBindingSource;
        private leave_request_dashboardDataSetTableAdapters.temprequestsTableAdapter temprequestsTableAdapter;
        private leave_request_dashboardDataSet1 leave_request_dashboardDataSet1;
        private System.Windows.Forms.BindingSource temprequestsBindingSource1;
        private leave_request_dashboardDataSet1TableAdapters.temprequestsTableAdapter temprequestsTableAdapter1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ToolStripMenuItem myLeaveRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myLeaveBalancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyHolidaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem createRequestToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker StartDate_picker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label EndDate_label;
        private System.Windows.Forms.DateTimePicker EndDate_picker;
        private System.Windows.Forms.Label StartDate_label;
        private System.Windows.Forms.ComboBox RequestingSpecificTime_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StartTime_combo;
        private System.Windows.Forms.ComboBox EndTime_combo;
        private System.Windows.Forms.Label StartTime_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label EndTime_label;
    }
}