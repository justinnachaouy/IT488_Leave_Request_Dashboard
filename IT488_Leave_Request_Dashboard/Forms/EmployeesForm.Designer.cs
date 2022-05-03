
namespace IT488_Leave_Request_Dashboard
{
    partial class EmployeesForm
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
            this.newRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridDatabaseViewer = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatabaseViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRequestToolStripMenuItem,
            this.refreshRequestsToolStripMenuItem,
            this.filterRequestsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip2.Size = new System.Drawing.Size(1070, 42);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // newRequestToolStripMenuItem
            // 
            this.newRequestToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.newRequestToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newRequestToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.newRequestToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.newRequestToolStripMenuItem.Name = "newRequestToolStripMenuItem";
            this.newRequestToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.newRequestToolStripMenuItem.Size = new System.Drawing.Size(47, 32);
            this.newRequestToolStripMenuItem.Text = "New";
            // 
            // refreshRequestsToolStripMenuItem
            // 
            this.refreshRequestsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshRequestsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.refreshRequestsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.refreshRequestsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.refreshRequestsToolStripMenuItem.Name = "refreshRequestsToolStripMenuItem";
            this.refreshRequestsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.refreshRequestsToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.refreshRequestsToolStripMenuItem.Text = "Refresh";
            this.refreshRequestsToolStripMenuItem.Click += new System.EventHandler(this.refreshRequestsToolStripMenuItem_Click);
            // 
            // filterRequestsToolStripMenuItem
            // 
            this.filterRequestsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.filterRequestsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.filterRequestsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.filterRequestsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filterRequestsToolStripMenuItem.Name = "filterRequestsToolStripMenuItem";
            this.filterRequestsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.filterRequestsToolStripMenuItem.Size = new System.Drawing.Size(50, 32);
            this.filterRequestsToolStripMenuItem.Text = "Filter";
            this.filterRequestsToolStripMenuItem.Visible = false;
            // 
            // dataGridDatabaseViewer
            // 
            this.dataGridDatabaseViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatabaseViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDatabaseViewer.Location = new System.Drawing.Point(0, 42);
            this.dataGridDatabaseViewer.Name = "dataGridDatabaseViewer";
            this.dataGridDatabaseViewer.Size = new System.Drawing.Size(1070, 579);
            this.dataGridDatabaseViewer.TabIndex = 3;
            this.dataGridDatabaseViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1070, 621);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridDatabaseViewer);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesForm";
            this.Load += new System.EventHandler(this.RequestsForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatabaseViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem newRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterRequestsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridDatabaseViewer;
    }
}