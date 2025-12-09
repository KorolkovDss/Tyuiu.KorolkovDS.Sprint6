using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KorolkovDS.Sprint6.Task7.V24.Lib
{
    public class DataService : ISprint6Task7V24
    {
        public int[,] GetMatrix(string path)
        {

            int rows = File.ReadLines(path).Count();
            string[] strings = File.ReadAllText(path).Split("\n");
            int columns = strings[0].Split(';').Length;
            int[,] matrix = new int[rows, columns];

            using (StreamReader stream = new StreamReader(path))
            {
                string line;
                int count = 0;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] row = line.Split(';');
                    for (int i = 0; i < columns; i++)
                    {
                        matrix[count, i] = Convert.ToInt32(row[i]);
                    }
                    count++;
                }
            }

            for (int j = 0; j < columns; j++)
            {
                if (matrix[1, j] % 2 == 0) matrix[1, j] = 1;
            }
            return matrix;
        }
    }
}
