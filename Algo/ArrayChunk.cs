using System.Collections.Generic;
using System;

namespace Algo
{
	public class ArrayChunk
	{
		static public int[][] Run(int[] array, int size)
		{
			int chunkedSize = array.Length / size + 1;
			int[][] chunkedArray = new int[chunkedSize][];
			int arrayIndex = 0;
			int chunkedIndex = 0;
			while (arrayIndex < array.Length)
			{
				int slicedSize = arrayIndex + size > array.Length ? array.Length - arrayIndex : size;
				// Console.WriteLine("arrayIndex:" + arrayIndex);
				// Console.WriteLine("size:" + slicedSize);
				int[] sliced = new List<int>(array).GetRange(arrayIndex, slicedSize).ToArray();
				// Console.WriteLine(sliced[0]);
				chunkedArray[chunkedIndex] = sliced;
				arrayIndex += size;
				chunkedIndex++;
			}
			return chunkedArray;
		}
	}
}