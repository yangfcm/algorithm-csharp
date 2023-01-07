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
            CollectionAssert.AreEqual(expected[0].ToArray(), new int[] { 1, 2, 3 });
            CollectionAssert.AreEqual(expected[1].ToArray(), new int[] { 1, 3, 2 });
            CollectionAssert.AreEqual(expected[2].ToArray(), new int[] { 2, 1, 3 });
            CollectionAssert.AreEqual(expected[3].ToArray(), new int[] { 2, 3, 1 });
            CollectionAssert.AreEqual(expected[4].ToArray(), new int[] { 3, 1, 2 });
            CollectionAssert.AreEqual(expected[5].ToArray(), new int[] { 3, 2, 1 });
        }

        [TestMethod]
        public void TestCase2()
        {
            List<List<int>> expected = Permutations.Solution(arr2);
            Assert.AreEqual(expected.Count, 24);
            CollectionAssert.AreEqual(expected[0].ToArray(), new int[] { 1, 2, 3, 4 });
            CollectionAssert.AreEqual(expected[1].ToArray(), new int[] { 1, 2, 4, 3 });
            CollectionAssert.AreEqual(expected[2].ToArray(), new int[] { 1, 3, 2, 4 });
            CollectionAssert.AreEqual(expected[3].ToArray(), new int[] { 1, 3, 4, 2 });
            CollectionAssert.AreEqual(expected[4].ToArray(), new int[] { 1, 4, 2, 3 });
            CollectionAssert.AreEqual(expected[5].ToArray(), new int[] { 1, 4, 3, 2 });

            CollectionAssert.AreEqual(expected[6].ToArray(), new int[] { 2, 1, 3, 4 });
            CollectionAssert.AreEqual(expected[7].ToArray(), new int[] { 2, 1, 4, 3 });
            CollectionAssert.AreEqual(expected[8].ToArray(), new int[] { 2, 3, 1, 4 });
            CollectionAssert.AreEqual(expected[9].ToArray(), new int[] { 2, 3, 4, 1 });
            CollectionAssert.AreEqual(expected[10].ToArray(), new int[] { 2, 4, 1, 3 });
            CollectionAssert.AreEqual(expected[11].ToArray(), new int[] { 2, 4, 3, 1 });

            CollectionAssert.AreEqual(expected[12].ToArray(), new int[] { 3, 1, 2, 4 });
            CollectionAssert.AreEqual(expected[13].ToArray(), new int[] { 3, 1, 4, 2 });
            CollectionAssert.AreEqual(expected[14].ToArray(), new int[] { 3, 2, 1, 4 });
            CollectionAssert.AreEqual(expected[15].ToArray(), new int[] { 3, 2, 4, 1 });
            CollectionAssert.AreEqual(expected[16].ToArray(), new int[] { 3, 4, 1, 2 });
            CollectionAssert.AreEqual(expected[17].ToArray(), new int[] { 3, 4, 2, 1 });

            CollectionAssert.AreEqual(expected[18].ToArray(), new int[] { 4, 1, 2, 3 });
            CollectionAssert.AreEqual(expected[19].ToArray(), new int[] { 4, 1, 3, 2 });
            CollectionAssert.AreEqual(expected[20].ToArray(), new int[] { 4, 2, 1, 3 });
            CollectionAssert.AreEqual(expected[21].ToArray(), new int[] { 4, 2, 3, 1 });
            CollectionAssert.AreEqual(expected[22].ToArray(), new int[] { 4, 3, 1, 2 });
            CollectionAssert.AreEqual(expected[23].ToArray(), new int[] { 4, 3, 2, 1 });
        }
    }
}