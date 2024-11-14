using Tyuiu.AlshinAF.Sprint3.Task4.V25.Lib;
namespace Tyuiu.AlshinAF.Sprint3.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double res = ds.Calculate(start, stop);
            double wait = 8.995;
            Assert.AreEqual(wait, res);
        }
    }
}