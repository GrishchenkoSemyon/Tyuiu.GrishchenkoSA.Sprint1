using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GrishchenkoSA.Sprint1.Task1.V12.Lib
{
    public class DataService : ISprint1Task1V12
    {
        public double Calculate(double x, double y)
        {
            double result = (x + y) / 6;
return Math.Round(result, 3);
        }
    }
}
