using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GrishchenkoSA.Sprint1.Task7.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double Calculate(double a, double b, double c)
        {
            double numerator = b + Math.Sqrt(b * b + 4 * a * c);
double denominator = 2 * a;
double term1 = numerator / denominator;
double term2 = Math.Pow(a, 3) * c;
double term3 = Math.Pow(b, -2);
double result = term1 - term2 + term3;
return Math.Round(result, 3);
        }
    }
}
