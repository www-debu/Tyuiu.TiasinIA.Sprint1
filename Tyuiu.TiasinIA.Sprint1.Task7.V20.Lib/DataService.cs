﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TiasinIA.Sprint1.Task7.V20.Lib
{
    public class DataService : ISprint1Task7V20

    {
        public double Calculate(double x, double y)
        {
            double z = 0;
            z = Math.Round((2 + Math.Pow(Math.Cos((x + y)), 2)) / (1 + Math.Abs(x - ((3 * x) / (1 + (Math.Pow(x, 2) * Math.Pow(y, 2)))))) + x * y, 3);
            return z;
        }
       
    }
}
