using Tyuiu.KorolkovDS.Sprint6.Task2.V23.Lib;

namespace Tyuiu.KorolkovDS.Sprint6.Task2.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int startStep = Convert.ToInt32(textBoxStartV_KDS.Text);
                int stopStep = Convert.ToInt32(textBoxStopV_KDS.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chart1.Titles.Add("График функции");
                this.chart1.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len - 1; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chart1.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStartV_KDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxStopV_KDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
