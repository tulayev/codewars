using System;

namespace DataStructures.Array
{
    static class NumberArrayGenerator
    {
        public static int[] GetArray(int length, int from, int to)
        {
            Random random = new Random();
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(from, to);
            }

            return arr;
        }

        public static string PrintArray(int[] arr)
        {
            return String.Join(" | ", arr);
        }
    }
}
