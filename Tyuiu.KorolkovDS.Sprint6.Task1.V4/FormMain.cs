using Tyuiu.KorolkovDS.Sprint6.Task1.V4.Lib;

namespace Tyuiu.KorolkovDS.Sprint6.Task1.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int startStep = Convert.ToInt32(textBoxStart_KDS.Text);
                int stopStep = Convert.ToInt32(textBoxStop_KDS.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxRes_KDS.Text = "";
                textBoxRes_KDS.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxRes_KDS.AppendText("|    X     |    f(x)    |" + Environment.NewLine);
                textBoxRes_KDS.AppendText("+----------+------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}    |", startStep, valueArray[i]);
                    textBoxRes_KDS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxRes_KDS.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 
    }
}
