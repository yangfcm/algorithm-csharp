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
        public static long Solution1(long[] arr, int m)
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
    }
}