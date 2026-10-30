using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint1.Task1.V12.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(1, 5);
            Assert.AreEqual(1, res, 0.001);
        }
    }
}
