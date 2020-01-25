using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;

namespace Test
{
	public class VowelsTest
	{
		[TestMethod]
		[DataRow("apple", 2)]
		[DataRow("John SMITH", 2)]
		[DataRow("why?", 0)]
		public void TestVowels(string str, int expectedVowelsNum)
		{
			int vowelsNum = Vowels.Run(str);
			Assert.AreEqual(vowelsNum, expectedVowelsNum);
		}
	}
}