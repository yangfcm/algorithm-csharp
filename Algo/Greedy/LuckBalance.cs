using System;
using System.Collections;

namespace Algo.Greedy
{
    /// <summary>
    /// There is an array to represent a series of contests.
    /// Each element(contest) is also an array which has two integer numbers.
    /// The first number is the luck point; the second is 1 or 0 to indicate if the contest is important or not.
    /// The rule is if you lose the contest, you can earn the luck point; if you win the contest, you will lose the luck point.
    /// You cannot lose more than k importnat contests.
    /// Given k and contests arrays, work out the maximum luck points you can earn. * 
    /// </summary>
    /// <example>
    /// k = 3, contests = [[5, 1], [2, 1], [1, 1], [8, 1], [10, 0], [5, 0]] -> 29
    /// There are 6 contests, 4 of which are important and you cannot lost more than k=3 of them.
    /// You can get the maximum luck balance by losing all unimportant contests(index = 4, 5) and the first, second and fourth(index = 0, 1, 3) important contests.
    /// So the total luck balance is 5 + 2 - 1 + 8 + 10 + 5 = 29.
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/luck-balance
    /// </source>
    public class LuckBalance
    {
        public static int Solution(int k, int[][] contests)
        {
            int maxLuck = 0;
            int importantLost = 0;
            Array.Sort(contests, new SortByContestPoint());

            foreach (int[] contest in contests)
            {
                if(contest[1] == 0)
                {
                    maxLuck += contest[0];
                    continue;
                }
                if(importantLost < k)
                {
                    maxLuck += contest[0];
                    importantLost++;
                } else {
                    maxLuck -= contest[0];
                }
            }
            return maxLuck;
        }
    }

    public class SortByContestPoint: IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            return ((int[])x)[0] > ((int[])y)[0] ? -1 : 1;
        }
    }
}