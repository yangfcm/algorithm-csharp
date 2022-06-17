using System.Collections.Generic;

namespace Algo.Arr
{
  /**
  * Given an array and chunk size, divide the array into many subarrays where each subarray is of length size.
  * Example: chunk([1, 2, 3, 4], 2) -> [[1, 2], [3, 4]]
  * chunk([1, 2, 3, 4, 5], 2) -> [[ 1, 2], [3, 4], [5]]
  * chunk([1, 2, 3, 4, 5, 6, 7, 8], 3) -> [[ 1, 2, 3], [4, 5, 6], [7, 8]]
  * chunk([1, 2, 3, 4, 5], 4) -> [[ 1, 2, 3, 4], [5]]
  * chunk([1, 2, 3, 4, 5], 10) -> [[ 1, 2, 3, 4, 5]]
  */
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