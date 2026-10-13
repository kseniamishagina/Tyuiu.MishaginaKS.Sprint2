using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MishaginaKS.Sprint2.Task6.V13.Lib;

namespace Tyuiu.MishaginaKS.Sprint2.Task5.V13.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindNextDate()
        {
            DataService ds = new DataService();

            int g = 2024;
            int m = 2;
            int n = 29;

            string res = ds.FindDateOfNextDay(g, m, n);

            Assert.AreEqual("01.03.2024", res);
        }
    }
}