using Tyuiu.KorolkovDS.Sprint6.Task0.V26.Lib;

namespace Tyuiu.KorolkovDS.Sprint6.Task0.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void ButtonDone_KDS_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                int x = Convert.ToInt32(textBoxInPutX_KDS.Text);
                double res = ds.Calculate(x);

                textBoxResult_KDS.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonquest_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ПИНб-25-1 Корольков Дмитрий Сергеевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxInPutX_KDS_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void textBoxInPutX_KDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
