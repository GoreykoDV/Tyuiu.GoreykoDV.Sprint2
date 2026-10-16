using Tyuiu.GoreykoDV.Sprint2.Task5.V9.Lib;

namespace Tyuiu.GoreykoDV.Sprint2.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonth_EndOf31DayMonth()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfNextDay(1, 31);
            string wait = "1.2";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonth_EndOf30DayMonth()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfNextDay(4, 30);
            string wait = "1.5";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonth_February()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfNextDay(2, 28);
            string wait = "1.3";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonth_MiddleOfMonth()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfNextDay(3, 15);
            string wait = "16.3";
            Assert.AreEqual(wait, res);
        }
    }
}
