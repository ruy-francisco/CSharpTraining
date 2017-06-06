using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeightForWeightTest
{
    [TestClass]
    public class WeightForWeightTestClass
    {
        [TestMethod]
        public void orderByWeightTest()
        {
            Assert.AreEqual("2000 103 123 4444 99", WeightForWeight.Class.WeightSort.orderWeight("103 123 4444 99 2000"));
            Assert.AreEqual("11 11 2000 10003 22 123 1234000 44444444 9999", WeightForWeight.Class.WeightSort.orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
        }
    }
}
