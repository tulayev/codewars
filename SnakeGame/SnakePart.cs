using System;

namespace SnakeGame
{
    public class SnakePart
    {
        private char _symbol;
        public Coordinate Coordinate { get; set; }

        public SnakePart(Coordinate coordinate, char symbol)
        {
            Coordinate = coordinate;
            _symbol = symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(Coordinate.X, Coordinate.Y);
            Console.Write(_symbol);
        }

        public void Clear()
        {
            Console.SetCursorPosition(Coordinate.X, Coordinate.Y);
            Console.Write(' ');
        }
    }
}
