using System;

namespace Algo
{
	/**
	Take an unsorted array of unique numbers from 1 to n.
	Return the missing number in the sequence or null if there is no missing number
	There is either no missing number or exactly one missing number.
	e.g.!-- [1, 4, 3, 5] => 2
		[2, 3, 4, 1] => null
		[] => null
	 */
	public class Missing
	{
		/**
		Solution: find the max number of the array
		If max number equals array's length, it means no missing number so return null
		Otherwise, increment i from 1 to max; if i odesn't exist in the array, it is exactly the missint number.
		 */
		public static int? RunSolution1(int[] array)
		{
			if (array.Length == 0)
			{
				return null;
			}
			int max = array[0];
			foreach (int num in array)
			{
				if (num > max)
				{
					max = num;
				}
			}
			if (max == array.Length) return null;
			for (int i = 1; i <= max; i++)
			{
				if (Array.IndexOf(array, i) == -1)
				{
					return i;
				}
			}
			return null;
		}

		public static int? RunSolution2(int[] array)
		{
			// Sum the array and keep track of the maximum number
			if (array.Length == 0)
			{
				return null;
			}
			int max = array[0];
			int sum = 0;

			foreach (int num in array)
			{
				sum += num;
				if (num > max)
				{
					max = num;
				}
			}

			// The maximum number tells how long the aray should be.
			// Plug it into the formula to sum a series to see what we should expect the sum to be.
			int expectedSum = max * (max + 1) / 2;
			int diff = expectedSum - sum;
			if (diff == 0)
			{
				return null;
			}
			else
			{
				return diff;
			}

		}
	}
}