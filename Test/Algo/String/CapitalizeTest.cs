using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;

namespace Test
{
	[TestClass]
	public class CapitalizeTest
	{
		[TestMethod]
		[DataRow("hi, there", "Hi, There")]
		[DataRow("i love apples and bananas.", "I Love Apples And Bananas.")]
		public void TestCapitalize(string testStr, string capitalizedStr)
		{
			var result = Capitalize.Run(testStr);
			Assert.AreEqual(result, capitalizedStr);
		}
	}
}
