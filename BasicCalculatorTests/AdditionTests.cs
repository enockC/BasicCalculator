using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 6;
        private readonly int b = 9;
        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(15, Addition.Sum(a, b));
        }
    }
}