using System.Linq;

namespace Algo.Arr
{
    /// <summary>
    /// Given an array of integers, find the contiguous subarray which has the largest sum and return its sum
    /// The array should contain positive number and negative number.
    /// </summary>
    /// <example>
    /// arr = [-2,1,-3,4,-1,2,1,-5,4] -> 6 (The subarray is [4, -1, 2, 1], 4 + (-1) + 2 + 1 = 6)
    /// </example>
    /// <source>
    /// https://leetcode.com/problems/maximum-subarray/
    /// </source>
    public class MaxSubArraySum
    {
        /// <summary>
        /// Brutal force comparison. Find out all the possible contiguous subarrays and compare their sums.
        /// Time complexity: O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>The largest sum of subarray</returns>
        public static int Solution1(int[] arr)
        {
            int maxSum = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = arr[i];
                if(sum > maxSum) maxSum = sum;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if(sum > maxSum) maxSum = sum;
                }
            }
            return maxSum;
        }

        /// <summary>
        /// Kadane's algorithm: https://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>The largest sum of subarray</returns>
        public static int Solution2(int[] arr)
        {
            int maxSoFar = int.MinValue;
            int maxEndingHere = 0;
            foreach(int n in arr)
            {
                maxEndingHere += n;
                if(maxSoFar < maxEndingHere) maxSoFar = maxEndingHere;
                if(maxEndingHere < 0) maxEndingHere = 0;
            }
            return maxSoFar;
        }

        /// <summary>
        /// Divide and conquer algorithm: https://www.geeksforgeeks.org/maximum-subarray-sum-using-divide-and-conquer-algorithm/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>The largest sum of subarray</returns>
        public static int Solution3(int[] arr)
        {
            return Solution3(arr, 0, arr.Length - 1);
        }

        private static int Solution3(int[] arr, int low, int high)
        {
            if(low > high) return int.MinValue;
            if(low == high) return arr[low];
            int mid = (low + high) / 2;
            return new int[] { Solution3(arr, low, mid-1), Solution3(arr, mid+1, high), MaxCrossingSum(arr, low, mid, high) }.Max();
        }

        private static int MaxCrossingSum(int[] arr, int low, int mid, int high)
        {
            int sum = 0;
            int leftSum = int.MinValue;
            for (int i = mid; i >= low; i--)
            {
                sum += arr[i];
                if(sum > leftSum) leftSum = sum;
            }

            sum = 0;
            int rightSum = int.MinValue;
            for (int i = mid; i <= high; i++)
            {
                sum += arr[i];
                if(sum > rightSum) rightSum = sum;
            }

            return new[] {leftSum + rightSum - arr[mid], leftSum, rightSum}.Max();
        }
    }
}