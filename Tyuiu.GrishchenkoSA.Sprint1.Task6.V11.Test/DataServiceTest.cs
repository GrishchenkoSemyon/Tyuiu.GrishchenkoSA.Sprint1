using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint1.Task6.V11.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.CheckeFirstLetterRepetition("ананас");
            Assert.AreEqual(true, res);
        }
    }
}
