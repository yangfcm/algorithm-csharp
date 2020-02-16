using System.Linq;

namespace Algo
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