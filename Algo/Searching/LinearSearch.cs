/**
 * Implement linear search:
 * Given an array, search a given element val in the array (Do not use array's built-in method)
 */

namespace Algo.Searching
{
  public class LinearSearch
  {
    public static int Run(int[] arr, int val)
    {
      for (int i = 0; i < arr.Length; i++)
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