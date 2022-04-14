using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDenominator
{
    class Program
    {
        static void Main(string[] args)
        {
            long[,] lst = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };
            Console.WriteLine(convertFrac(lst));

            Console.ReadKey();
        }

        public static string convertFrac(long[,] lst)
        {
            var list = new List<long>();

            int rows = lst.GetUpperBound(0) + 1;    
            int columns = lst.Length / rows;        


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    list.Add(lst[i, j]);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            return "";
        }
    }
}
