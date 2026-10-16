using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakeenkovMS.Sprint1.Task1.V27.Lib;

namespace Tyuiu.MakeenkovMS.Sprint1.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 6;
            double wait = 5;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
