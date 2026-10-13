using System;
using System.Globalization;
using Tyuiu.MishaginaKS.Sprint2.Task4.V8.Lib;

namespace Tyuiu.MishaginaKS.Sprint2.Task4.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Задание #4 | Вариант 8";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Мишагина К. С.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение функции с использованием тернарного оператора.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine().Replace('.', ','), CultureInfo.GetCultureInfo("ru-RU"));

            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine().Replace('.', ','), CultureInfo.GetCultureInfo("ru-RU"));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double z = ds.Calculate(x, y);

            Console.WriteLine($"Значение Z = {z.ToString("G", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}