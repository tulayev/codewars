using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }

        public static bool ValidParentheses(string input)
        {
            var parentheses = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '(')
                {
                    parentheses.Push(c); 
                } 
                else
                {
                    if (c == ')')
                    {
                        if (parentheses.Count <= 0)
                        {
                            return false;
                        }

                        char open = parentheses.Pop(); 

                        if (open != '(' && c == ')')
                        {
                            return false;
                        }
                    }
                }
            }

            if (parentheses.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
