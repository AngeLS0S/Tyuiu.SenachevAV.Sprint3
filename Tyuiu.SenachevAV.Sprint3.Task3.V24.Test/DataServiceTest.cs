using Tyuiu.SenachevAV.Sprint3.Task3.V24.Lib;

namespace Tyuiu.SenachevAV.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();

            var res = ds.ReplaceCharInString("gft hggt ntg", 'g', '*');
            Assert.AreEqual("*ft h**t nt*", res);
        }
    }
}