using Tyuiu.UlukhanovDV.Sprint4.Task6.V26.Lib;
namespace Tyuiu.UlukhanovDV.Sprint4.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var ms = new string[] { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
            string[] res = ds.Calculate(ms);
            string[] wait = { "Тюмень", "Тамбов" };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
