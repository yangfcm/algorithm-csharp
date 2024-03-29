using System;
using System.Collections.Generic;
namespace Algo.Sorting
{
    /// <summary>
    /// In an array, if elements at indices i and j (i < j) while arr[j] > arr[i],
    /// we need to swap them to make it in a right order.
    ///  Given an array, calculate how many swaps/inversions required to sort the array.
    /// </summary>
    /// <example>
    /// arr = [2, 1, 3, 1, 2], countInversions(arr) -> 4
    /// To make array [2, 1, 3, 1, 2] sorted, here is what to do:
    /// [2, 1, 3, 1, 2], index: 0, 1, elements: arr[0] = 2, arr[1] = 1 -> 1 swap -> [1, 2, 3, 1, 2]
    /// [1, 2, 3, 1, 2], index: 1, 2, elements: arr[1] = 2, arr[2] = 3 -> No swap -> [1, 2, 3, 1, 2]
    /// [1, 2, 3, 1, 2], index: 2, 3, elements: arr[2] = 3, arr[3] = 1 -> 2 swaps -> [1, 1, 2, 3, 2]
    /// [1, 1, 2, 3, 2], index: 3, 4, elements: arr[3] = 3, arr[4] = 2 -> 1 swap -> [1, 1, 2, 2, 3]
    /// So the result is 1 + 2 + 1 = 4 swaps.
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/ctci-merge-sort
    /// </source>
    public class CountInversions
    {
        private static int count = 0;
        /// <summary>
        /// This is a straightforward solution. Iterate through the array(from index = 1) and for each particular element,
        /// look at its previous elements and if there's any one bigger than it, it means one swap required, i.e. adding count by 1.
        /// Time complexity: O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>The number of inversions required to sort a given array</returns>
        public static int Solution1(int[] arr) {
            count = 0;
            for (int i = 1; i < arr.Length; i++) {
                int current = arr[i];
                for (int j = i - 1; j >= 0; j--) {
                    if(arr[j] > current) count++;
                }
            }
            return count;
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
                if (leftList[0] <= rightList[0])
                {
                    mergedList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }
                else
                {
                    count += leftList.Count;
                    mergedList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }
            mergedList.AddRange(leftList);
            mergedList.AddRange(rightList);
            return mergedList.ToArray();
        }

        /// <summary>
        /// Use the method of merge sort. Time complexity: n*log(n). Most code is from Sorting.Merge()
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>The number of inversions required to sort a given array</returns>
        public static int Solution2(int[] arr) {
            count = 0;
            Merge(arr);
            return count;
        }
    }
}