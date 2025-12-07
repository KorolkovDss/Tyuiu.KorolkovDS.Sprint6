using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KorolkovDS.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = 4-2*x+((2+Math.Cos(x))/(2*x-2));
                valueArray[count] = Math.Round(y, 2);
                if (x ==1 ) 

                    valueArray[count] = 0;
                count++;

            }
            return valueArray;
        }
    }
}
