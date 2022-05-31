using System;

namespace DataStructures.Array
{
    static class QuickSort
    {
        public static void Sort<T>(T[] arr) where T : IComparable
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort<T>(T[] arr, int lower, int upper) where T : IComparable
        {
            if (lower < upper)
            {
                int partitionIndex = Partitiopn(arr, lower, upper);
                Sort(arr, lower, partitionIndex - 1);
                Sort(arr, partitionIndex + 1, upper);
            }
        }

        private static int Partitiopn<T>(T[] arr, int lower, int upper) where T : IComparable
        {
            int pivotIndex = lower;
            T pivotElement = arr[upper];

            for (int i = lower; i < upper; i++)
            {
                if (pivotElement.CompareTo(arr[i]) > 0)
                {
                    arr.Swap(i, pivotIndex);
                    pivotIndex++;
                }
            }

            arr.Swap(pivotIndex, upper);
            return pivotIndex;
        }
    }
}
