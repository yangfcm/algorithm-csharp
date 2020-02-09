using System;
using System.Collections.Generic;

namespace Algo
{
	/**
	* Given an array of integers, return indices of the two numbers such that
	* they add up to a specific target.
	* Assume each input would have excactly one solution and you cannot use the same element twice
	* e.g.
	* Given nums = [2, 7, 11, 15], target = 9
	* Because nums[0] + nums[1] = 2 + 7 = 9
	* return [0, 1]
*/
	public class TwoSum
	{
		static public int[] RunSolution1(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length - 1; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] + nums[j] == target)
					{
						return new int[] { i, j };
					}
				}
			}
			throw new Exception("Wrong arguments");
		}

		static public int[] RunSolution2(int[] nums, int target)
		{
			var map = new Dictionary<int, int>();
			for (int i = 0; i < nums.Length; i++)
			{
				int complement = target - nums[i];
				if (map.ContainsKey(complement))
				{
					return new int[] { map[complement], i };
				}
				map.Add(nums[i], i);
			}
			throw new Exception("Wrong arguments");
		}
	}
}