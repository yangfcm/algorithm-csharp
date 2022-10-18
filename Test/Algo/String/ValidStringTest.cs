using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String
{
    [TestClass]
    public class ValidStringTest
    {
        [TestMethod]
        [DataRow("abcd")]
        [DataRow("abcdefghhgfedecba")]
        [DataRow("aaabbbccccddd")]
        public void TestIsValidString(string validStr) {
            Assert.IsTrue(ValidString.Solution(validStr));
        }        

        [TestMethod]
        [DataRow("aabbcd")]
        [DataRow("aabbccddeefghi")]
        [DataRow("aaabbbbcccdddd")]
        public void TestIsNotValidString(string invalidStr) {
            Assert.IsFalse(ValidString.Solution(invalidStr));
        }
    }
}