using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;


namespace SubtractionTest
{
    [TestClass]
    public class SubtractionTest
    {
        [TestMethod]
        public static void SubtractNum()
        {
            int answer = Subtraction.SubtractNum(new string[] { "5", "3" });
            Assert.AreEqual(answer, 2);
        }
    }
}
