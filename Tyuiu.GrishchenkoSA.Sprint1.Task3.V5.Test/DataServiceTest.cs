using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint1.Task3.V5.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.DistanceLength(120.0, 3.5);
            Assert.AreEqual(0.25, res);
        }
    }
}
