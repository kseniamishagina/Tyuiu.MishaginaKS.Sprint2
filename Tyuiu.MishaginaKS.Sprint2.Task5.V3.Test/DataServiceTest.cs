using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MishaginaKS.Sprint2.Task5.V3.Lib;

namespace Tyuiu.MishaginaKS.Sprint2.Task5.V3.Test;


[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCheckDayOfWeek()
    {
        DataService ds = new DataService();

        string res = ds.FindDayName(1);

        Assert.AreEqual("Понедельник", res);
    }
}