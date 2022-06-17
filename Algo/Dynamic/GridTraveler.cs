using System.Collections.Generic;

/**
 * Say that you are a traveler on a 2D grid.
 * You begin in the top-left corner and end in the bottom-right corner.
 * You may only move down or right.
 * Create algorithm to calculate how many routes you can travel to the goal on a grid with dimensions m*n.
 * Example:
 * m = 2, n = 3
 * It creates a 2 x 3 grid, which looks like this:
 * +---+---+---+
 * + a +   +   +
 * +---+---+---+
 * +   +   + b +
 * +---+---+---+
 * To travel from a to b, you can have 3 routes in total as below:
 * R -> R -> D
 * R -> D -> R
 * D -> R -> R
 * R - right, D - down.
 */

namespace Algo.Dynamic
{
  public class GridTraveler
  {
    // Recursive
    static public long Solution1(int m, int n)
    {
      if (m == 1 && n == 1) return 1;
      if (m == 0 || n == 0) return 0;
      return Solution1(m - 1, n) + Solution1(m, n - 1);
    }

    // Use memoization
    static public long Solution2(int m, int n)
    {
      if (m == 1 && n == 1) return 1;
      if (m == 0 || n == 0) return 0;
      return Solution2(m, n, new Dictionary<string, long>());
    }

    static public long Solution2(int m, int n, Dictionary<string, long> memo)
    {
      if (m == 1 && n == 1) return 1;
      if (m == 0 || n == 0) return 0;
      var key = m + "," + n;
      if (memo.ContainsKey(key)) return memo[key];
      memo[key] = Solution2(m - 1, n, memo) + Solution2(m, n - 1, memo);
      return memo[key];
    }

    static public long Solution3(int m, int n)
    {
      var travelArr = new long[m + 1, n + 1];
      travelArr[1, 1] = 1;
      for (int i = 0; i <= m; i++)
      {
        for (int j = 0; j <= n; j++)
        {
          if (i <= 1 && j <= 1)
          {
            continue;
          }
          var prevRow = i >= 1 ? travelArr[i - 1, j] : 0;
          var prevCol = j >= 1 ? travelArr[i, j - 1] : 0;
          travelArr[i, j] = prevRow + prevCol;
        }
      }
      return travelArr[m, n];
    }
  }
}