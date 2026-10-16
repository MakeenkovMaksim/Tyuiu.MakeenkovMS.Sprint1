using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakeenkovMS.Sprint1.Task2.V5.Lib;

namespace Tyuiu.MakeenkovMS.Sprint1.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 3;
            int wait = 54;
            int res = ds.CalculateSideSquare(a);
            Assert.AreEqual(wait, res);
        }
    }
}
