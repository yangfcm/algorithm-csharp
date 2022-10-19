using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Greedy;

namespace Test.Algo.Greedy
{
    [TestClass]
    public class ReverseShuffleMergeTest
    {
        [TestMethod]
        [DataRow("eggegg", "egg")]
        [DataRow("abcdefgabcdefg", "agfedcb")]
        [DataRow("aeiouuoiea", "aeiou")]
        [DataRow("bdabaceadaedaaaeaecdeadababdbeaeeacacaba", "aaaaaabaaceededecbdb")]
        public void TestSolution(string s, string expected)
        {
            Assert.AreEqual(expected, ReverseShuffleMerge.Solution(s));
        }
    }
}