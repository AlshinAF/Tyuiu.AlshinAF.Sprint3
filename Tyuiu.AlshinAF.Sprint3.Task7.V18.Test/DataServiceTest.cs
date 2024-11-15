using Tyuiu.AlshinAF.Sprint3.Task7.V18.Lib;

namespace Tyuiu.AlshinAF.Sprint3.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1; //длина массива, +1, чтобы посчитать 0
            double[] valueWaitArray = new double[len]; //создаём массив
            valueWaitArray[0] = 7/76;
            valueWaitArray[1] = 0;
            valueWaitArray[2] = 0;
            valueWaitArray[3] = 0;
            valueWaitArray[4] = 0;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = 0;
            valueWaitArray[7] = 0;
            valueWaitArray[8] = 0;
            valueWaitArray[9] = 0;
            valueWaitArray[10] = 0;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}