namespace Tyuiu.MishaginaKS.Sprint2.Task3.V21.Lib;

using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task3V21
{
    public double Calculate(double x)

    {
        double y = 0;

        if (x > 1)
        {
            y = x * Math.Pow((x + 9) / (x - 1), x);
        }
        else if (x == 0)
        {
            y = (Math.Pow(x, 2) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
        }
        else if (x > -25 && x < 2)
        {
            y = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
        }
        else if (x < -25)
        {
            y = x + 10 * x - Math.Pow(1 / x, x);
        }

        return Math.Round(y, 3);
    }
}

