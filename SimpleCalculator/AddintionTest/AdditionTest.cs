using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace CalculatorTest
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void AddintionTest()
        {
            int answer = addition.AddNum(new string[] { "5", "3" });
            Assert.AreEqual(answer, 8);
        }
    }
}
