using System;
using System.Collections.Generic;
using System.Linq;

namespace MenFromBoys
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in MenFromBoys(new int[] { -17, -45, -15, -33, -85, -56, -86, -30 }))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static int[] MenFromBoys(int[] a)
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            foreach (int i in a)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                } 
                else
                {
                    odds.Add(i);
                }
            }

            evens = evens.OrderByDescending(x => Math.Abs(x)).ToList();
            odds = odds.OrderByDescending(x => Math.Abs(x)).ToList();

            int[] arr = new int[a.Length];

            for (int i = 0; i < evens.Count; i++)
            {
                arr[i] = evens[i];
            }

            for (int i = 0; i < odds.Count; i++)
            {
                arr[i + evens.Count] = odds[i];
            }

            return arr;
        }
    }
}
