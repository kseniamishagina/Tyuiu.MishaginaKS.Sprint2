using Tyuiu.MishaginaKS.Sprint2.Task3.V21.Lib;

namespace Tyuiu.MishaginaKS.Sprint2.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest

    {
        [TestMethod]
        public void ValidCalculate()

        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);

            Assert.AreEqual(0.833, res);

        }
    }
}
