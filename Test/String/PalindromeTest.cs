using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;

namespace Test
{
	[TestClass]
	public class PalindromeTest
	{
		[TestMethod]
		[DataRow("racecar")]
		public void TestPalindromeTrue(string str)
		{
			var isPalindrome = Palindrome.Run(str);
			Assert.IsTrue(isPalindrome);
		}

		[TestMethod]
		[DataRow("hello")]
		public void TestPalindromeFalse(string str)
		{
			var isPalindrome = Palindrome.Run(str);
			Assert.IsFalse(isPalindrome);
		}

	}
}