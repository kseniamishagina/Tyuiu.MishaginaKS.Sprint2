using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MishaginaKS.Sprint2.Task6.V13.Lib;

public class DataService : ISprint2Task6V13

{

    public string FindDateOfNextDay(int g, int m, int n)

    {
        int daysInMonth = m switch
        {
            2 => 29,
            4 or 6 or 9 or 11 => 30,
            1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            _ => throw new ArgumentException("Неверный номер месяца!")
        };

        n++;

        if (n > daysInMonth)
        {
            n = 1;
            m++;

            if (m > 12)

            {
                m = 1;
                g++;
            }
        }

        return $"{n:D2}.{m:D2}.{g}";
    }
}