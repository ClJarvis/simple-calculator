using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace AddintionTest
{
    [TestClass]
    public class ModulusTest
    {
        [TestMethod]
        public void ModTest()
        {
            int answer = Modulus.ModulusNum(new string[] { "15", "3" });
            Assert.AreEqual(answer, 0);
        }
    }
}
