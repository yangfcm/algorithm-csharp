using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo.Arr
{
    /// <summary>
    /// Given an array of positive numbers and an integer m, find the contiguous subarray where
    /// the sum of its elements mod m is the largest.
    /// </summary>
    /// <example>
    /// arr = [3, 3, 9, 9, 5] m = 7 -> 6 ( 3%7 + 3%7 = 6)
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/maximum-subarray-sum/problem
    /// </source>
    public class MaxSubArrayModSum
    {
        /// <summary>
        /// Brutal force comparison. Time complexity: O(n^2).
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="m"></param>
        /// <returns>The maximum sum of the subarray mod m.</returns>
        public static long Solution1(long[] arr, long m)
        {
            long maxSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                long sum = arr[i] % m;
                if(sum > maxSum) maxSum = sum;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum = (sum + arr[j]) % m;
                    if(sum > maxSum) maxSum = sum;
                }
            }
            return maxSum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="m"></param>
        /// <returns>The maximum sum of the subarray mod m.</returns>
        public static long Solution2(long[] arr, long m)
        {
            long maxSum = 0;
            long minDiff = m;
            long sum = 0;

            var sumArr = new LinkedList<long[]>();
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                sumArr.AddLast(new long[] { i, sum % m });
                maxSum = Math.Max(maxSum, sum % m);
            }

            var sortedSumArr = sumArr.OrderBy(sum => sum[1]).ToArray();

            for (int i = 1; i < sortedSumArr.Length; i++)
            {
                if(sortedSumArr[i][1] > sortedSumArr[i-1][1] && sortedSumArr[i][0] < sortedSumArr[i-1][0])
                {
                    minDiff = Math.Min(minDiff, sortedSumArr[i][1] - sortedSumArr[i - 1][1]);
                }
            }
            maxSum = Math.Max(maxSum, m - minDiff);
            return maxSum;
        }
        
    }
}