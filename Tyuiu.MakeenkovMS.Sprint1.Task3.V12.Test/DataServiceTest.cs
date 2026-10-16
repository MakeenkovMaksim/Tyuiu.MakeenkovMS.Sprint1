using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakeenkovMS.Sprint1.Task3.V12.Lib;

namespace Tyuiu.MakeenkovMS.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 3.5;
            double b = 4.2;
            double wait = 7.35;
            double res = ds.TriangleArea(a, b);
            Assert.AreEqual(wait, res);
        }
    }
}
