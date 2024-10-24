namespace A2Graphs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            btnDisplayChart = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            studentNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            term1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            term2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            term3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            term4DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            lineChart1 = new LineChart();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineChart1).BeginInit();
            SuspendLayout();
            // 
            // btnDisplayChart
            // 
            btnDisplayChart.Location = new Point(522, 633);
            btnDisplayChart.Name = "btnDisplayChart";
            btnDisplayChart.Size = new Size(158, 29);
            btnDisplayChart.TabIndex = 7;
            btnDisplayChart.Text = "Generate Line Chart";
            btnDisplayChart.UseVisualStyleBackColor = true;
            btnDisplayChart.Click += btnDisplayChart_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 8);
            label6.Name = "label6";
            label6.Size = new Size(1275, 30);
            label6.TabIndex = 13;
            label6.Text = "Welcome to add several students for compare their performance between them. Reminder: If you saved all students, click in the button Generate Line Chart";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.UseCompatibleTextRendering = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentNameDataGridViewTextBoxColumn, term1DataGridViewTextBoxColumn, term2DataGridViewTextBoxColumn, term3DataGridViewTextBoxColumn, term4DataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentBindingSource;
            dataGridView1.Location = new Point(12, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(681, 188);
            dataGridView1.TabIndex = 16;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            studentNameDataGridViewTextBoxColumn.HeaderText = "Student_Name";
            studentNameDataGridViewTextBoxColumn.MaxInputLength = 10;
            studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            studentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // term1DataGridViewTextBoxColumn
            // 
            term1DataGridViewTextBoxColumn.DataPropertyName = "Term1";
            term1DataGridViewTextBoxColumn.HeaderText = "Term1";
            term1DataGridViewTextBoxColumn.MaxInputLength = 4;
            term1DataGridViewTextBoxColumn.MinimumWidth = 6;
            term1DataGridViewTextBoxColumn.Name = "term1DataGridViewTextBoxColumn";
            term1DataGridViewTextBoxColumn.Width = 125;
            // 
            // term2DataGridViewTextBoxColumn
            // 
            term2DataGridViewTextBoxColumn.DataPropertyName = "Term2";
            term2DataGridViewTextBoxColumn.HeaderText = "Term2";
            term2DataGridViewTextBoxColumn.MaxInputLength = 4;
            term2DataGridViewTextBoxColumn.MinimumWidth = 6;
            term2DataGridViewTextBoxColumn.Name = "term2DataGridViewTextBoxColumn";
            term2DataGridViewTextBoxColumn.Width = 125;
            // 
            // term3DataGridViewTextBoxColumn
            // 
            term3DataGridViewTextBoxColumn.DataPropertyName = "Term3";
            term3DataGridViewTextBoxColumn.HeaderText = "Term3";
            term3DataGridViewTextBoxColumn.MaxInputLength = 4;
            term3DataGridViewTextBoxColumn.MinimumWidth = 6;
            term3DataGridViewTextBoxColumn.Name = "term3DataGridViewTextBoxColumn";
            term3DataGridViewTextBoxColumn.Width = 125;
            // 
            // term4DataGridViewTextBoxColumn
            // 
            term4DataGridViewTextBoxColumn.DataPropertyName = "Term4";
            term4DataGridViewTextBoxColumn.HeaderText = "Term4";
            term4DataGridViewTextBoxColumn.MaxInputLength = 4;
            term4DataGridViewTextBoxColumn.MinimumWidth = 6;
            term4DataGridViewTextBoxColumn.Name = "term4DataGridViewTextBoxColumn";
            term4DataGridViewTextBoxColumn.ToolTipText = "Number between 0 and 4";
            term4DataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // lineChart1
            // 
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.Maximum = 4D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.Maximum = 4D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            lineChart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            lineChart1.Legends.Add(legend1);
            lineChart1.Location = new Point(699, 45);
            lineChart1.Name = "lineChart1";
            lineChart1.Size = new Size(735, 617);
            lineChart1.TabIndex = 17;
            lineChart1.Text = "lineChart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1446, 674);
            Controls.Add(lineChart1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(btnDisplayChart);
            ForeColor = Color.Maroon;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graph student's GPA by Term";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineChart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDisplayChart;
        private TextBox txtTerm1;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pgaTerm1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pgaTerm2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pgaTerm3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pgaTerm4DataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
        private LineChart lineChart2;
        private LineChart lineChart1;
        private DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn term1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn term2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn term3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn term4DataGridViewTextBoxColumn;
    }
}
