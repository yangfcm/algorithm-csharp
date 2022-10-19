using System;

namespace Algo.Greedy
{
    /// <summary>
    ///  Given an array of integers, find the minimum absolute difference between any two elements in the array.
    /// </summary>
    /// <example>
    /// arr = [1 -3 71 68 17] -> 3 (|71-68|= 3)
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array
    /// </source>
    public class MinimumAbsoluteDifference
    {
        /// <summary>
        /// Sort and iterate through the array.
        /// Calculate the absolute difference between the number and its next number and find out the minimum one.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>The minimum absolute difference found.</returns>
        public static int Solution(int[] arr)
        {
            int minDiff = Int32.MaxValue;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int diff = Math.Abs(arr[i] - arr[i + 1]);
                if(diff < minDiff)
                {
                    minDiff = diff;
                }
            }
            return minDiff;
        }
    }
}