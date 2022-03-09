using System;

namespace Algorithms 
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10, 10);
            }
            Console.WriteLine("before sort");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nafter sort");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }

        static void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pIndex = Partition(arr, start, end);
                QuickSort(arr, start, pIndex - 1);
                QuickSort(arr, pIndex + 1, end);
            }
        }

        static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int pIndex = start;
            for (int i = start; i < end; i++)
            {
                if (pivot >= arr[i])
                {
                    Swap(ref arr[i], ref arr[pIndex]);
                    pIndex++;
                }
            }
            Swap(ref arr[pIndex], ref arr[end]);
            return pIndex;
        }

        static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}