using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Task
    {
        private int len;
        private int[] arr;

        public Task(int length)
        {
            len = length;
        }

        public void CreateArr()
        {
            Random r = new Random();
            arr = new int[len];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 2);
            }

            Console.Write("Your array: ");
            PrintArr(arr);

            arr = CountOne(arr);

            Console.Write("Result: ");
            PrintArr(arr);
        }

        public void PrintArr(int[] arr)
        {
            string s = "";
            foreach (int item in arr)
            {
                s += item + ", ";
            }
            s = s.Remove(s.Length - 2, 2);
            Console.WriteLine(s);
        }

        public int[] CountOne(int[] arr)
        {
            int sum = 0;
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    sum += arr[i];
                    if (i == arr.Length - 1)
                    {
                        if (sum != 0)
                            list.Add(sum);
                        sum = 0;
                    }
                }
                else
                {
                    if (sum != 0)
                        list.Add(sum);
                    sum = 0;
                }
            }

            return list.ToArray();
        }

    }
}
