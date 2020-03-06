using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayProcessForm.Modules;

namespace Lab1Tests.Tests
{
    [TestClass]
    public class DigitAverageTest
    {
        [TestMethod]
        public void TestIntDigitAverageFromInt()
        {
            Assert.AreEqual(1, DigitAverageCalculator.Calculate(1111));
        }

        [TestMethod]
        public void TestIntDigitAverageFromString()
        {
            Assert.AreEqual(2, DigitAverageCalculator.Calculate("2222"));
        }

        [TestMethod]
        public void TestFloatDigitAverageFromInt()
        {
            Assert.AreEqual(2.5, DigitAverageCalculator.Calculate(2422));
        }
        
        [TestMethod]
        public void TestFloatDigitAverageFromString()
        {
            Assert.AreEqual(4.5, DigitAverageCalculator.Calculate("8820"));
        }

        [TestMethod]
        public void TestIntDigitAverageFromStringWithLeadingZeroes()
        {
            Assert.AreEqual(6, DigitAverageCalculator.Calculate("0882"));
        }
    }

    [TestClass]
    public class DigitCountTest
    {
        [TestMethod]
        public void TestIntDigitCountFromInt()
        {
            Assert.AreEqual(4, DigitCountCalculator.Calculate(1111));
        }

        [TestMethod]
        public void TestIntDigitCountFromString()
        {
            Assert.AreEqual(4, DigitCountCalculator.Calculate("2852"));
        }

        [TestMethod]
        public void TestIntDigitCountFromStringWithLeadingZeroes()
        {
            Assert.AreEqual(2, DigitCountCalculator.Calculate("0011"));
        }
    }

    [TestClass]
    public class MaxDigitTest
    {
        [TestMethod]
        public void TestMaxDigitFromInt()
        {
            Assert.AreEqual(9, MaxDigitFinder.Find(9321));
        }

        [TestMethod]
        public void TestMaxDigitFromString()
        {
            Assert.AreEqual(7, MaxDigitFinder.Find("1147"));
        }

        [TestMethod]
        public void TestMaxDigitFromStringWithLeadingZeroes()
        {
            Assert.AreEqual(6, MaxDigitFinder.Find("0206"));
        }
    }
}
