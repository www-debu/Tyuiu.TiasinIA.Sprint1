using Tyuiu.TiasinIA.Sprint1.Task1.V25.Lib;

namespace Tyuiu.TiasinIA.Sprint1.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Double x = 1;
            Double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}