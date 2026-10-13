namespace Tyuiu.MishaginaKS.Sprint2.Task5.V3.Lib;

using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task5V3
{
    public string FindDayName(int value)

    {
        string result = value switch
        {
            1 => "Понедельник",
            2 => "Вторник",
            3 => "Среда",
            4 => "Четверг",
            5 => "Пятница",
            6 => "Суббота",
            7 => "Воскресенье",
            _ => "Неверный номер дня недели"
        };

        return result;
    }
}
