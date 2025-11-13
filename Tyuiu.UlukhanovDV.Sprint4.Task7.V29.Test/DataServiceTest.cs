using Tyuiu.UlukhanovDV.Sprint4.Task7.V29.Lib;
namespace Tyuiu.UlukhanovDV.Sprint4.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int r = 4;
            int c = 3;
            int[,] mas = new int[r, c];
            string s = "983157642891";
            DataService ds = new DataService();
            int res = ds.Calculate(r, c, s);
            int wait = 28;
            Assert.AreEqual(wait, res);

        }
    }
}
