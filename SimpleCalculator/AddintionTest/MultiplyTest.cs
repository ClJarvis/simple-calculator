using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;


namespace CalculatorTest
{
    [TestClass]
    public class MultiplyTest
    {
        [TestMethod]
        public void MultiplicationTest()
        {
            int answer = Multiply.MultiplyNum(new string[] { "5", "3" });
            Assert.AreEqual(answer, 15);
        }
    }
}
