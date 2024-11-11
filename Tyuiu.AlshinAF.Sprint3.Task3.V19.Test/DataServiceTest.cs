using Tyuiu.AlshinAF.Sprint3.Task3.V19.Lib;
namespace Tyuiu.AlshinAF.Sprint3.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value  = "sxxrrg x vfrx";
            char r = 'x';
            char rep = '2';
            string res = ds.ReplaceCharOnNum(value, r, rep);
            string wait = "s22rrg 2 vfr2";
            Assert.AreEqual(wait, res);
        }
    }
}