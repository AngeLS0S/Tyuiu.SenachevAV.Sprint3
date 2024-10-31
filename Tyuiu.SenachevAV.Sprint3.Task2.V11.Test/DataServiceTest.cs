using Tyuiu.SenachevAV.Sprint3.Task2.V11.Lib;

namespace Tyuiu.SenachevAV.Sprint3.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 15.5;

            Assert.AreEqual(wait, res);
        }
    }
}