using System;

namespace DataStructures.Array
{
    static class InsertionSort
    {
        /// <summary>
        /// Time complexity is O(n^2)
        /// </summary>
        public static void Sort<T>(T[] arr) where T : IComparable
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j].CompareTo(arr[j - 1]) < 0)
                {
                    arr.Swap(j, j - 1);
                    j--;
                }
            }
        }
    }
}
