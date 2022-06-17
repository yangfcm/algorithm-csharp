using System;

namespace Algo.Arr
{
  /**
    * Given an n x n 2D matrix representing an image.
    * Rotate the image by 90 degrees (clockwise).
    * Example 
    * Given input matrix =
        [
          [ 5, 1, 9,11],
          [ 2, 4, 8,10],
          [13, 3, 6, 7],
          [15,14,12,16]
        ], 
        rotate the input matrix such that it becomes:
        [
          [15,13, 2, 5],
          [14, 3, 4, 1],
          [12, 6, 8, 9],
          [16, 7,10,11]
        ]
	 */
  public class RotateImage
  {
    static public int[,] Run(int[,] matrix)
    {
      int n = (int)Math.Sqrt(matrix.Length);
      for (int i = 0; i < n / 2; i++)
      {   // i represents the i-th layer of the matrix from outside to inside.
        for (int j = i; j < n - 1 - i; j++)
        {
          // For each layer, do the rotation, the algorithm is as follows:
          // move number at [i][j] to [j][n-1-i]
          // move number at [j][n-1-i] to [n-1-i][n-1-j]
          // move number at [n-1-i][n-1-j] to [n-1-j][i]
          // move number at [n-1-j][i] to [i][j]
          int temp = matrix[i, j];
          matrix[i, j] = matrix[n - 1 - j, i];
          matrix[n - 1 - j, i] = matrix[n - 1 - i, n - 1 - j];
          matrix[n - 1 - i, n - 1 - j] = matrix[j, n - 1 - i];
          matrix[j, n - 1 - i] = temp;
        }
      }
      return matrix;
    }
  }
}