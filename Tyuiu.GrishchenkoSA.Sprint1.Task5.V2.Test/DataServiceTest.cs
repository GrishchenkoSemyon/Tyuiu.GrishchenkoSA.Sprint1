using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.FahrenheitToСelsius(212.0);
            Assert.AreEqual(100, res);
        }
    }
}
