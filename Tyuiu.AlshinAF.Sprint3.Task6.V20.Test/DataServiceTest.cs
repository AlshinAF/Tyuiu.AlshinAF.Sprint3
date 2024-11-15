using Tyuiu.AlshinAF.Sprint3.Task6.V20.Lib;
namespace Tyuiu.AlshinAF.Sprint3.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 20;
            int stopValue = 32;
            int wait = 41;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(res, wait);
        }
    }
}