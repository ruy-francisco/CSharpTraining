using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PowerNumbersAndSumsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckPowerNumbers()
        {
            Assert.AreEqual(81, PowerNumbersAndSums.Class.Numbers.PowerSumDigTerm(1));
            Assert.AreEqual(512, PowerNumbersAndSums.Class.Numbers.PowerSumDigTerm(2));
            Assert.AreEqual(2401, PowerNumbersAndSums.Class.Numbers.PowerSumDigTerm(3));
            Assert.AreEqual(4913, PowerNumbersAndSums.Class.Numbers.PowerSumDigTerm(4));
            
            //Assert.AreEqual(true, PowerNumbersAndSums.Class.Numbers.PowerEqualsSumOfDigits(512));
        }
    }
}
