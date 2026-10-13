using Tyuiu.MishaginaKS.Sprint2.Task6.V13.Lib;
using System;

namespace Tyuiu.MishaginaKS.Sprint2.Task5.V13;

class Program

{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Задание #5 | Вариант 13";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С.                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* По заданным g, m и n определить дату следующего дня (год високосный).    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите год (g): ");
        int g = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер месяца (m): ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите день (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string nextDate = ds.FindDateOfNextDay(g, m, n);

        Console.WriteLine($"Дата следующего дня: {nextDate}");

        Console.ReadKey();
    }
}