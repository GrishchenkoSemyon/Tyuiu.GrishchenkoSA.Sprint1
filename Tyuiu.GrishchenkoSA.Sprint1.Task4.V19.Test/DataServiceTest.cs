using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint1.Task4.V19.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(5.0, 4.0);
            Assert.AreEqual(3.0, res);
        }
    }
}
