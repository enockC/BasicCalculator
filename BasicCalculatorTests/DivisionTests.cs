using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class DivisionTests
    {

        private readonly int d = 12;
        private readonly int e = 6;
        private readonly int c = 0;
        [TestMethod()]
        public void QuotientTest()
        {
            Assert.AreEqual(2, Division.Quotient(d, e));
        }


        [TestMethod()]
        public void DivideByZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Quotient(d, c));
        }
    }
}