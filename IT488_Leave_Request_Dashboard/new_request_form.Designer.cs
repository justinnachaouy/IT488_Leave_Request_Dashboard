
namespace IT488_Leave_Request_Dashboard
{
    partial class new_requests_form
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
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1070, 42);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
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
            // new_requests_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 621);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "new_requests_form";
            this.Text = "Leave Request Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.requests_form_Closed);
            this.Load += new System.EventHandler(this.requests_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_request_dashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temprequestsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}