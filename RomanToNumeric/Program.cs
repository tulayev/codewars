using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RomanToNumeric
{
    class Program
    {
        private static Dictionary<char, int> dict = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter stop to exit");
            string userInput = String.Empty;

            while (userInput.ToLower() != "stop") 
            {
                Console.Write("> ");
                userInput = Console.ReadLine();

                int result = Parse(userInput);

                if (result == 0)
                {
                    Console.WriteLine("Input string has invalid roman number");
                }
                else
                {
                    Console.WriteLine($"Roman Number: {userInput}{Environment.NewLine}Arabic Number: {result}");
                }
            }

            Console.ReadKey();
        }

        private static int Parse(string romanNumber)
        {
            if (Validate(romanNumber))
            {
                int number = 0;

                for (int i = 0; i < romanNumber.Length; i++)
                {
                    if (i + 1 < romanNumber.Length && IsSubtractive(romanNumber[i], romanNumber[i + 1]))
                    {
                        number -= dict[romanNumber[i]]; 
                    } 
                    else
                    {
                        number += dict[romanNumber[i]]; 
                    }
                }

                return number;
            }

            return 0;
        }

        private static bool IsSubtractive(char c1, char c2) => dict[c1] < dict[c2];

        private static bool Validate(string expression)
        {
            string regex = @"^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";
            Match match = Regex.Match(expression, regex, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                return true;
            }

            return false;
        }
    }
}
