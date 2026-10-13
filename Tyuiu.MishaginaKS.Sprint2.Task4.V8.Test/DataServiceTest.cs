namespace Tyuiu.MishaginaKS.Sprint2.Task4.V8.Test;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MishaginaKS.Sprint2.Task4.V8.Lib;


[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();

        double x = 9;
        double y = 4;

        double res = ds.Calculate(x, y);

        Assert.AreEqual(175.625, res);
    }
}
 
