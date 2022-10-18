using System.Collections.Generic;

namespace Algo.Arr
{
  /**
   * Given an array of numbers, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
   * Example: nums = [0,1,0,3,12], moveingZeroes(nums) -> [1,3,12,0,0]
	 */
  public class MovingZeroes
  {
    public static int[] Run(int[] nums)
    {
      bool trailingZero = true;
      List<int> numsList = new (nums);
      for (int i = numsList.Count - 1; i >= 0; i--)
      {
        if (numsList[i] != 0)
        {
          trailingZero = false;
        }
        if (numsList[i] == 0 && !trailingZero)
        {
          numsList.Add(0);
          numsList.RemoveAt(i);
        }
      }
      return numsList.ToArray();
    }
  }
}