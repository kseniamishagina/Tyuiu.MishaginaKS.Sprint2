namespace Tyuiu.MishaginaKS.Sprint2.Task7.V11.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task7V11

{
    public bool CheckDotInShadedArea(double x, double y)

    {
        if ((x * x + y * y <= 1) && (y >= x))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

