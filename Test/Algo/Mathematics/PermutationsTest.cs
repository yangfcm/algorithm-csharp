using System.Collections.Generic;
using Algo.Mathematics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algo.Mathematics
{
    [TestClass]
    public class PermutationsTest
    {
        private readonly int[] arr1 = new int[] { 1, 2, 3 };
        private readonly int[] arr2 = new int[] { 1, 2, 3, 4 };
        [TestMethod]
        public void TestCase1()
        {
            List<List<int>> expected = Permutations.Solution(arr1);
            Assert.AreEqual(expected.Count, 6);
        }

        [TestMethod]
        public void TestCase2()
        {
            List<List<int>> expected = Permutations.Solution(arr2);
            Assert.AreEqual(expected.Count, 24);
        }
    }
}