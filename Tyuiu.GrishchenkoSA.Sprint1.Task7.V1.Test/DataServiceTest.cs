using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint1.Task7.V1.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint1.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(2.0, 5.0, 1.0);
            Assert.AreEqual(-5.759, res);
        }
    }
}
