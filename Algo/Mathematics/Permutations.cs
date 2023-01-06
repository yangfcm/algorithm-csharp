using System.Collections.Generic;
using System.Linq;

namespace Algo.Mathematics
{
    /// <summary>
    /// Given an array of distinct integers, return all the possible permutations.
    /// </summary>
    /// <example>
    /// arr = [1, 2, 3]
    /// All permutations for 1, 2, 3 are:
    /// [1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1]
    /// </example>
    /// <source>
    /// https://leetcode.com/problems/permutations/
    /// </source>
    public class Permutations
    {
        public static List<List<int>> Solution(int[] arr)
        {
            List<List<int>> permutations = new();
            if(arr.Length == 0) return new List<List<int>>();
            if(arr.Length == 1) {
                return new List<List<int>> { new List<int>(arr) };
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                int[] leftSubArr = arr[..i];
                int[] rightSubArr = arr[(i+1)..];
                int[] remainingNumbers = leftSubArr.Concat(rightSubArr).ToArray();
                List<List<int>> remainingNumbersPermuted = Solution(remainingNumbers);
                for (int j = 0; j < remainingNumbersPermuted.Count; j++) 
                {
                    List<int> foundPermutation = new();
                    foundPermutation.Add(current);
                    for (int k = 0; k < remainingNumbersPermuted[j].Count; k++)
                    {
                        foundPermutation.Add(remainingNumbersPermuted[j][k]);
                    }
                    permutations.Add(foundPermutation);
                }
            }
            return permutations;
        }
    }
}