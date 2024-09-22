using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TiasinIA.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            double sd = 86400;
            double hd = 24;
            double a = Convert.ToDouble(time);

            a = Math.Floor(hd - ((sd - a) / 3600));
            return (int) a;
        }
    }
}
