namespace Algo.Sorting
{
    /// <summary>
    /// In an array, if elements at indices i and j (i < j) while arr[j] > arr[i],
    /// we need to swap them to make it in a right order.
    ///  Given an array, calculate how many swaps/inversions required to sort the array.
    /// </summary>
    /// <example>
    /// arr = [2, 1, 3, 1, 2], countInversions(arr) -> 4
    /// To make array [2, 1, 3, 1, 2] sorted, here is what to do:
    /// [2, 1, 3, 1, 2], index: 0, 1, elements: arr[0] = 2, arr[1] = 1 -> 1 swap -> [1, 2, 3, 1, 2]
    /// [1, 2, 3, 1, 2], index: 1, 2, elements: arr[1] = 2, arr[2] = 3 -> No swap -> [1, 2, 3, 1, 2]
    /// [1, 2, 3, 1, 2], index: 2, 3, elements: arr[2] = 3, arr[3] = 1 -> 2 swaps -> [1, 1, 2, 3, 2]
    /// [1, 1, 2, 3, 2], index: 3, 4, elements: arr[3] = 3, arr[4] = 2 -> 1 swap -> [1, 1, 2, 2, 3]
    /// So the result is 1 + 2 + 1 = 4 swaps.
    /// </example>
    public class CountInversions
    {
        private static int count = 0;

        public static int Solution1(int[] arr) {
            count = 0;
            for (int i = 1; i < arr.Length; i++) {
                int current = arr[i];
                for (int j = i - 1; j >= 0; j--) {
                    if(arr[j] > current) count++;
                }
            }
            return count;
        }
    }
}