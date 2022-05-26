using System.Linq;

namespace Algo.Sorting 
{
  /**
   * Implement counting sort.
   */
  public class CountingSort
  {
    static public int[] Sort(int[] arr) 
    {
      int[] sorted = new int[arr.Length];
      int max = arr[0];
      foreach(int n in arr) 
      {
        if(n > max) {
          max = n;
        }
      }
      int[] count = new int[max+1];
      count = count.Select(i => 0).ToArray(); // Populate sorted array with number 0.

      // Count each element
      foreach(int n in arr)
      {
        count[n]++;
      }

      // Accumulate count array.
      for (int i = 1; i < count.Length; i++) 
      {
        count[i] += count[i-1];
      }

      // Iterate given array and put each element in the right place.
      foreach(int n in arr)
      {
        sorted[count[n] - 1] = n;
        count[n]--;
      }

      return sorted;
    }
  }
}