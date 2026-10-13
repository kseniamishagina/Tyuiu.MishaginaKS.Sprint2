namespace Tyuiu.MishaginaKS.Sprint2.Task5.V3.Lib;

using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task5V3
{
    public string FindDayName(int value)

    {
        string result = value switch
        {
            1 => "понедельник",
            2 => "вторник",
            3 => "среда",
            4 => "четверг",
            5 => "пятница",
            6 => "суббота",
            7 => "воскресенье",
            _ => "неверный номер дня недели"
        };

        return result;
    }
}
