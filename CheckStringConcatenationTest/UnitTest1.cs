using System;
using CheckStringConcatenationTest;
using System.Web;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckStringConcatenationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isMergeTest()
        {
            //CheckStringConcatenation.StringMerger.isMerge("codwars", "cod", "wrs")
            Assert.AreEqual(false, CheckStringConcatenation.StringMerger.isMerge("codwars", "cod", "wrs"));
            Assert.AreEqual(true, CheckStringConcatenation.StringMerger.isMerge("codewars", "cdwr", "oeas"));

            Assert.AreEqual(true, CheckStringConcatenation.StringMerger.isMerge("Bananas from Bahamas", "Bahas", "Bananas from am"));
            //Assert.AreEqual(true, CheckStringConcatenation.StringMerger.isMerge("codewars", "cdwr", "oeas"));
        }
    }
}