using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakeenkovMS.Sprint1.Task4.V2.Lib;

namespace Tyuiu.MakeenkovMS.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3.5;
            double wait = 0.333;

            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
