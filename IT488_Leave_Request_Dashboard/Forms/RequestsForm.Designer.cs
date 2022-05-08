
namespace IT488_Leave_Request_Dashboard
{
    partial class RequestsForm
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnNewRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFilterRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewEmployeeRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridDatabaseViewer = new System.Windows.Forms.DataGridView();
            this.panelRequestDetails = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EndTime_label = new System.Windows.Forms.Label();
            this.StartTime_label = new System.Windows.Forms.Label();
            this.comboStartHour = new System.Windows.Forms.ComboBox();
            this.comboEndHour = new System.Windows.Forms.ComboBox();
            this.EndDate_label = new System.Windows.Forms.Label();
            this.EndDate_picker = new System.Windows.Forms.DateTimePicker();
            this.StartDate_label = new System.Windows.Forms.Label();
            this.StartDate_picker = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboSpecificTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboRequestType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRequestStatus = new System.Windows.Forms.TextBox();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeny = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApprove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatabaseViewer)).BeginInit();
            this.panelRequestDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnApprove,
            this.btnDeny,
            this.btnNewRequest,
            this.btnRefreshRequests,
            this.btnFilterRequests,
            this.btnViewEmployeeRequests,
            this.btnSaveChanges,
            this.btnEditRequest,
            this.btnCancel});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip2.Size = new System.Drawing.Size(874, 42);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnNewRequest.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewRequest.ForeColor = System.Drawing.Color.Black;
            this.btnNewRequest.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Padding = new System.Windows.Forms.Padding(5);
            this.btnNewRequest.Size = new System.Drawing.Size(47, 32);
            this.btnNewRequest.Text = "New";
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);
            // 
            // btnRefreshRequests
            // 
            this.btnRefreshRequests.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRefreshRequests.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefreshRequests.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshRequests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnRefreshRequests.Name = "btnRefreshRequests";
            this.btnRefreshRequests.Padding = new System.Windows.Forms.Padding(5);
            this.btnRefreshRequests.Size = new System.Drawing.Size(65, 32);
            this.btnRefreshRequests.Text = "Refresh";
            this.btnRefreshRequests.Click += new System.EventHandler(this.refreshRequestsToolStripMenuItem_Click);
            // 
            // btnFilterRequests
            // 
            this.btnFilterRequests.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFilterRequests.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFilterRequests.ForeColor = System.Drawing.Color.Black;
            this.btnFilterRequests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnFilterRequests.Name = "btnFilterRequests";
            this.btnFilterRequests.Padding = new System.Windows.Forms.Padding(5);
            this.btnFilterRequests.Size = new System.Drawing.Size(104, 32);
            this.btnFilterRequests.Text = "Filter Requests";
            this.btnFilterRequests.Visible = false;
            // 
            // btnViewEmployeeRequests
            // 
            this.btnViewEmployeeRequests.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnViewEmployeeRequests.ForeColor = System.Drawing.Color.Black;
            this.btnViewEmployeeRequests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnViewEmployeeRequests.Name = "btnViewEmployeeRequests";
            this.btnViewEmployeeRequests.Padding = new System.Windows.Forms.Padding(5);
            this.btnViewEmployeeRequests.Size = new System.Drawing.Size(160, 32);
            this.btnViewEmployeeRequests.Text = "View Employee Requests";
            this.btnViewEmployeeRequests.Click += new System.EventHandler(this.btnViewEmployeeRequests_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Padding = new System.Windows.Forms.Padding(5);
            this.btnSaveChanges.Size = new System.Drawing.Size(48, 32);
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnEditRequest
            // 
            this.btnEditRequest.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEditRequest.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditRequest.ForeColor = System.Drawing.Color.Black;
            this.btnEditRequest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnEditRequest.Name = "btnEditRequest";
            this.btnEditRequest.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditRequest.Size = new System.Drawing.Size(42, 32);
            this.btnEditRequest.Text = "Edit";
            this.btnEditRequest.Visible = false;
            this.btnEditRequest.Click += new System.EventHandler(this.btnEditRequest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(57, 32);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridDatabaseViewer
            // 
            this.dataGridDatabaseViewer.AllowUserToAddRows = false;
            this.dataGridDatabaseViewer.AllowUserToDeleteRows = false;
            this.dataGridDatabaseViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridDatabaseViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatabaseViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDatabaseViewer.Location = new System.Drawing.Point(0, 42);
            this.dataGridDatabaseViewer.MultiSelect = false;
            this.dataGridDatabaseViewer.Name = "dataGridDatabaseViewer";
            this.dataGridDatabaseViewer.ReadOnly = true;
            this.dataGridDatabaseViewer.Size = new System.Drawing.Size(874, 596);
            this.dataGridDatabaseViewer.TabIndex = 3;
            this.dataGridDatabaseViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panelRequestDetails
            // 
            this.panelRequestDetails.Controls.Add(this.panel1);
            this.panelRequestDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRequestDetails.Location = new System.Drawing.Point(0, 42);
            this.panelRequestDetails.Name = "panelRequestDetails";
            this.panelRequestDetails.Size = new System.Drawing.Size(874, 596);
            this.panelRequestDetails.TabIndex = 4;
            this.panelRequestDetails.Visible = false;
            this.panelRequestDetails.VisibleChanged += new System.EventHandler(this.panelRequestDetails_VisibleChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(874, 596);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComments);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 133);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comments/Notes:";
            // 
            // txtComments
            // 
            this.txtComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(3, 16);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(848, 114);
            this.txtComments.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelError);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.labelHours);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.EndTime_label);
            this.groupBox2.Controls.Add(this.StartTime_label);
            this.groupBox2.Controls.Add(this.comboStartHour);
            this.groupBox2.Controls.Add(this.comboEndHour);
            this.groupBox2.Controls.Add(this.EndDate_label);
            this.groupBox2.Controls.Add(this.EndDate_picker);
            this.groupBox2.Controls.Add(this.StartDate_label);
            this.groupBox2.Controls.Add(this.StartDate_picker);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 200);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Date/Time";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(39, 91);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(36, 16);
            this.labelError.TabIndex = 20;
            this.labelError.Text = "Error!";
            this.labelError.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(796, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "8";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(796, 51);
            this.labelHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(15, 17);
            this.labelHours.TabIndex = 18;
            this.labelHours.Text = "8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(600, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Estimated Time Remaining:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(667, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estimated Hours:";
            // 
            // EndTime_label
            // 
            this.EndTime_label.AutoSize = true;
            this.EndTime_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTime_label.Location = new System.Drawing.Point(322, 127);
            this.EndTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndTime_label.Name = "EndTime_label";
            this.EndTime_label.Size = new System.Drawing.Size(69, 16);
            this.EndTime_label.TabIndex = 13;
            this.EndTime_label.Text = "End Time:";
            this.EndTime_label.Visible = false;
            // 
            // StartTime_label
            // 
            this.StartTime_label.AutoSize = true;
            this.StartTime_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTime_label.Location = new System.Drawing.Point(38, 127);
            this.StartTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartTime_label.Name = "StartTime_label";
            this.StartTime_label.Size = new System.Drawing.Size(74, 16);
            this.StartTime_label.TabIndex = 12;
            this.StartTime_label.Text = "Start Time:";
            this.StartTime_label.Visible = false;
            // 
            // comboStartHour
            // 
            this.comboStartHour.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStartHour.FormattingEnabled = true;
            this.comboStartHour.Items.AddRange(new object[] {
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
            "12:30 PM",
            "12:45 PM",
            "01:00 PM",
            "01:15 PM",
            "01:30 PM",
            "01:45 PM",
            "02:00 PM",
            "02:15 PM",
            "02:30 PM",
            "02:45 PM",
            "03:00 PM",
            "03:15 PM",
            "03:30 PM",
            "03:45 PM"});
            this.comboStartHour.Location = new System.Drawing.Point(41, 150);
            this.comboStartHour.Name = "comboStartHour";
            this.comboStartHour.Size = new System.Drawing.Size(200, 25);
            this.comboStartHour.TabIndex = 10;
            this.comboStartHour.Text = "7:00 AM";
            this.comboStartHour.Visible = false;
            this.comboStartHour.TextChanged += new System.EventHandler(this.CalculateHoursUsed);
            // 
            // comboEndHour
            // 
            this.comboEndHour.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEndHour.FormattingEnabled = true;
            this.comboEndHour.Items.AddRange(new object[] {
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
            "12:30 PM",
            "12:45 PM",
            "01:00 PM",
            "01:15 PM",
            "01:30 PM",
            "01:45 PM",
            "02:00 PM",
            "02:15 PM",
            "02:30 PM",
            "02:45 PM",
            "03:00 PM",
            "03:15 PM",
            "03:30 PM",
            "03:45 PM",
            "04:00 PM"});
            this.comboEndHour.Location = new System.Drawing.Point(325, 150);
            this.comboEndHour.Name = "comboEndHour";
            this.comboEndHour.Size = new System.Drawing.Size(200, 25);
            this.comboEndHour.TabIndex = 11;
            this.comboEndHour.Text = "8:00 AM";
            this.comboEndHour.Visible = false;
            this.comboEndHour.TextChanged += new System.EventHandler(this.CalculateHoursUsed);
            // 
            // EndDate_label
            // 
            this.EndDate_label.AutoSize = true;
            this.EndDate_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate_label.Location = new System.Drawing.Point(322, 38);
            this.EndDate_label.Name = "EndDate_label";
            this.EndDate_label.Size = new System.Drawing.Size(69, 16);
            this.EndDate_label.TabIndex = 8;
            this.EndDate_label.Text = "End Date:";
            // 
            // EndDate_picker
            // 
            this.EndDate_picker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate_picker.Location = new System.Drawing.Point(325, 61);
            this.EndDate_picker.Name = "EndDate_picker";
            this.EndDate_picker.Size = new System.Drawing.Size(200, 23);
            this.EndDate_picker.TabIndex = 7;
            this.EndDate_picker.ValueChanged += new System.EventHandler(this.CalculateHoursUsed);
            // 
            // StartDate_label
            // 
            this.StartDate_label.AutoSize = true;
            this.StartDate_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate_label.Location = new System.Drawing.Point(38, 38);
            this.StartDate_label.Name = "StartDate_label";
            this.StartDate_label.Size = new System.Drawing.Size(74, 16);
            this.StartDate_label.TabIndex = 6;
            this.StartDate_label.Text = "Start Date:";
            // 
            // StartDate_picker
            // 
            this.StartDate_picker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate_picker.Location = new System.Drawing.Point(41, 61);
            this.StartDate_picker.Name = "StartDate_picker";
            this.StartDate_picker.Size = new System.Drawing.Size(200, 23);
            this.StartDate_picker.TabIndex = 5;
            this.StartDate_picker.ValueChanged += new System.EventHandler(this.CalculateHoursUsed);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboSpecificTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboRequestType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 126);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(854, 116);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Request Info";
            // 
            // comboSpecificTime
            // 
            this.comboSpecificTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboSpecificTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSpecificTime.FormattingEnabled = true;
            this.comboSpecificTime.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboSpecificTime.Location = new System.Drawing.Point(41, 66);
            this.comboSpecificTime.Name = "comboSpecificTime";
            this.comboSpecificTime.Size = new System.Drawing.Size(200, 25);
            this.comboSpecificTime.TabIndex = 7;
            this.comboSpecificTime.Text = "No";
            this.comboSpecificTime.TextUpdate += new System.EventHandler(this.comboSpecificTime_TextUpdate);
            this.comboSpecificTime.TextChanged += new System.EventHandler(this.comboSpecificTime_TextUpdate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Requesting Hours?";
            // 
            // comboRequestType
            // 
            this.comboRequestType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRequestType.FormattingEnabled = true;
            this.comboRequestType.Items.AddRange(new object[] {
            "Paid Time Off",
            "Medical Leave",
            "Leave of Absence"});
            this.comboRequestType.Location = new System.Drawing.Point(325, 66);
            this.comboRequestType.Margin = new System.Windows.Forms.Padding(2);
            this.comboRequestType.Name = "comboRequestType";
            this.comboRequestType.Size = new System.Drawing.Size(198, 25);
            this.comboRequestType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Request Type";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtManager);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtRequestStatus);
            this.groupBox4.Controls.Add(this.txtRequestID);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(854, 116);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Request Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Manager\'s Username:";
            // 
            // txtManager
            // 
            this.txtManager.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManager.Location = new System.Drawing.Point(583, 66);
            this.txtManager.Name = "txtManager";
            this.txtManager.ReadOnly = true;
            this.txtManager.Size = new System.Drawing.Size(223, 23);
            this.txtManager.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Status:";
            // 
            // txtRequestStatus
            // 
            this.txtRequestStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestStatus.Location = new System.Drawing.Point(298, 66);
            this.txtRequestStatus.Name = "txtRequestStatus";
            this.txtRequestStatus.ReadOnly = true;
            this.txtRequestStatus.Size = new System.Drawing.Size(178, 23);
            this.txtRequestStatus.TabIndex = 12;
            // 
            // txtRequestID
            // 
            this.txtRequestID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestID.Location = new System.Drawing.Point(41, 66);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.ReadOnly = true;
            this.txtRequestID.Size = new System.Drawing.Size(146, 23);
            this.txtRequestID.TabIndex = 11;
            this.txtRequestID.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID:";
            // 
            // btnDeny
            // 
            this.btnDeny.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDeny.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeny.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeny.ForeColor = System.Drawing.Color.White;
            this.btnDeny.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Padding = new System.Windows.Forms.Padding(5);
            this.btnDeny.Size = new System.Drawing.Size(99, 32);
            this.btnDeny.Text = "Deny Request";
            this.btnDeny.Visible = false;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnApprove.BackColor = System.Drawing.Color.DarkGreen;
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Padding = new System.Windows.Forms.Padding(5);
            this.btnApprove.Size = new System.Drawing.Size(118, 32);
            this.btnApprove.Text = "Approve Request";
            this.btnApprove.Visible = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // RequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(874, 638);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridDatabaseViewer);
            this.Controls.Add(this.panelRequestDetails);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestsForm";
            this.Load += new System.EventHandler(this.RequestsForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatabaseViewer)).EndInit();
            this.panelRequestDetails.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnNewRequest;
        private System.Windows.Forms.ToolStripMenuItem btnRefreshRequests;
        private System.Windows.Forms.ToolStripMenuItem btnFilterRequests;
        private System.Windows.Forms.DataGridView dataGridDatabaseViewer;
        private System.Windows.Forms.ToolStripMenuItem btnCancel;
        private System.Windows.Forms.Panel panelRequestDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboSpecificTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRequestType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label EndTime_label;
        private System.Windows.Forms.Label StartTime_label;
        private System.Windows.Forms.ComboBox comboStartHour;
        private System.Windows.Forms.ComboBox comboEndHour;
        private System.Windows.Forms.Label EndDate_label;
        private System.Windows.Forms.DateTimePicker EndDate_picker;
        private System.Windows.Forms.Label StartDate_label;
        private System.Windows.Forms.DateTimePicker StartDate_picker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem btnEditRequest;
        private System.Windows.Forms.ToolStripMenuItem btnViewEmployeeRequests;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRequestStatus;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem btnSaveChanges;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ToolStripMenuItem btnApprove;
        private System.Windows.Forms.ToolStripMenuItem btnDeny;
    }
}