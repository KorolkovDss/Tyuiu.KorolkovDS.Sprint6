using System.IO;
using System.Windows.Forms;
using Tyuiu.KorolkovDS.Sprint6.Task5.V22.Lib;

namespace Tyuiu.KorolkovDS.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path = Path.Combine(Path.GetFullPath("InPutDataFileTask5V22.txt"));
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            this.chart1.ChartAreas[0].AxisX.Title = " Axis X";
            this.chart1.ChartAreas[0].AxisX.Title = "Axis Y";
            chart1.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chart1.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
    }
    
}
