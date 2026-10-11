namespace Tyuiu.MishaginaKS.Sprint2.Task0.V4.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MishaginaKS.Sprint2.Task0.V4.Lib;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void ValidGetCompareOperations()

    {
        DataService ds = new DataService();
        int x = 333;
        int y = 324;

        bool[] res = ds.GetCompareOperations(x, y);
        bool[] expected = new bool[] { false, true, false, true, false, true };

        CollectionAssert.AreEqual(expected, res);
    }
}
