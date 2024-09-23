using Tyuiu.TiasinIA.Sprint1.Task6.V9.Lib;
namespace Tyuiu.TiasinIA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string wrds = "отр ортт";
            DataService ds = new DataService();
            string res = ds.MoveLetterToStart(wrds);
            string itog = "рот торт";
            Assert.AreEqual(itog, res);
        }
    }
}