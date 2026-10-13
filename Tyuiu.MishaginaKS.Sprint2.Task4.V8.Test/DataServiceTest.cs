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
            double x = 1;
            double y = 1;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(-6, res);
        }
    }
