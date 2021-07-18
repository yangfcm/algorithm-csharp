using System.Linq;

/**
 * Say you have an array for which the ith element is the price of a given stock on day i.
 * Design an algorithm to find the maximum profit. You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).
 * e.g. [7, 1, 5, 3, 6, 4] => 7 ( (5-1) + (6-3) = 7 )
 * @param {number[]} prices
 * @return {number}
 */
namespace Algo.Assorted
{
  public class MaxProfit
  {
    static public int Run(int[] prices)
    {
      int profit = 0;
      bool holding = false;
      int buyPrice = 0;
      int sellPrice;
      prices = prices.Concat(new int[] { 0 }).ToArray();  // Add 0 to the end of array to prevent outside-bound exception.
      for (int i = 0; i < prices.Length - 1; i++)
      {
        if (prices[i] <= prices[i + 1] && !holding)
        {
          // Buy stock
          buyPrice = prices[i];
          holding = true;
        }

        if (prices[i] > prices[i + 1] && holding)
        {
          // Sell stock and accumulate the profit
          sellPrice = prices[i];
          holding = false;
          profit += sellPrice - buyPrice;
          buyPrice = 0;
          // sellPrice = 0;
        }
      }
      return profit;
    }
  }
}