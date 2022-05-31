using System;
using System.Collections.Generic;

namespace SnakeGame
{
    public static class ListExtensions
    {
        public static void ForEach<T>(this List<T> list, Action<T> action)
        {
            foreach (T item in list)
            {
                action(item);
            }
        }
    }
}
