using Tyuiu.MishaginaKS.Sprint2.Task0.V4.Lib;
using System;
namespace Tyuiu.MishaginaKS.Sprint2.Task0.V4

{
    class Program

    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Мишагина К. С. | АСОиУБ-26-1";

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x = 333;
            int y = 324;
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            bool[] res = ds.GetCompareOperations(x, y);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"Элемент [{i}] = {res[i]}");
            }

            Console.ReadKey();

        }
    }
}