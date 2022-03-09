using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Please enter array's length: ");
            int len = Int32.Parse(Console.ReadLine());
            Task t = new Task(len);
            t.CreateArr();*/

            List<int> list = new List<int>(){ 1, 2, 1, 3, 1, 2 };
            for (int i = 0; i < list.Count; i++)
            {
                int sum = list.ElementAt(i);
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list.ElementAt(i) == list.ElementAt(j))
                    {
                        sum += list.ElementAt(i);
                    }
                }
                list.Add(sum);
            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
		}

        static string RemoveVowels(string str)
		{
			char[] vowels = { 'a', 'e', 'o', 'i', 'u' };
            str = str.ToLower();


			foreach(char s in str)
            {
                foreach (char v in vowels)
                {
                    if (s == v)
                    {
                        str = str.Remove(str.IndexOf(v), 1);
                    }
                }
            }

			return str;
		}
	}
}
