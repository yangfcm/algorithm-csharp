using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Assorted;
using System.Collections;
using System.Collections.Generic;

namespace Test.Algo.Assorted
{
    [TestClass]
    public class MakeCandiesTest
    {
        public static IEnumerable<object[]> DataSource
        {
            get
            {
                return new[]
                {
                    new object[]{3, 1, 2, 12, 3},
                    new object[]{1, 1, 6, 45, 16},
                    new object[]{1, 2, 343, 270, 135},
                    new object[]{5, 1, 172, 364, 72},
                    new object[]{100, 100, 20, 200, 1},
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(DataSource))]
        public void TestSolution(int m, int w, int p, int n, int expected)
        {
            Assert.AreEqual(expected, MakeCandies.Solution(m, w, p, n));
        }
    }
}