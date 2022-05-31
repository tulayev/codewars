using System;

namespace DataStructures.Array
{
    class ArraysDemo
    {
        public void ShowMonths()
        {
            string[] months = new string[12];

            for (int i = 1; i <= months.Length; i++)
            {
                var firstDay = new DateTime(DateTime.Now.Year, i, 1);
                months[i - 1] = firstDay.ToString("MMMM");
            }

            foreach (string month in months)
            {
                Console.WriteLine(month);
            }
        }

        public void ShowMultiplicationTable()
        {
            int[,] table = new int[10, 10];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write("{0,4}", table[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
