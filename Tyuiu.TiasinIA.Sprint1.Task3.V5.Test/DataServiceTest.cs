using Tyuiu.TiasinIA.Sprint1.Task3.V5.Lib;

namespace Tyuiu.TiasinIA.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidEspression()
        {
            DataService ds = new DataService();
            double x = 3.5;
            double y = 120;
            double z = 420;
            var res = ds.DistanceLength(x, y);
            Assert.AreEqual(z, res);
        }
    }
}