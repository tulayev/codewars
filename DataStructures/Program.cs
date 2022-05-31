using DataStructures.Array;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = NumberArrayGenerator.GetArray(5, -10, 10);
            Console.WriteLine("Before:\n" + NumberArrayGenerator.PrintArray(arr));
            QuickSort.Sort(arr);
            Console.WriteLine("After:\n" + NumberArrayGenerator.PrintArray(arr));

            Console.ReadKey();
        }
    }
}
