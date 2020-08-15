using System;
using System.Collections.Generic;

namespace Algo.Sorting
{
  /**
	Implement bubble sorting, selection sorting and merge sorting
	 */
  public class Sorting
  {
    /**
		Bubble sorting:
		* From i=0 to i<array length
		*   From j=0 to (array length - i)
		*     If the element at j is greater than its next element(j+1)
		*       Swap elements j and j+1
		 */
    static public int[] Bubble(int[] arr)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        for (int j = 0; j < (arr.Length - i - 1); j++)
        {
          if (arr[j] > arr[j + 1])
          {
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
          }
        }
      }
      return arr;
    }

    /**
		* From i=0 to i<array length
		*   Assume the element at 'i' is the least in the array, assign i to 'indexOfMin'
		*   For j from i+1 to the end of array
		*     See if there is an element with smaller value
		*       If there is, record its index
		*   If the index of the current element and the index of the 'smallest' element is not the same, swap them.
		* 
		*/
    static public int[] Selection(int[] arr)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        int indexOfMin = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
          if (arr[j] < arr[indexOfMin])
          {
            indexOfMin = j;
          }
        }
        if (indexOfMin != i)
        {
          int temp = arr[i];
          arr[i] = arr[indexOfMin];
          arr[indexOfMin] = temp;
        }
      }
      return arr;
    }

    /**
		Merge sorting:
		The purpose of merge function is to take two sorted arrays(left, right) into one sorted array
		* 
		* How...
		* Create an empty array to hold the sorted array called 'merged'
		* While there are still elements in both arrays
		*   If the first element of the left half is less than first in the right half
		*     'Shift' the element from the left into the 'merged' array
		*   else 
		*     'Shift' the element from the right into the 'merged' array
		* Take everything from the array that still has element(s) in it and put it in 'merged'
		 */
    static public int[] Merge(int[] arr)
    {
      if (arr.Length == 1)
      {
        return arr;
      }
      int centerIndex = (int)(Math.Floor(arr.Length / 2.0));
      int[] leftArr = new List<int>(arr).GetRange(0, centerIndex).ToArray();
      int[] rightArr = new List<int>(arr).GetRange(centerIndex, arr.Length - centerIndex).ToArray();
      return MergeArray(Merge(leftArr), Merge(rightArr));

    }

    static private int[] MergeArray(int[] left, int[] right)
    {
      var mergedList = new List<int>();
      var leftList = new List<int>(left);
      var rightList = new List<int>(right);
      while (leftList.Count > 0 && rightList.Count > 0)
      {
        if (leftList[0] < rightList[0])
        {
          mergedList.Add(leftList[0]);
          leftList.RemoveAt(0);
        }
        else
        {
          mergedList.Add(rightList[0]);
          rightList.RemoveAt(0);
        }
      }
      mergedList.AddRange(leftList);
      mergedList.AddRange(rightList);
      return mergedList.ToArray();

    }

  }
}