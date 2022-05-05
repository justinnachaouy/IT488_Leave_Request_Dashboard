
namespace IT488_Leave_Request_Dashboard
{
    partial class ReportsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartRequestsByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRequestsByType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRequestsByEmployee = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRequestsByStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRequestsByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRequestsByType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRequestsByEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRequestsByStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartRequestsByStatus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartRequestsByType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartRequestsByMonth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartRequestsByEmployee, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 638);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // chartRequestsByMonth
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRequestsByMonth.ChartAreas.Add(chartArea3);
            this.chartRequestsByMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartRequestsByMonth.Legends.Add(legend3);
            this.chartRequestsByMonth.Location = new System.Drawing.Point(484, 3);
            this.chartRequestsByMonth.Name = "chartRequestsByMonth";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Requests";
            this.chartRequestsByMonth.Series.Add(series3);
            this.chartRequestsByMonth.Size = new System.Drawing.Size(475, 313);
            this.chartRequestsByMonth.TabIndex = 4;
            this.chartRequestsByMonth.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Requests by Month";
            this.chartRequestsByMonth.Titles.Add(title3);
            // 
            // chartRequestsByType
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRequestsByType.ChartAreas.Add(chartArea2);
            this.chartRequestsByType.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartRequestsByType.Legends.Add(legend2);
            this.chartRequestsByType.Location = new System.Drawing.Point(484, 322);
            this.chartRequestsByType.Name = "chartRequestsByType";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Requests";
            this.chartRequestsByType.Series.Add(series2);
            this.chartRequestsByType.Size = new System.Drawing.Size(475, 313);
            this.chartRequestsByType.TabIndex = 6;
            this.chartRequestsByType.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Requests by Type";
            this.chartRequestsByType.Titles.Add(title2);
            // 
            // chartRequestsByEmployee
            // 
            chartArea4.Name = "ChartArea1";
            this.chartRequestsByEmployee.ChartAreas.Add(chartArea4);
            this.chartRequestsByEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartRequestsByEmployee.Legends.Add(legend4);
            this.chartRequestsByEmployee.Location = new System.Drawing.Point(3, 3);
            this.chartRequestsByEmployee.Name = "chartRequestsByEmployee";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Requests";
            this.chartRequestsByEmployee.Series.Add(series4);
            this.chartRequestsByEmployee.Size = new System.Drawing.Size(475, 313);
            this.chartRequestsByEmployee.TabIndex = 7;
            this.chartRequestsByEmployee.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Requests by Employee";
            this.chartRequestsByEmployee.Titles.Add(title4);
            // 
            // chartRequestsByStatus
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRequestsByStatus.ChartAreas.Add(chartArea1);
            this.chartRequestsByStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRequestsByStatus.Legends.Add(legend1);
            this.chartRequestsByStatus.Location = new System.Drawing.Point(3, 322);
            this.chartRequestsByStatus.Name = "chartRequestsByStatus";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Requests";
            this.chartRequestsByStatus.Series.Add(series1);
            this.chartRequestsByStatus.Size = new System.Drawing.Size(475, 313);
            this.chartRequestsByStatus.TabIndex = 8;
            this.chartRequestsByStatus.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Requests by Status";
            this.chartRequestsByStatus.Titles.Add(title1);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 638);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRequestsByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRequestsByType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRequestsByEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRequestsByStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRequestsByStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRequestsByType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRequestsByMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRequestsByEmployee;
    }
}