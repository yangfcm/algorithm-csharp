using System;
using System.Linq;

namespace Algo.Arr
{
    /// <summary>
    /// Given 3 arrays of a, b, c of different sizes, find the number of distinct triplets (p, q, r),
    /// where p is from a, q from b, r from c, satisfying the criteria: p <= q and q >= r
    /// </summary>
    /// <example> a = [3, 5, 7], b = [3, 6], c = [4, 6, 9] -> 4.
    /// There are 4 such distinct triplets. They are: (3, 6, 4), (3, 6, 6), (5, 6, 4), (5, 6, 6).
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/triple-sum
    /// </source>
    public class TripleSum
    {
        /// <summary>
        /// Iterate through array b. For each element in array b (bn),
        /// find out how many numbers in array a smaller than or equal to bn (use variable ai to save the number)
        /// and how many numbers in array c smaller than or equal to bn (use variable ci to save the number).
        /// So for this particular element - bn, there are ai * ci such triples. Then sum all the counts for each element in array b.
        /// While doing iteration, you should not recount the repetitive triplets.
        /// We need to do some optimisation before iteration:
        /// 1 - Remove duplicate elements from array a, b and c.
        /// 2 - Sort the array.
        /// By doing so:
        /// 1 - we can guarantee each combination is a unique one.
        /// 2 - Faster speed.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>The number of triplets defined in the description</returns>
        public static int Solution(int[] a, int[] b, int[] c)
        {
            a = a.Distinct().OrderByDescending(n => n).ToArray();
            b = b.Distinct().OrderByDescending(n => n).ToArray();
            c = c.Distinct().OrderByDescending(n => n).ToArray();
            // Remove duplicate elements and sort.

            int count = 0;
            int ai = 0;
            int ci = 0;
            foreach(int bn in b)
            {
                while(ai < a.Length) {
                    if(a[ai] <= bn) break;
                    ai++;
                }
                while(ci < c.Length) {
                    if(c[ci] <= bn) break;
                    ci++;
                }
                int aCount = a.Length - ai;
                int cCount = c.Length - ci;
                count += aCount * cCount;
            }

            return count;
        }
    }
}