using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var snake = new Snake(new Coordinate(Console.WindowWidth / 2, Console.WindowHeight / 2), 5, '#');
            snake.Draw();

            while (true)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Q)
                {
                    break;
                }

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        snake.Move(Snake.Direction.Up);
                        break;
                    case ConsoleKey.DownArrow:
                        snake.Move(Snake.Direction.Down);
                        break;
                    case ConsoleKey.LeftArrow:
                        snake.Move(Snake.Direction.Left);
                        break;
                    case ConsoleKey.RightArrow:
                        snake.Move(Snake.Direction.Right);
                        break;
                }
            }

            Console.CursorVisible = true;
        }
    }
}
