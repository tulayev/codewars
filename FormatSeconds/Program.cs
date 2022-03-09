using System;

namespace FormatSeconds
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(FormatNumber(1344223));

            Console.ReadKey();
        }

        static string FormatNumber(int seconds)
        {
            string res = String.Empty;
            int secondsPerYear = 60 * 60 * 24 * 365;
            int secondsPerDay = 60 * 60 * 24;
            int secondsPerHours = 60 * 60;
            int secondsPerMinutes = 60;

            if (seconds == 0)
            {
                return "now";
            }

            if (seconds >= secondsPerYear)
            {
                int year = seconds / secondsPerYear;

                string str = year == 1 ?
                                $"{ year } year, " : $"{ year } years, ";

                seconds = year == 1 ?
                                seconds - secondsPerYear : seconds - year * secondsPerYear;

                res += str;
            }

            if (seconds >= secondsPerDay && seconds < secondsPerDay * 365)
            {
                int day = seconds / secondsPerDay;
                
                string str = day == 1 ?
                                $"{ day } day, " : $"{ day } days, ";

                seconds = day == 1 ? 
                                seconds - secondsPerDay : seconds - day * secondsPerDay;
                
                res += str;
            }

            if (seconds >= secondsPerHours && seconds < secondsPerDay)
            {
                int hour = seconds / secondsPerHours;

                string str = hour == 1 ?
                                $"{ hour } hour, " : $"{ hour } hours, ";

                seconds = hour == 1 ? 
                                seconds - secondsPerHours : seconds - hour * secondsPerHours;
                
                res += str;
            }

            if (seconds >= secondsPerMinutes && seconds < secondsPerHours)
            {
                int minute = seconds / secondsPerMinutes;
                
                string str = minute == 1 ?
                                $"{ minute } minute, " : $"{ minute } minutes, ";

                seconds = minute == 1 ? 
                                seconds - secondsPerMinutes : seconds - minute * secondsPerMinutes;
                
                res += str;
            }

            if (seconds >= 1 && seconds < secondsPerMinutes)
            {
                int second = seconds % secondsPerMinutes;

                string str = second == 1 ?
                                $"{ second } second" : $"{ second } seconds";

                res += str;
            }

            int indexOfNumber = GetNumberIndex(res.ToCharArray(), res);
            
            return GetModifiedRes(res, indexOfNumber);
        }

        static string GetModifiedRes(string res, int indexOfNumber)
        {
            res = indexOfNumber != -1 ? res.Insert(indexOfNumber, "and ") : res;
            return RemoveRedundantComma(res);
        }

        static string RemoveRedundantComma(string res)
        {
            if (res[res.Length - 2] == ',')
            {
                res = res.Remove(res.Length - 2, 2);
            }

            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] == ',' && res[i + 2] == 'a')
                {
                   res = res.Remove(i, 1);
                }
            }
            return res;
        }

        static int GetNumberIndex(char[] charArray, string res)
        {
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                if (Int32.TryParse(charArray[i].ToString(), out int num))
                {
                    if (i > 1)
                    {
                        if (Int32.TryParse(charArray[i - 1].ToString(), out int num2))
                        {
                            return i - 1;
                        }
                        else
                        {
                            return i;
                        }
                    }
                }
            }

            return -1;
        }
    }
}
