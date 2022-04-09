using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Int2IPv4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(UInt32ToIP(2154959208));

            //Console.WriteLine(orderWeight("103 123 4444 99 2000"));

            Console.ReadKey();
        }

        public static string UInt32ToIP(uint ip)
        {
            string binary = Convert.ToString(ip, 2);
            binary = binary.Length > 8 ? binary : binary.Insert(0, String.Concat(Enumerable.Repeat("0", 32 - binary.Length)));
            binary = Regex.Replace(binary, ".{8}", "$0.");
            binary = binary.Remove(binary.Length - 1);
            string[] arr = binary.Split('.').Select(s => Convert.ToUInt32(s, 2).ToString()).ToArray();

            return String.Join(".", arr);
        }
    }
}
