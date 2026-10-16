using Tyuiu.GoreykoDV.Sprint2.Task1.V23.Lib;

namespace Tyuiu.GoreykoDV.Sprint2.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a =242;
            int b = 571;
            int c = 325;
            int d = 155;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, false, true, true, true };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
