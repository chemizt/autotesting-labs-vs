using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayProcessForm.Modules;
using System.Collections.Generic;

namespace Lab1Tests.Tests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void DigitAverageAndDigitCountTest()
        {
            string s = "8820";
            int digitCount = DigitCountCalculator.Calculate(s);
            float digitSum = 18;

            Assert.AreEqual(digitSum / digitCount, DigitAverageCalculator.Calculate(s));
        }

        [TestMethod]
        public void AllModulesIntegration()
        {
            List<int> testArray = new List<int> { 0, 1234, 7100 };
            int value = 0;
            float average = 2;
            int digitSum = 8;

            foreach (int testNumber in testArray)
            {
                value = DigitAverageCalculator.Calculate(testNumber) < 7 && MaxDigitFinder.Find(testNumber) == 7 ? testNumber : value;
            }

            Assert.AreEqual(average, digitSum / DigitCountCalculator.Calculate(value));
            Assert.AreEqual(7100, value);
        }
    }
}
