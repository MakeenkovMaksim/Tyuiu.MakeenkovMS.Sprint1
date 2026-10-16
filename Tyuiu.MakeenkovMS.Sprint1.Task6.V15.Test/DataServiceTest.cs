using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakeenkovMS.Sprint1.Task6.V15.Lib;

namespace Tyuiu.MakeenkovMS.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string str = "Привет!!!";
            bool wait = true;
            bool res = ds.CheckLettersCount(str);
            Assert.AreEqual(wait, res);
        }
    }
}
