
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EndDate_label = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.AllDayLeave_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createRequestToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1427, 52);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // createRequestToolStripMenuItem
            // 
            this.createRequestToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.createRequestToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createRequestToolStripMenuItem.Name = "createRequestToolStripMenuItem";
            this.createRequestToolStripMenuItem.Size = new System.Drawing.Size(123, 48);
            this.createRequestToolStripMenuItem.Text = "Create Request";
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
            this.myLeaveRequestsToolStripMenuItem.Size = new System.Drawing.Size(164, 37);
            this.myLeaveRequestsToolStripMenuItem.Text = "My Leave Requests";
            // 
            // myLeaveBalancesToolStripMenuItem
            // 
            this.myLeaveBalancesToolStripMenuItem.Name = "myLeaveBalancesToolStripMenuItem";
            this.myLeaveBalancesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myLeaveBalancesToolStripMenuItem.Size = new System.Drawing.Size(164, 37);
            this.myLeaveBalancesToolStripMenuItem.Text = "My Leave Balances";
            // 
            // companyHolidaysToolStripMenuItem
            // 
            this.companyHolidaysToolStripMenuItem.Name = "companyHolidaysToolStripMenuItem";
            this.companyHolidaysToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyHolidaysToolStripMenuItem.Size = new System.Drawing.Size(164, 37);
            this.companyHolidaysToolStripMenuItem.Text = "Company Holidays";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 37);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(164, 37);
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 52);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(181, 712);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(209, 436);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1213, 329);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comments/Notes:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1205, 305);
            this.textBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 53);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.EndDate_label);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(209, 284);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1213, 144);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Date/Time";
            // 
            // EndDate_label
            // 
            this.EndDate_label.AutoSize = true;
            this.EndDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate_label.Location = new System.Drawing.Point(352, 33);
            this.EndDate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndDate_label.Name = "EndDate_label";
            this.EndDate_label.Size = new System.Drawing.Size(80, 17);
            this.EndDate_label.TabIndex = 8;
            this.EndDate_label.Text = "End Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(348, 53);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 23);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Date:";
            // 
            // AllDayLeave_combo
            // 
            this.AllDayLeave_combo.Cursor = System.Windows.Forms.Cursors.Default;
            this.AllDayLeave_combo.FormattingEnabled = true;
            this.AllDayLeave_combo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.AllDayLeave_combo.Location = new System.Drawing.Point(357, 90);
            this.AllDayLeave_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllDayLeave_combo.Name = "AllDayLeave_combo";
            this.AllDayLeave_combo.Size = new System.Drawing.Size(220, 24);
            this.AllDayLeave_combo.TabIndex = 7;
            this.AllDayLeave_combo.Text = "Yes";
            this.AllDayLeave_combo.TextChanged += new System.EventHandler(this.AllDayLeave_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "All Day Leave?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(12, 98);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 25);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(348, 97);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 25);
            this.comboBox2.TabIndex = 11;
            // 
            // new_request_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 764);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AllDayLeave_combo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "new_request_form";
            this.Text = "Leave Request Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.requests_form_Closed);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label EndDate_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AllDayLeave_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}