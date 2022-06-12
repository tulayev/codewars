using System;

namespace LCS
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Lcs(string[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("");
            }
            else
            {
                if (arr.Length == 1)
                {
                    Console.WriteLine(arr[0]);
                }
                else
                {
                    string str = arr[0];
                    string res = "";

                    for (int i = 0; i < str.Length; i++)
                    {
                        for (int j = i + 1; j <= str.Length; j++)
                        {
                            string temp = str.Substring(i, j - i);
                            int k = 1;
                            while (k < arr.Length)
                            {
                                if (!arr[k].Contains(temp))
                                    break;
                                k++;
                            }

                            if (k == arr.Length && res.Length < temp.Length)
                                res = temp;
                        }
                    }

                    Console.WriteLine(res);
                }
            }
        }
    }
}
