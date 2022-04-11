
namespace IT488_Leave_Request_Dashboard
{
    partial class requests_form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myLeaveRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myLeaveBalancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyHolidaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.newRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approverFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approverLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temprequestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.leave_request_dashboardDataSet1 = new IT488_Leave_Request_Dashboard.leave_request_dashboardDataSet1();
            this.leave_request_dashboardDataSet = new IT488_Leave_Request_Dashboard.leave_request_dashboardDataSet();
            this.temprequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temprequestsTableAdapter = new IT488_Leave_Request_Dashboard.leave_request_dashboardDataSetTableAdapters.temprequestsTableAdapter();
            this.temprequestsTableAdapter1 = new IT488_Leave_Request_Dashboard.leave_request_dashboardDataSet1TableAdapters.temprequestsTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // myLeaveRequestsToolStripMenuItem
            // 
            this.myLeaveRequestsToolStripMenuItem.Name = "myLeaveRequestsToolStripMenuItem";
            this.myLeaveRequestsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myLeaveRequestsToolStripMenuItem.Size = new System.Drawing.Size(141, 33);
            this.myLeaveRequestsToolStripMenuItem.Text = "My Leave Requests";
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
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRequestToolStripMenuItem,
            this.refreshRequestsToolStripMenuItem,
            this.filterRequestsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1070, 42);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // newRequestToolStripMenuItem
            // 
            this.newRequestToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.newRequestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newRequestToolStripMenuItem.Name = "newRequestToolStripMenuItem";
            this.newRequestToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.newRequestToolStripMenuItem.Size = new System.Drawing.Size(90, 38);
            this.newRequestToolStripMenuItem.Text = "New Request";
            this.newRequestToolStripMenuItem.Click += new System.EventHandler(this.newRequestToolStripMenuItem_Click);
            // 
            // refreshRequestsToolStripMenuItem
            // 
            this.refreshRequestsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshRequestsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.refreshRequestsToolStripMenuItem.Name = "refreshRequestsToolStripMenuItem";
            this.refreshRequestsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.refreshRequestsToolStripMenuItem.Size = new System.Drawing.Size(110, 38);
            this.refreshRequestsToolStripMenuItem.Text = "Refresh Requests";
            // 
            // filterRequestsToolStripMenuItem
            // 
            this.filterRequestsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.filterRequestsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.filterRequestsToolStripMenuItem.Name = "filterRequestsToolStripMenuItem";
            this.filterRequestsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.filterRequestsToolStripMenuItem.Size = new System.Drawing.Size(97, 38);
            this.filterRequestsToolStripMenuItem.Text = "Filter Requests";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.approverFirstNameDataGridViewTextBoxColumn,
            this.approverLastNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.temprequestsBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(154, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(916, 579);
            this.dataGridView1.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // approverFirstNameDataGridViewTextBoxColumn
            // 
            this.approverFirstNameDataGridViewTextBoxColumn.DataPropertyName = "ApproverFirstName";
            this.approverFirstNameDataGridViewTextBoxColumn.HeaderText = "ApproverFirstName";
            this.approverFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.approverFirstNameDataGridViewTextBoxColumn.Name = "approverFirstNameDataGridViewTextBoxColumn";
            this.approverFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.approverFirstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // approverLastNameDataGridViewTextBoxColumn
            // 
            this.approverLastNameDataGridViewTextBoxColumn.DataPropertyName = "ApproverLastName";
            this.approverLastNameDataGridViewTextBoxColumn.HeaderText = "ApproverLastName";
            this.approverLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.approverLastNameDataGridViewTextBoxColumn.Name = "approverLastNameDataGridViewTextBoxColumn";
            this.approverLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.approverLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "Start Date";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "End Date";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Width = 125;
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
            // requests_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "requests_form";
            this.Text = "Leave Request Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.requests_form_Closed);
            this.Load += new System.EventHandler(this.requests_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myLeaveRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myLeaveBalancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyHolidaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem newRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterRequestsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private leave_request_dashboardDataSet leave_request_dashboardDataSet;
        private System.Windows.Forms.BindingSource temprequestsBindingSource;
        private leave_request_dashboardDataSetTableAdapters.temprequestsTableAdapter temprequestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approverFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approverLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private leave_request_dashboardDataSet1 leave_request_dashboardDataSet1;
        private System.Windows.Forms.BindingSource temprequestsBindingSource1;
        private leave_request_dashboardDataSet1TableAdapters.temprequestsTableAdapter temprequestsTableAdapter1;
    }
}