using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;
using System;

namespace Test
{


	[TestClass]
	public class ArrayChunkTest
	{

		[TestMethod]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 1)]
		public void TestCase1(int[] array, int size)
		{
			int[][] chunked1 = ArrayChunk.Run(array, size);
			int[][] expectedChunk1 =  {
				new int[] { 1 },
				new int[] { 2 },
				new int[] { 3 },
				new int[] { 4 },
				new int[] { 5 }
			};
			for (int i = 0; i < chunked1.Length - 1; i++)
			{
				CollectionAssert.AreEqual(chunked1[i], expectedChunk1[i]);
			}
		}

		[TestMethod]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 2)]
		public void TestCase2(int[] array, int size)
		{
			int[][] chunked1 = ArrayChunk.Run(array, size);
			int[][] expectedChunk1 =  {
				new int[] { 1, 2 },
				new int[] { 3,4 },
				new int[] { 5 }
			};
			for (int i = 0; i < chunked1.Length; i++)
			{
				CollectionAssert.AreEqual(chunked1[i], expectedChunk1[i]);
			}
		}

		[TestMethod]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, 4)]
		public void TestCase3(int[] array, int size)
		{
			int[][] chunked1 = ArrayChunk.Run(array, size);
			int[][] expectedChunk1 =  {
				new int[] { 1, 2, 3, 4 },
				new int[] { 5, 6, 7, 8 },
				new int[] { 9, 10, 11, 12 },
				new int[] { 13 }
			};
			for (int i = 0; i < chunked1.Length; i++)
			{
				CollectionAssert.AreEqual(chunked1[i], expectedChunk1[i]);
			}
		}

	}
}
