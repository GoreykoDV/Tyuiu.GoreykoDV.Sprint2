using Tyuiu.GoreykoDV.Sprint2.Task3.V2.Lib;

namespace Tyuiu.GoreykoDV.Sprint2.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 4; 
            double res = ds.Calculate(x);
            double wait = -44.654;
            Assert.AreEqual(wait,res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 1.5;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -0.577;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -7;
            double res = ds.Calculate(x);
            double wait = -77.000;
            Assert.AreEqual(wait, res);
        }
    }
}
