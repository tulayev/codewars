using System;
using System.Collections.Generic;
using System.Linq;

namespace RGB2HEX
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Rgb(-12, 789, 20));

            Console.ReadKey();
        }

        public static string Rgb(int r, int g, int b)
        {
            var rgb = new List<int> { r, g, b };

            rgb = rgb.Select(x => x > 255 ? 255 : x)
                .Select(x => x < 0 ? 0 : x)
                .ToList();

            var hex = rgb.Select(
                    x => x.ToString("X").Length == 1 
                        ? x.ToString("X").Insert(0, "0") 
                        : x.ToString("X")
                );

            return String.Join("", hex);
        }
    }
}
