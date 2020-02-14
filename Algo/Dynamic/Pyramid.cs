using System;

namespace Algo
{
	/**
Accept a positive number n
The function should console write a pyramid shape with n levels using # character.
Make sure the step has spaces on both left and right side.
e.g.!--  2 =>
' # '
'###'
3 =>
'  #  '
' ### '
'#####'
4 =>
'   #   '
'  ###  '
' ##### '
'#######'
 */
	public class Pyramid
	{
		public static void Run(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				var level = "";
				for (int j = 1; j <= (2 * n - 1); j++)
				{
					if (j >= (n - i + 1) && j <= (n + i - 1))
					{
						level += "#";
					}
					else
					{
						level += " ";
					}
				}
				Console.WriteLine(level);
			}
		}
	}
}