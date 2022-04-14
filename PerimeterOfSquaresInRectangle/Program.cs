using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace PerimeterOfSquaresInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(perimeter(6372));

            Console.ReadKey();
        }

        public static BigInteger perimeter(BigInteger n)
        {
            var sequence = new List<BigInteger>();

            sequence.Add(1);
            sequence.Add(1);

            for (int i = 1; i < n; i++)
            {
                sequence.Add(sequence[i] + sequence[i - 1]);
            }

            BigInteger sum = 0;

            foreach (var num in sequence)
            {
                sum += num;
            }

            return sum * 4;
        }
    }
}
