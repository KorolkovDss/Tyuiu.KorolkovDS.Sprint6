using Tyuiu.KorolkovDS.Sprint6.Task6.V19.Lib;

namespace Tyuiu.KorolkovDS.Sprint6.Task6.V19
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        string openFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            string str = "l";
            textBoxResult.Text = ds.CollectTextFromFile(str);
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            openFilePath = openFileDialog.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + openFileDialog.FileName;
            buttonDone.Enabled = true;
        }
    }
}
