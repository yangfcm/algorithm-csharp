using System;

namespace Algo.Dynamic
{
    /// <summary>
    /// A string is considered to be a child of another string if it can be formed by deleting 0 or more characters from the other string.
    /// Given two strings of equal length, find out the longest string that can be constructed such that it is a child of both.
    /// </summary>
    /// <example>
    /// s1 = 'ABCD', s2 = 'ABDC'. These two strings have two children with maximum length 3.
    /// They are 'ABC' and 'ABD'. They can be formed by eliminating either D or C from both strings.
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/common-child
    /// </source>
    public class CommonChild
    {
        /// <summary>
        /// The solution is explained in this article: https://en.wikipedia.org/wiki/Longest_common_subsequence_problem
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>The length of the longest string which is a common child of the two given strings.</returns>
        public static int Solution(string s1, string s2)
        {
            int[,] table = new int[s1.Length + 1, s2.Length + 1];
            for (int i = 1; i <= s1.Length; i++) {
                for (int j = 1; j <= s2.Length; j++) {
                    if(s1[i-1] == s2[j-1]) {
                        table[i, j] = table[i-1, j- 1] + 1;
                    } else {
                        table[i, j] = Math.Max(table[i - 1, j], table[i, j - 1]);
                    }
                }
            }
            return table[s1.Length, s2.Length];
        }
    }
}