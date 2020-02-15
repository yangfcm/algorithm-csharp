using System;
using System.Collections.Generic;

namespace Algo
{
	/**
	* Determine if a 9x9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
 * 1 - Each row must contain the digits 1-9 without repetition.
 * 2 - Each column must contain the digits 1-9 without repetition.
 * 3 - Each of the 9 3x3 sub-boxes of the grid must contain the digits 1-9 without repetition.
 * The Sudoku board could be partially filled, where empty cells are filled with the character '.'.
 * e.g. Input:
	[
		["5","3",".",".","7",".",".",".","."],
		["6",".",".","1","9","5",".",".","."],
		[".","9","8",".",".",".",".","6","."],
		["8",".",".",".","6",".",".",".","3"],
		["4",".",".","8",".","3",".",".","1"],
		["7",".",".",".","2",".",".",".","6"],
		[".","6",".",".",".",".","2","8","."],
		[".",".",".","4","1","9",".",".","5"],
		[".",".",".",".","8",".",".","7","9"]
	]
	Output: true
	Input:
	[
		["8","3",".",".","7",".",".",".","."],
		["6",".",".","1","9","5",".",".","."],
		[".","9","8",".",".",".",".","6","."],
		["8",".",".",".","6",".",".",".","3"],
		["4",".",".","8",".","3",".",".","1"],
		["7",".",".",".","2",".",".",".","6"],
		[".","6",".",".",".",".","2","8","."],
		[".",".",".","4","1","9",".",".","5"],
		[".",".",".",".","8",".",".","7","9"]
	]
	Output: false
	 */
	public class ValidSudoku
	{
		static public bool Run(string[,] board)
		{
			int n = 9;
			for (int i = 0; i < n; i++)
			{
				List<string> row = new List<string>();
				List<string> col = new List<string>();
				List<string> box = new List<string>();
				for (int j = 0; j < n; j++)
				{
					if (board[i, j] != ".")
					{
						// Check row to see if valid
						if (row.IndexOf(board[i, j]) >= 0)
						{
							return false;
						}
						row.Add(board[i, j]);
					}

					if (board[j, i] != ".")
					{
						// Check col to see if valid
						if (col.IndexOf(board[j, i]) >= 0)
						{
							return false;
						}
						col.Add(board[j, i]);
					}

					string elBox = board[3 * (i / 3) + (j / 3), 3 * (i % 3) + (j % 3)];
					if (elBox != ".")
					{
						// Check box to see if valid
						if (box.IndexOf(elBox) >= 0)
						{
							return false;
						}
						box.Add(elBox);
					}
				}
			}
			return true;
		}
	}
}