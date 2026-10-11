using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MishaginaKS.Sprint2.Task1.V8.Lib;

namespace Tyuiu.MishaginaKS.Sprint2.Task1.V8.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 15;
            int b = 16;
            int c = 14;
            int d = 335;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] expected = new bool[] { true, false, true, false, false, false };

            CollectionAssert.AreEqual(expected, res);

        }
    }
}