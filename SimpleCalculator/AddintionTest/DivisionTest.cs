using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace AddintionTest
{
    [TestClass]
    public class DivisionTest
    {
        [TestMethod]
        public void DivisonTest()
        {
            int answer = Divison.DivideNum(new string[] { "15", "3" });
            Assert.AreEqual(answer, 5);
        }
    }
}
