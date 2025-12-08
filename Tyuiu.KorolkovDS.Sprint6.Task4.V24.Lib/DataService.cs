using tyuiu.cources.programming.interfaces.Sprint6; 

namespace Tyuiu.KorolkovDS.Sprint6.Task4.V24.Lib
{
    public class DataService : ISprint6Task4V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (Math.Sin(x)/(x+1.2))-Math.Sin(x)*2-2*x;
                valueArray[count] = Math.Round(y, 2);
                if (y== 0)

                    valueArray[count] = 0;
                count++;

            }
            return valueArray;
        }
    }
}
