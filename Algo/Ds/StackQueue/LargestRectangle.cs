using System;
using System.Collections.Generic;

namespace Algo.Ds.StackQueue
{
    /// <summary>
    /// Given an array of integers heights representing the histogram's bar height
    /// where the width of each bar is 1, return the area of the largest rectangle in the histogram.
    /// </summary>
    /// <example>
    /// heights = [2, 1, 5, 6, 2, 3] -> 10
    ///        _
    ///      _| |
    ///     |+|+|
    ///     |+|+|  _
    ///  _  |+|+|_| |
    /// | |_|+|+| | |
    /// | | |+|+| | |
    /// -2-1-5-6-2-3-
    /// The above is the a histogram where width of each bar is 1.
    /// The largest rectangle is the one created by 5 and 6, which has an area of 2 * 5 = 10 units.
    /// </example>
    /// <source>
    /// https://leetcode.com/problems/largest-rectangle-in-histogram/description/
    /// </source>
    public class LargestRectangle
    {
        static public int Solution(int[] heights)
        {
            int maxArea = 0;
            Stack<int> stack = new();
            for (int i = 0; i < heights.Length; i++)
            {
                int height = heights[i];
                if(stack.Count == 0 || height >= heights[stack.Peek()])
                {
                    stack.Push(i);
                }
                else 
                {
                    while(stack.Count > 0 && heights[stack.Peek()] > height)
                    {
                        int top = stack.Pop();
                        int high = i;
                        int low = stack.Count > 0 ? stack.Peek() : -1;
                        int area = heights[top] * (high - low - 1);
                        maxArea = Math.Max(maxArea, area);
                    }
                    stack.Push(i);
                }
            }

            while(stack.Count > 0)
            {
                int top = stack.Pop();
                int high = heights.Length;
                int low = stack.Count > 0 ? stack.Peek() : -1;
                int area = heights[top] * (high - low - 1);
                maxArea = Math.Max(maxArea, area);
            }

            return maxArea;
        }
    }
}