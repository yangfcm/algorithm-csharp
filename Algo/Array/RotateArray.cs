using System;
using System.Collections.Generic;

namespace Algo.Arr
{
  /**
	 * Given an array, rotate the array to the right by k steps, where k is non-negative.
 	* Modify array in-place
 	* e.g. Input: [1,2,3,4,5,6,7] and k = 3
		Output: [5,6,7,1,2,3,4]
	 */
  public class RotateArray
  {
    static public int[] Run(int[] nums, int k)
    {
      if (k < 0)
      {
        throw new Exception("Step must be a positive number");
      }
      int count = nums.Length;
      List<int> numsList = new List<int>(nums);
      for (int i = 1; i <= k; i++)
      {
        // Equivalent to move the last element to the head
        int lastNum = numsList[count - 1];
        numsList.RemoveAt(count - 1);
        numsList.Insert(0, lastNum);

      }
      return numsList.ToArray();
    }
  }
}