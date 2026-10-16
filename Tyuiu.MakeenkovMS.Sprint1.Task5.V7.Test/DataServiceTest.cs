using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakeenkovMS.Sprint1.Task5.V7.Lib;

namespace Tyuiu.MakeenkovMS.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 95;
            int wait = 3;

            int res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(wait, res);
        }
    }
}
