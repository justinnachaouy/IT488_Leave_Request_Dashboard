namespace IT488_Leave_Request_Dashboard
{
    partial class Balance_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Deny_butt = new System.Windows.Forms.Button();
            this.Approve_butt = new System.Windows.Forms.Button();
            this.Search_butt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pending_box = new System.Windows.Forms.CheckBox();
            this.Deny_box = new System.Windows.Forms.CheckBox();
            this.Aprrove_box = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Cancel_butt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Deny_butt);
            this.groupBox1.Controls.Add(this.Approve_butt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager Options";
            // 
            // Deny_butt
            // 
            this.Deny_butt.Image = global::IT488_Leave_Request_Dashboard.Properties.Resources.Deny;
            this.Deny_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deny_butt.Location = new System.Drawing.Point(82, 18);
            this.Deny_butt.Name = "Deny_butt";
            this.Deny_butt.Size = new System.Drawing.Size(53, 28);
            this.Deny_butt.TabIndex = 2;
            this.Deny_butt.Text = "Deny";
            this.Deny_butt.UseVisualStyleBackColor = true;
            this.Deny_butt.Click += new System.EventHandler(this.Deny_butt_Click);
            // 
            // Approve_butt
            // 
            this.Approve_butt.Image = global::IT488_Leave_Request_Dashboard.Properties.Resources.checkmark;
            this.Approve_butt.Location = new System.Drawing.Point(0, 21);
            this.Approve_butt.Name = "Approve_butt";
            this.Approve_butt.Size = new System.Drawing.Size(76, 23);
            this.Approve_butt.TabIndex = 0;
            this.Approve_butt.Text = "Aprove";
            this.Approve_butt.UseVisualStyleBackColor = true;
            this.Approve_butt.Click += new System.EventHandler(this.Approve_butt_Click);
            // 
            // Search_butt
            // 
            this.Search_butt.Location = new System.Drawing.Point(127, 194);
            this.Search_butt.Name = "Search_butt";
            this.Search_butt.Size = new System.Drawing.Size(71, 24);
            this.Search_butt.TabIndex = 1;
            this.Search_butt.Text = "Search";
            this.Search_butt.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 199);
            this.dataGridView1.TabIndex = 1;
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(12, 83);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(48, 16);
            this.Name_label.TabIndex = 2;
            this.Name_label.Text = "Name";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(12, 153);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(96, 16);
            this.ID_label.TabIndex = 3;
            this.ID_label.Text = "Employee ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Pending_box);
            this.groupBox2.Controls.Add(this.Deny_box);
            this.groupBox2.Controls.Add(this.Aprrove_box);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(496, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View by:";
            // 
            // Pending_box
            // 
            this.Pending_box.AutoSize = true;
            this.Pending_box.Location = new System.Drawing.Point(7, 108);
            this.Pending_box.Name = "Pending_box";
            this.Pending_box.Size = new System.Drawing.Size(86, 20);
            this.Pending_box.TabIndex = 2;
            this.Pending_box.Text = "Pending";
            this.Pending_box.UseVisualStyleBackColor = true;
            // 
            // Deny_box
            // 
            this.Deny_box.AutoSize = true;
            this.Deny_box.Location = new System.Drawing.Point(7, 70);
            this.Deny_box.Name = "Deny_box";
            this.Deny_box.Size = new System.Drawing.Size(79, 20);
            this.Deny_box.TabIndex = 1;
            this.Deny_box.Text = "Denied";
            this.Deny_box.UseVisualStyleBackColor = true;
            // 
            // Aprrove_box
            // 
            this.Aprrove_box.AutoSize = true;
            this.Aprrove_box.Location = new System.Drawing.Point(7, 31);
            this.Aprrove_box.Name = "Aprrove_box";
            this.Aprrove_box.Size = new System.Drawing.Size(97, 20);
            this.Aprrove_box.TabIndex = 0;
            this.Aprrove_box.Text = "Approved";
            this.Aprrove_box.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 22);
            this.textBox2.TabIndex = 6;
            // 
            // Cancel_butt
            // 
            this.Cancel_butt.Location = new System.Drawing.Point(246, 195);
            this.Cancel_butt.Name = "Cancel_butt";
            this.Cancel_butt.Size = new System.Drawing.Size(75, 23);
            this.Cancel_butt.TabIndex = 7;
            this.Cancel_butt.Text = "Cancel";
            this.Cancel_butt.UseVisualStyleBackColor = true;
            this.Cancel_butt.Click += new System.EventHandler(this.Cancel_butt_Click);
            // 
            // Balance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel_butt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Search_butt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Balance_Form";
            this.Text = "Balance";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Deny_butt;
        private System.Windows.Forms.Button Search_butt;
        private System.Windows.Forms.Button Approve_butt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Pending_box;
        private System.Windows.Forms.CheckBox Deny_box;
        private System.Windows.Forms.CheckBox Aprrove_box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Cancel_butt;
    }
}