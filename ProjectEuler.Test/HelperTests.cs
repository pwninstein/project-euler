using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}