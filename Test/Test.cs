using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;

namespace Test
{
	[TestClass]
	public class Test
	{
		[TestMethod]
		public void TestMethod1()
		{
			var testString = Start.Main();
			Assert.AreEqual(testString, "Test String");
		}
	}
}
