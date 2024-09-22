using Tyuiu.TiasinIA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.TiasinIA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int time = 13257;
            double otv = 3;
            var res = ds.SecondsToHours(time);
            Assert.AreEqual(otv, res);
        }
    }
}