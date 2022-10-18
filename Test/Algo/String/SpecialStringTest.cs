using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;


namespace Test.Algo.String
{
    [TestClass]
    public class SpecialStringTest
    { 
        [TestMethod]
        [DataRow("a", 1)]
        [DataRow("aa", 3)]
        [DataRow("aaaa", 10)]
        [DataRow("abcbaba", 10)]
        [DataRow("asasd", 7)]
        [DataRow("abcde", 5)]
        public void TestSolution(string str, int expected) { 
            Assert.AreEqual(expected, SpecialString.Solution(str));
        }
    }
}