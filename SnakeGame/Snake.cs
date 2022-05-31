using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeGame
{
    public class Snake
    {
        public enum Direction { Up, Left, Right, Down }
        private List<SnakePart> _body;
        private SnakePart _head;
        private SnakePart _tail;
        private char _symbol;

        public Snake(Coordinate startingPosition, int length, char symbol)
        {
            _symbol = symbol;
            _body = new List<SnakePart>();

            for (int i = 0; i < length; i++)
            {
                _body.Add(new SnakePart(new Coordinate(startingPosition.X + i, startingPosition.Y), '#'));
            }

            _head = _body.Last();
            _tail = _body.First();
        }

        public void Draw() => _body.ForEach(x => x.Draw());

        public void Move(Direction direction)
        {
            SnakePart newHead = null;

            switch (direction)
            {
                case Direction.Up:
                    newHead = new SnakePart(new Coordinate(_head.Coordinate.X, _head.Coordinate.Y - 1), _symbol);
                    break;
                case Direction.Left:
                    newHead = new SnakePart(new Coordinate(_head.Coordinate.X - 1, _head.Coordinate.Y), _symbol);
                    break;
                case Direction.Right:
                    newHead = new SnakePart(new Coordinate(_head.Coordinate.X + 1, _head.Coordinate.Y), _symbol);
                    break;
                case Direction.Down:
                    newHead = new SnakePart(new Coordinate(_head.Coordinate.X, _head.Coordinate.Y + 1), _symbol);
                    break;
            }

            _body.Remove(_tail);
            for (int i = _body.Count - 1; i > 0; i--)
            {
                _body[i] = _body[i - 1];
            }
            _body[0] = newHead;

            Draw();
        }
    }
}
