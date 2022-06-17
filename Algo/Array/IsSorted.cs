namespace Algo.Arr
{
  /**
	 * Given an array of numbers, return true or false, indicating whether the array is sorted.
	 */
  public class IsSorted
  {
    static public bool Run(int[] array)
    {
      if (array.Length <= 1) return true;
      for (int i = 0; i < array.Length - 1; i++)
      {
        if (array[i] > array[i + 1])
        {
          return false;
        }
      }
      return true;
    }
  }
}