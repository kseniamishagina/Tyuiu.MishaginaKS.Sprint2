namespace Tyuiu.MishaginaKS.Sprint2.Task2.V10.Test;
using Tyuiu.MishaginaKS.Sprint2.Task2.V10.Lib;

    [TestClass]
    public sealed class DataServiceTest

    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(4, 5));

            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
        }
    }
