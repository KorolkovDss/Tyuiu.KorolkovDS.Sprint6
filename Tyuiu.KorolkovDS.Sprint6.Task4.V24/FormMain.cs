using Tyuiu.KorolkovDS.Sprint6.Task4.V24.Lib;

namespace Tyuiu.KorolkovDS.Sprint6.Task4.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxOutPutDataFile.Text = "";
                textBoxOutPutDataFile.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxOutPutDataFile.AppendText("|    X     |    f(x)    |" + Environment.NewLine);
                textBoxOutPutDataFile.AppendText("+----------+------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}    |", startStep, valueArray[i]);
                    textBoxOutPutDataFile.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxOutPutDataFile.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask4.txt";
                File.WriteAllText(path, textBoxOutPutDataFile.Text);
                DialogResult dialogResult = MessageBox.Show("File" + path + "saved completly!\n Open it .txt?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Failed to save file", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
