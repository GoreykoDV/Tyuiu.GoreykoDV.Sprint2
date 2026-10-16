using Tyuiu.GoreykoDV.Sprint2.Task7.V4.Lib;

namespace Tyuiu.GoreykoDV.Sprint2.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidChekDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.4;
            double y = 0.6;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
