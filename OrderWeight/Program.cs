using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OrderWeight("12 90 89 11 11 180 90"));

            Console.ReadKey();
        }

        static string OrderWeight(string strng)
        {
            string[] keys = strng.Split(' ');
            int[] values = strng.Split(' ').Select(c => c.Sum(n => n - '0')).ToArray();

            List<Weight> list = new List<Weight>();

            for (int i = 0; i < keys.Length; i++)
            {
                list.Add(new Weight
                {
                    Key = keys[i],
                    Value = values[i]
                });
            }

            list = list.OrderBy(w => w.Value).ToList();

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].Value == list[j].Value)
                    {
                        if (String.Compare(list[i].Key, list[j].Key) == 1)
                        {
                            Weight t = list[i];
                            list[i] = list[j];
                            list[j] = t;
                        }
                    }
                }
            }

            return String.Join(" ", list.Select(i => i.Key));
        }
    }

    struct Weight
    {
        public string Key { get; set; }
        public int Value { get; set; }
    }
}
