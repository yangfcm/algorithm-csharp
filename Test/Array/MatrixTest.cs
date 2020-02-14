using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;

namespace Test
{
	[TestClass]
	public class MatrixTest
	{
		[TestMethod]
		public void TestMatrixWithSize2()
		{
			var expected = new int[2, 2] { { 1, 2 }, { 4, 3 } };
			var result = Matrix.Run(2);
			CollectionAssert.AreEqual(result, expected);
		}

		[TestMethod]
		public void TestMatrixWithSize3()
		{
			var expected = new int[3, 3] {
				{ 1, 2, 3 },
				{ 8, 9, 4 },
				{ 7, 6, 5}
			};
			var result = Matrix.Run(3);
			CollectionAssert.AreEqual(result, expected);
		}

		[TestMethod]
		public void TestMatrixWithSize4()
		{
			var expected = new int[4, 4] {
				{1, 2, 3, 4},
				{12, 13, 14, 5},
				{11, 16, 15, 6},
				{10, 9, 8, 7}
			};
			var result = Matrix.Run(4);
			CollectionAssert.AreEqual(result, expected);
		}
	}
}