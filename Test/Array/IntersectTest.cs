using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;

namespace Test
{
	[TestClass]
	public class IntersectTest
	{
		[TestMethod]
		[DataRow(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
		[DataRow(new int[] { 1, 1, 1, -2, -2, 5, 8, 9 }, new int[] { 1, 1, -2, 9, 10 }, new int[] { 1, 1, -2, 9 })]
		public void TestIntersect(int[] nums1, int[] nums2, int[] expectedIntersect)
		{
			int[] intersect = Intersect.Run(nums1, nums2);
			CollectionAssert.AreEqual(intersect, expectedIntersect);
		}
	}
}