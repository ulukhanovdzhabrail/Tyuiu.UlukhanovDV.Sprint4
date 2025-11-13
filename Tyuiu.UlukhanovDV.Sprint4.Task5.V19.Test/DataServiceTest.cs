using Tyuiu.UlukhanovDV.Sprint4.Task5.V19.Lib;
namespace Tyuiu.UlukhanovDV.Sprint4.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] { { 1, 3, -2, 1, -2, }, { 3, -1, 3, -2, 0, }, { 0, 3, -2, -2, -1, }, { 3, -1, -2, 3, 0, }, { 0, -1, 3, 0, -2, } };
            int res = ds.Calculate(mas);
            int wait = 9;
            Assert.AreEqual(res, wait);
        }
    }
}
