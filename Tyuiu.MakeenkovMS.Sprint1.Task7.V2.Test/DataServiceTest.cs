using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakeenkovMS.Sprint1.Task7.V2.Lib;

namespace Tyuiu.MakeenkovMS.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = -7.145;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
