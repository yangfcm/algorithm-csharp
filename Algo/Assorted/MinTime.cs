using System;
using System.Linq;

namespace Algo.Assorted
{
    /// <summary>
    /// You are planning production for an order.
    /// You have a number of machines that each have a fixed number of days to produce an item.
    /// Given that all the machines operate simultaneously,
    /// determine the minimum number of days to produce the required order.
    /// </summary>
    /// <example>
    /// machines = [2, 3, 2], goal = 10 -> 8
    /// There are three machines, and machine 1 and 3 needs to spend 2 days to produce one item;
    /// machine 2 spend 3 days to product one item.
    /// The schedule is as below:
    /// Day | Production | Finished items
    /// ---------------------------------
    /// 1   | 0          | 0
    /// 2   | 2          | 2
    /// 3   | 1          | 3
    /// 4   | 2          | 5
    /// 5   | 0          | 5
    /// 6   | 3          | 8
    /// 7   | 0          | 8
    /// 8   | 2          | 10
    /// So on day 8, we can product 10 items which reaches the goal.
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/minimum-time-required
    /// </source>
    public class MinTime
    {
        /// <summary>
        /// Use the concept of binary search.
        /// </summary>
        /// <param name="machines"></param>
        /// <param name="goal"></param>
        /// <returns>The minimum days required to produce the target items</returns>
        public static int Solution(int[] machines, int goal)
        {
            int minMachine = machines.Min();
            int maxMachine = machines.Max();
            int minDays = goal * minMachine / machines.Length;
            int maxDays = goal * maxMachine / machines.Length;
            int days = Math.Max(minDays, maxDays);

            while(true)
            {
                int mid = (minDays + maxDays) / 2;
                if(minDays == mid || maxDays == mid) break;
                if(DailyOutcome(machines, mid) < goal)
                {
                    minDays = mid;
                } else
                {
                    maxDays = mid;
                }
                days = Math.Max(minDays, maxDays);
            }
            return days;
        }

        /// <summary>
        /// Find out how many items are produced by the end of k-th day with given machines.
        /// </summary>
        /// <param name="machines"></param>
        /// <param name="k"></param>
        /// <returns>How many items are produced by the end of k-th day with given machines</returns>
        private static int DailyOutcome(int[] machines, int k)
        {
            int items = 0;
            foreach(int m in machines)
            {
                items += k / m;
            }
            return items;
        }
    }
}