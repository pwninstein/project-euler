using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace ProjectEuler.Test
{
    [TestClass]
    public class HelperTests
    {
        [TestMethod]
        public void GetMultiplesTest()
        {
            var numbers = new [] { 3, 5, 7 };

            var max = 20;

            var result = Helpers.getMultiples(numbers, max);

            var expectedResult = new[] { 3, 5, 6, 7, 9, 10, 12, 14, 15, 18, 20 };

            Assert.IsTrue(result.SequenceEqual(expectedResult));
        }

        [TestMethod]
        public void FibonacciTest()
        {
            var result = Helpers.fibonacci(100);

            var expectedResult = new[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };

            Assert.IsTrue(result.SequenceEqual(expectedResult));
        }

        [TestMethod]
        public void IsPrimeTest()
        {
            var pairs = new Dictionary<int, bool>();

            pairs.Add(2, true);
            pairs.Add(3, true);
            pairs.Add(4, false);
            pairs.Add(5, true);
            pairs.Add(6, false);
            pairs.Add(7, true);
            pairs.Add(8, false);
            pairs.Add(9, false);
            pairs.Add(10, false);
            pairs.Add(11, true);
            pairs.Add(12, false);
            pairs.Add(13, true);
            pairs.Add(14, false);
            pairs.Add(15, false);
            pairs.Add(16, false);
            pairs.Add(17, true);
            pairs.Add(18, false);
            pairs.Add(19, true);
            pairs.Add(20, false);

            foreach (var value in pairs)
            {
                Assert.AreEqual(Helpers.isPrime(value.Key), value.Value);
            }
        }

        [TestMethod]
        public void GetFactors()
        {
            var result = Helpers.getFactors(27);

            var expectedResult = new long[] { 1, 3, 9, 27 };

            Assert.IsTrue(result.SequenceEqual(expectedResult));
        }

        [TestMethod]
        public void PrimeFactors()
        {
            var result = Helpers.getPrimeFactors(13195);

            var expectedResult = new long[] { 5, 7, 13, 29 };

            Assert.IsTrue(result.SequenceEqual(expectedResult));
        }
    }
}