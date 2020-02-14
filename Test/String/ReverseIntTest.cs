using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;

namespace Test
{
	[TestClass]
	public class ReverseIntTest
	{
		[TestMethod]
		[DataRow(521, 125)]
		[DataRow(-521, -125)]
		[DataRow(1200, 21)]
		public void TestReverseInt(int num, int expectedReverseInt)
		{
			int reverseInt = ReverseInt.Run(num);
			Assert.AreEqual(reverseInt, expectedReverseInt);
		}
	}
}