using System;

namespace DataStructures.Array
{
    static class SelectionSort
    {
        /// <summary>
        /// Time complexity is O(n^2)
        /// </summary>
        public static void Sort<T>(T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                T minValue = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = arr[j];
                    }
                }

                arr.Swap(minIndex, i);
            }
        }
    }
}
