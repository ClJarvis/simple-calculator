using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace AddintionTest
{
    [TestClass]
    public class ConsoleCalculatorTest
    {
        [TestMethod]
        public void GetNumbersShouldReturnTwoStrings()
        {
            var calc = new ConsoleCalculator();
            var stringArray = calc.GetNumbers("12+16");
            var expected = new string[] {"12","16"};
            CollectionAssert.AreEqual(stringArray, expected);
           
        }

        [TestMethod]
        public void ShouldGetOperators()
        {
            var calc = new ConsoleCalculator();
            var op = calc.GetOperator("12-8");
            var expected = '-';
            Assert.AreEqual(expected, op);
        }

        [TestMethod]
        public void IsNumberInIndexZero()
        {
            ConsoleCalculator parse = new ConsoleCalculator();

            string[] indexZero = parse.GetNumbers("5+8");
            Assert.AreEqual("5", indexZero[0]);
        }

        [TestMethod]
        public void IsNumberInIndexOne()
        {
            ConsoleCalculator parse = new ConsoleCalculator();
            string[] indexOne = parse.GetNumbers("5+8");
            Assert.AreEqual("8", indexOne[1]);
        }
    }
}
