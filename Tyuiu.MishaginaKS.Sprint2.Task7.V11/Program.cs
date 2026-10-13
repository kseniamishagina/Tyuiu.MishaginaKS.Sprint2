using System;
using System.Globalization;
using Tyuiu.MishaginaKS.Sprint2.Task7.V11.Lib;

namespace Tyuiu.MishaginaKS.Sprint2.Task6.V11;

class Program

{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Задание #7 | Вариант 11";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С.                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Определить, находится ли точка с координатами X, Y в заштрихованной зоне.*");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите координату X: ");
        double x = Convert.ToDouble(Console.ReadLine().Replace('.', ','), CultureInfo.GetCultureInfo("ru-RU"));

        Console.Write("Введите координату Y: ");
        double y = Convert.ToDouble(Console.ReadLine().Replace('.', ','), CultureInfo.GetCultureInfo("ru-RU"));

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool res = ds.CheckDotInShadedArea(x, y);

        if (res)
        {
            Console.WriteLine("Точка НАХОДИТСЯ в заштрихованной области.");
        }
        else
        {
            Console.WriteLine("Точка НЕ НАХОДИТСЯ в заштрихованной области.");
        }

        Console.ReadKey();
    }
}