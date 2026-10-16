using Tyuiu.GoreykoDV.Sprint2.Task4.V20.Lib;

namespace Tyuiu.GoreykoDV.Sprint2.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 0.403;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 8;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 63.9;
            Assert.AreEqual(wait, res);
        }
    }
}