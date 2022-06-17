namespace Algo.Searching
{
  public class LinearSearch
  {
    public static int Run(int[] arr, int val)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] == val)
        {
          return i;
        }
      }
      return -1;
    }
  }
}