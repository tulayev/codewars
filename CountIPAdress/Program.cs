using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountIPAdress
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IpsBetween("10.0.0.0", "10.0.0.50"));
            Console.WriteLine(IpsBetween("10.0.0.0", "10.0.1.0"));
            //Console.WriteLine(IpsBetween("0.0.0.0", "255.255.255.255"));

            Console.ReadKey();
        }

        public static long IpsBetween(string start, string end)
        {
            //second[i - 1] * 255 + second[i] 
            //10.0.0.0
            byte[] first = start.Split('.').Select(b => Byte.Parse(b)).ToArray();
            byte[] second = end.Split('.').Select(b => Byte.Parse(b)).ToArray();
            long res = 0;
            return GetSum(second) - GetSum(first);
        }
    }
}
