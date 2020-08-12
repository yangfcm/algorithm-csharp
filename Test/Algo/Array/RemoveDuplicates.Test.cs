using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;

namespace Test
{
	[TestClass]
	public class RemoveDuplicatesTest
	{
		[TestMethod]
		[DataRow(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
		[DataRow(new int[] { -5, -1, -1, 0, 2, 2, 4, 5, 5 }, 6)]
		[DataRow(new int[] { 3, 3, 3, 3, 0, 0, -2, -2 }, 3)]
		public void Test(int[] nums, int expectedResult)
		{
			int result = RemoveDuplicates.Run(nums);
			Assert.AreEqual(result, expectedResult);
		}
	}
}