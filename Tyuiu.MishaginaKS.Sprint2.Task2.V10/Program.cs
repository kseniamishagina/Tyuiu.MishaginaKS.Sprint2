using System;
using Tyuiu.MishaginaKS.Sprint2.Task2.V10.Lib;
namespace Tyuiu.MishaginaKS.Sprint2.Task2.V10;


class Program

{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Мишагина К. С. | АСОиУБ-26-1";

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        Console.Write("Введите координату X (от 1 до 15): ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату Y (от 1 до 15): ");
        int y = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

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
