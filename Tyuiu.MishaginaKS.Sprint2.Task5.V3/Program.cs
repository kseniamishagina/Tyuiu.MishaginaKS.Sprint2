using System;
using Tyuiu.MishaginaKS.Sprint2.Task5.V3.Lib;

namespace Tyuiu.MishaginaKS.Sprint2.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Задание #5 | Вариант 3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Мишагина К. С.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По порядковому номеру дня недели (1-7) вывести на экран его название.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите порядковый номер дня недели (от 1 до 7): ");
            int dayNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string dayName = ds.FindDayName(dayNum);

            Console.WriteLine($"Название дня недели: {dayName}");

            Console.ReadKey();
        }
    }
}
