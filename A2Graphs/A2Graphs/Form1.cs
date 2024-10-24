namespace A2Graphs
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataError += dataGridView1_DataError;
        }

        private void btnDisplayChart_Click(object sender, EventArgs e)
        {
            this.lineChart1.InitializeGraph();
            //Clear
            this.lineChart1.Series.Clear();

            //Random color
            Random random = new Random();


            //Loop Rows
            foreach (Student s in studentBindingSource.DataSource as List<Student>)
            {
                if (string.IsNullOrEmpty(s.Student_Name))
                {
                    MessageBox.Show("Invalid input. Reminder: Student Name should not be empty or null.");
                }
                else
                {
                    this.lineChart1.Series.Add(s.Student_Name);
                    this.lineChart1.Series[s.Student_Name].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    this.lineChart1.Series[s.Student_Name].Legend = "Legend1";
                    this.lineChart1.Series[s.Student_Name].ChartArea = "ChartArea1";
                    this.lineChart1.Series[s.Student_Name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                    //Adding data

                    if (s.Term1 > 4 || s.Term2 > 4 || s.Term3 > 4 || s.Term4 > 4 || s.Term1 < 0 || s.Term2 < 0 || s.Term3 < 0 || s.Term4 < 0)
                    {
                        MessageBox.Show("Invalid input. Reminder: Each Term GPA must be a number between 0 and 4.");
                    }
                    else
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            this.lineChart1.Series[s.Student_Name].Points.AddXY(i, Convert.ToDouble(s[$"Term{i}"]));
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = new List<Student>();
        }


        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Reminder: Each Term GPA must be a number. Data error in row {e.RowIndex}, column {e.ColumnIndex}: {e.Exception.Message}",
                            "Data Error.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            e.ThrowException = false; // Prevent throwing an exception
        }
    }
}
