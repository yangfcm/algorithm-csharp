/**
 * Given an array of integers representing the color of each sock,
 * determine how many pairs of socks with matching colors there are.
 * For example, there are n = 7 socks with colors arr=[1,2,1,2,1,3,2]. 
 * There is one pair of color 1 and one of color 2. 
 * There are three odd socks left, one of each color. So the number of pairs is 2.
 */
using System.Collections.Generic;

namespace Algo.Arr
{
  public class SockMerchant
  {
    public static int Run(int[] arr)
    {
      int pairs = 0;
      var charMap = new Dictionary<int, int>();
      for (int i = 0; i < arr.Length; i++)
      {
        if (charMap.ContainsKey(arr[i]) == true)
        {
          charMap[arr[i]]++;
        }
        else
        {
          charMap.Add(arr[i], 1);
        }
      }
      foreach (KeyValuePair<int, int> kvp in charMap)
      {
        pairs += kvp.Value / 2;
      }
      return pairs;
    }

  }
}