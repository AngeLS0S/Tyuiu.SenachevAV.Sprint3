using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SenachevAV.Sprint3.Task2.V11.Lib
{
    public class DataService : ISprint3Task2V11
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;

            do
            {
                sumSeries = sumSeries + (Math.Pow(1 / 3 + Math.Pow(0.5 , 1), 1));
                startValue++;
            } while (sumSeries <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}
