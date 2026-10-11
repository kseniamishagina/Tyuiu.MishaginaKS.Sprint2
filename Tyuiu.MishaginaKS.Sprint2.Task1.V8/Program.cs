using System;
using Tyuiu.MishaginaKS.Sprint2.Task1.V8.Lib;
namespace Tyuiu.MishaginaKS.Sprint2.Task1.V8

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

            int a = 15;
            int b = 16;
            int c = 14;
            int d = 335;

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine($"C = {c}");
            Console.WriteLine($"D = {d}");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"Элемент [{i}] = {res[i]}");
            }

            Console.ReadKey();

        }
    }
}
