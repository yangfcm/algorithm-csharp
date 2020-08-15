namespace Algo.Arr
{
  /**
	Return true or false, indicating whether a given array of numbers is sorted
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