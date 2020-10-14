/**
 * Implement interpolation search
 */

using System;

namespace Algo.Searching
{
  public class InterpolationSearch
  {
    public static int Run(int[] arr, int val)
    {
      return SearchHelper(arr, val, 0, arr.Length - 1);
    }

    private static int SearchHelper(int[] arr, int val, int low, int high)
    {
      if (low < high && val >= arr[low] && val <= arr[high])
      {
        int pos = low + (val - arr[low]) * (high - low) / (arr[high] - arr[low]);
        if (arr[pos] == val)
        {
          return pos;
        }
        else if (arr[pos] < val)
        {
          return SearchHelper(arr, val, pos + 1, high);
        }
        else if (arr[pos] > val)
        {
          return SearchHelper(arr, val, low, pos - 1);
        }
      }
      return -1;
    }
  }

}