using System;

namespace Algo.Greedy
{
    /// <summary>
    /// A group of friends want to buy a bouquet of flowers. The florist wants to maximize the earning.
    /// To do this, he multiplies the price of each flower by the number of the same customer's previously purchased flowers plus 1.
    /// For example, if a customer buys one flower previously, then he will be charged (1+1)*original price for his next flower.
    /// Given the number of friends and an array of the original prices of the flowers, work out the minimum cost to buy all of the flowers.
    /// </summary>
    /// <example>
    /// costs = [1, 3, 5, 7, 9] k = 3 -> 29
    /// The original prices of flowers are 1, 3, 5, 7, 9 and we have 3 people(p1, p2, p3) to buy all of the 5 flowers.
    /// To spend the least money, p1, p2 and p3 buy the three most expensive flowers (5, 7, 9) respectively,
    /// Then two of the three people should buy their second flowers at price of 1 and 3, which will cost them (1+1)*1 = 2 and (1+1)*3 = 6 respectively.
    /// So the minimum cost is 5 + 7 + 9 + 2 + 6 = 29
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/greedy-florist
    /// </source>
    public class GreedyFlorist
    {
        /// <summary>
        /// To achieve the minimum cost, for each person, they should buy the most expensive flowers available and leave the less expensive for the next time(if possible)
        /// because for the old customers, the price will get multiplied.
        /// </summary>
        /// <param name="costs"></param>
        /// <param name="k"></param>
        /// <returns>The minimum cost</returns>
        public static int Solution(int[] costs, int k)
        {
            int totalCost = 0;
            Array.Sort(costs);
            Array.Reverse(costs);   // Sort the costs array from biggest to smallest

            for (int i = 0; i < costs.Length; i++) {
                totalCost += costs[i] * (1 + i / k);
            }

            return totalCost;
        }
    }
}