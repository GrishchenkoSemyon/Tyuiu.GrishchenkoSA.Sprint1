using System;
using Tyuiu.GrishchenkoSA.Sprint1.Task6.V11.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint1.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Грищенко С. А. | ИСПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки C#                                                 *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                              *");
            Console.WriteLine("* Выполнил: Грищенко С. А. | ИСПб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Выполнить расчет по заданию согласно варианту                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            try
            {
                var result = ds.CheckeFirstLetterRepetition("ананас");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}
