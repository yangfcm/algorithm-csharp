/**
 * Implement exponential search
 */
using System;
using System.Linq;

namespace Algo.Searching
{
  public class ExponentialSearch
  {
    public static int Run(int[] arr, int val)
    {
      if (arr[0] == val)
      {
        return 0;
      }
      int i = 1;
      while (i < arr.Length && arr[i] <= val)
      {
        i = i * 2;
      }
      // arr = arr.ToList().GetRange(i / 2, Math.Min(i, arr.Length) - i / 2).ToArray();
      // Console.Write(string.Join(", ", arr));
      return BinarySearch.SearchHelper(arr, val, i / 2, Math.Min(i, arr.Length - 1));
    }
  }
}