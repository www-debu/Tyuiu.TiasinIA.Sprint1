﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TiasinIA.Sprint1.Task3.V5.Lib
{
    public class DataService : ISprint1Task3V5
    {
        public double DistanceLength(double mapScale, double distanceBetweenPoints)
        {
            return distanceBetweenPoints * mapScale;
        }
    }
}
