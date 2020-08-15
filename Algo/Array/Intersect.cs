using System.Collections.Generic;

namespace Algo.Arr
{
  /** Given two arrays, write a function to compute their intersection.
    * Each element in the result should appear as many times as it shows in both arrays.
    * The result can be in any order.
    * e.g. Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
	Output: [4,9] 
    */
  public class Intersect
  {
    static public int[] Run(int[] nums1, int[] nums2)
    {
      List<int> smaller;
      List<int> bigger;
      if (nums1.Length < nums2.Length)
      {
        smaller = new List<int>(nums1);
        bigger = new List<int>(nums2);
      }
      else
      {
        smaller = new List<int>(nums2);
        bigger = new List<int>(nums1);
      }
      List<int> intersect = new List<int>();
      for (int i = 0; i < smaller.Count; i++)
      {
        int foundIndex = bigger.IndexOf(smaller[i]);
        if (foundIndex >= 0)
        {
          intersect.Add(bigger[foundIndex]);
          bigger.RemoveAt(foundIndex);
        }
      }
      return intersect.ToArray();
    }

  }
}