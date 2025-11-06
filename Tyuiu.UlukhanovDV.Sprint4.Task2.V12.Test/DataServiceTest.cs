using Tyuiu.UlukhanovDV.Sprint4.Task2.V12.Lib;
namespace Tyuiu.UlukhanovDV.Sprint4.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 6, 7, 8, 6, 5, 6, 8, 8 };
            int res = ds.Calculate(numsArray);
            int wait = 12;
            Assert.AreEqual(res, wait);
        }
    }
}
