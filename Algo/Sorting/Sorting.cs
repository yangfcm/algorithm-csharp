using System;
using System.Collections.Generic;

namespace Algo.Sorting
{
  /**
	Implement bubble sort, selection sort and merge sort.
	 */
  public class Sort
  {
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