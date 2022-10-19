using System;

namespace Algo.Greedy
{
    /// <summary>
    ///  Given an array of integers and a single integer k, create an array of length k from
    /// elements of arr such that its difference between the biggest element and smallest element is minimized.
    /// </summary>
    /// <example>
    /// arr = [10, 100, 300, 200, 1000, 20, 30], k = 3 -> 20
    /// Choose k = 3 elements from arr: [10, 20, 30] where the maximum is 30 and the minimum is 10 and their difference is 20.
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/angry-children
    /// </source>
    public class MaxMin
    {
        /// <summary>
        /// Take the above as example: First sort the array like [10, 20, 30, 100, 200, 300, 1000]
        /// Imagine there is a "window" of length of k moving along the array,
        /// test the difference between the first element and last element in the window and find out the minimum one.
        /// [10, 20, 30,] 100, 200, 300, 1000 -> 20
        /// 10, [20, 30, 100,] 200, 300, 1000 -> 80
        /// 10, 20, [30, 100, 200,] 300, 1000 -> 170
        /// 10, 20, 30, [100, 200, 300,] 1000 -> 200
        /// 10, 20, 30, 100, [200, 300, 1000] -> 800
        /// So the minimum is 20.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns>The sub array of of length k from elements of arr that has the minimum difference.</returns>
        public static int Solution(int[] arr, int k)
        {
            Array.Sort(arr);
            int minDiff = Int32.MaxValue;
            for (int i = 0; i < arr.Length - k; i++)
            {
                int diff = arr[i + k - 1] - arr[i];
                if(diff < minDiff)
                {
                    minDiff = diff;
                }
            }
            return minDiff;
        }
    }
}