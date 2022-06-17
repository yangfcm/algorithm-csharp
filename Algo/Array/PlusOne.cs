using System.Collections.Generic;

namespace Algo.Arr
{
  /**
	 * Given a non-empty array of digits representing a non-negative integer, plus one to the integer.
   * Example: plusOne([1,2,3]) -> [1,2,4]
   * plusOne([1, 9, 9]) -> [2, 0, 0]
   * plusOne([9, 9, 9]) -> [1, 0, 0, 0]
   */
  public class PlusOne
  {
    static public int[] Run(int[] digits)
    {
      List<int> digitsList = new List<int>(digits);
      for (int i = digitsList.Count - 1; i >= 0; i--)
      {
        if (digitsList[i] < 9)
        {
          digitsList[i]++;
          return digitsList.ToArray();
        }
        if (digitsList[i] == 9)
        {
          digitsList[i] = 0;
          if (i == 0)
          {
            digitsList.Insert(0, 1);
          }
        }
      }
      return digitsList.ToArray();
    }
  }
}