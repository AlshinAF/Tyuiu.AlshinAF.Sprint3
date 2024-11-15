using Tyuiu.AlshinAF.Sprint3.Task5.V6.Lib;
namespace Tyuiu.AlshinAF.Sprint3.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start1 = 1;
            int start2 = 1;
            int stop1 = 3;
            int stop2 = 10;
            double res = ds.GetSumSumSeries(start1, start2, stop1, stop2);
            double wait = 40.917;
            Assert.AreEqual(res, wait);
        }
    }
}