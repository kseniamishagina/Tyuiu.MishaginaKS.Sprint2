namespace Tyuiu.MishaginaKS.Sprint2.Task1.V8.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task1V8

{
    public bool[] GetLogicOperations(int a, int b, int c, int d)

    {
        bool[] res = new bool[6];

        res[0] = (a < b) | (c < b);
        res[1] = (a == b) & (c < b);
        res[2] = (a > c) || (b < c);
        res[3] = (a < c) && (b > c);
        res[4] = !(a < b);
        res[5] = (a < b) ^ (c < b);

        return res;
    }
}
