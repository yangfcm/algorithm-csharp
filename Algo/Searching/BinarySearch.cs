/**
 * Implement binary search
 * Given a sorted array, search a given element val in the array
 */
namespace Algo.Searching
{
  public class BinarySearch
  {
    public static int Run(int[] arr, int val)
    {
      return SearchHelper(arr, val, 0, arr.Length);
    }

    public static int SearchHelper(int[] arr, int val, int start, int end)
    {
      if (end >= start)
      {
        int mid = (start + end) / 2;
        if (arr[mid] == val)
        {
          // Element found
          return mid;
        }
        else if (val > arr[mid])
        {
          // If the element to find is larger than the middle element,
          // Continue searching it in the upper half array.
          return SearchHelper(arr, val, mid + 1, end);
        }
        else if (val < arr[mid])
        {
          // The element to find is smaller than the middle element,
          // Continue searching it in the lower half array.
          return SearchHelper(arr, val, start, mid - 1);
        }
      }
      return -1;
    }
  }
}