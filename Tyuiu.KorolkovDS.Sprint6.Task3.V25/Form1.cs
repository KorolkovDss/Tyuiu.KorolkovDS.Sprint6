using Tyuiu.KorolkovDS.Sprint6.Task3.V25.Lib; 

using System.Drawing.Drawing2D;

namespace Tyuiu.KorolkovDS.Sprint6.Task3.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = {     {14, 5, -9, 18, 21 },
                              {-5, -12, -12, 4, 28 },
                              {27, -2, -14, 23, 27 },
                              {-19, -15, 17, 15, 1 },
                              {33, 2, 6, 24, 24 } };

        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {

            int[,] mtrx = ds.Calculate(matrix);
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);

            dataGridMatrixResult.RowCount = rows;
            dataGridMatrixResult.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                dataGridMatrixResult.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridMatrixResult.Rows[i].Cells[j].Value = mtrx[i, j].ToString();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridMatrix.RowCount = rows;
            dataGridMatrix.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                dataGridMatrix.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
        }
    }
}
