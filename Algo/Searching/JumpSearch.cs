/**
 * Implement binary search
 * Given a sorted array, search a given element val in the array
 */
using System;

namespace Algo.Searching
{
  public class JumpSearch
  {
    public static int Run(int[] arr, int val)
    {
      int len = arr.Length;
      int lastIndex = len - 1;
      int step = (int)(Math.Sqrt(Convert.ToDouble(len)));
      int startIndex = 0;
      int endIndex = startIndex + step - 1;
      while (arr[Math.Min(endIndex, lastIndex)] < val)
      {
        startIndex += step;
        endIndex += step;
        if (startIndex > lastIndex)
        {
          return -1;
        }
      }
      for (int i = startIndex; i <= Math.Min(endIndex, lastIndex); i++)
      {
        if (arr[i] == val)
        {
          return i;
        }
      }
      return -1;
    }
  }
}