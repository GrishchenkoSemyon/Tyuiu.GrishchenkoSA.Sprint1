using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GrishchenkoSA.Sprint1.Task7.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double Calculate(double a, double b, double c)
        {
            double term1 = (b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
double term2 = Math.Pow(a, 3) * c + Math.Pow(b, -2);
double z = term1 - term2;
return Math.Round(z, 3);
        }
    }
}
