namespace Tyuiu.MishaginaKS.Sprint2.Task2.V10.Lib;

using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task2V10

{
    public bool CheckDotInShadedArea(int x, int y)

    {
        bool zone1 = (x >= 3 && x <= 13) && (y >= 3 && y <= 8);

        bool zone2 = (x >= 3 && x <= 4) && (y >= 9 && y <= 14);

        bool zone3 = (x >= 7 && x <= 8) && (y >= 9 && y <= 12);

        bool zone4 = (x >= 5 && x <= 6) && (y == 11);

        if (zone1 || zone2 || zone3 || zone4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
