using System.Linq;

/**
 * Say you have an array for which the i-th element is the price of a given stock on day i.
 * Design an algorithm to find the maximum profit. You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).
 * Example [7, 1, 5, 3, 6, 4] => 7 ((5-1) + (6-3) = 7)
 * The array indicates the stock price for each day:
 * +-----------------------------+
 * + D1 | D2 | D3 | D4 | D5 | D6 +
 * +-----------------------------+
 * +  7 |  1 |  5 |  3 |  6 |  4 +
 * +-----------------------------+
 * To gain the max profit, you need to buy stock  at price of 1 on D2 and sell it at price of 5 on D3. You earn 5 - 1 = 4 in this transaction.
 * Then you buy stock at price of 3 on D4 and sell it at price of 6 on D5. You earn 6 - 3 = 3 in this transaction.
 * So in total, the maximum profit you can earn is 4 + 3 = 7.
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