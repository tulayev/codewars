using System;

namespace CourseTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Task #1
            var c1 = new Complex(1, 3);
            var c2 = new Complex(4, 1);

            var c3 = c1.Add(c2);
            var c4 = c1.Subtract(c2);

            c3.Print();
            c4.Print();

             * Task #2
            var bs = new BinarySearch();

            Console.WriteLine(bs.Search(32));
            
             * Task #3
            var game = new TicTacToe();
            game.Start();
            */

            Console.ReadKey();
        }
    }

    class Complex
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Complex(double x, double yi)
        {
            X = x;
            Y = yi;
        }

        public Complex Add(Complex number) => new Complex(X + number.X, Y + number.Y);
        public Complex Subtract(Complex number) => new Complex(X - number.X, Y - number.Y);

        public void Print()
        {
            Console.WriteLine($"{X} + {Y}i");
        }
    }

    class BinarySearch 
    {
        public int Search(int num)
        {
            int min = 0;
            int max = 100;
            int step = 0;

            while  (min <= max)
            {
                int mid = (min + max) / 2;
                step++;
                Console.WriteLine($"Step #{step}\nMid:{mid}");

                if (num == mid)
                {
                    return mid;
                }
                else if (num < mid)
                {
                    max = mid - 1;
                } 
                else
                {
                    if (num > mid)
                    {
                        min = mid + 1;
                    }
                }
            }

            return 0;
        }
    }

    class TicTacToe
    {
        private char[] _arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        enum PlayerTurns 
        {
            FirstPlayer,
            SecondPlayer
        }

        private PlayerTurns _playerTurns;

        public TicTacToe()
        {
            DrawBoard();
            _playerTurns = PlayerTurns.FirstPlayer;
        }

        private void DrawBoard()
        {
            string board = String.Concat(
                @"     |     |      ", "\n",
                $"  {_arr[7]}  |  {_arr[8]}  |  {_arr[9]}\n",
                "_____|_____|_____ \n",
                "     |     |      \n",
                $"  {_arr[4]}  |  {_arr[5]}  |  {_arr[6]}\n",
                "_____|_____|_____ \n",
                "     |     |      \n",
                $"  {_arr[1]}  |  {_arr[2]}  |  {_arr[3]}\n",
                "     |     |      \n"
            );

            Console.WriteLine(board);
        }

        public void Start()
        {
            while (!GameOver())
            {
                var keyInfo = Console.ReadKey();
                Console.Clear();

                if (keyInfo.KeyChar <= '0' || keyInfo.KeyChar > '9')
                {
                    Console.WriteLine("Incorrect input");
                    DrawBoard();
                    continue;
                }

                switch (_playerTurns)
                {
                    case PlayerTurns.FirstPlayer:
                        _arr[Int32.Parse(keyInfo.KeyChar.ToString())] = 'X';
                        _playerTurns = PlayerTurns.SecondPlayer;
                        break;
                    case PlayerTurns.SecondPlayer:
                        _arr[Int32.Parse(keyInfo.KeyChar.ToString())] = 'O';
                        _playerTurns = PlayerTurns.FirstPlayer;
                        break;
                }

                DrawBoard();
            }
        }

        private bool GameOver()
        {
            if ((_arr[1] == 'X' && _arr[2] == 'X' && _arr[3] == 'X') || // bottom
                (_arr[1] == 'X' && _arr[4] == 'X' && _arr[7] == 'X') || // left
                (_arr[1] == 'X' && _arr[5] == 'X' && _arr[9] == 'X') || // diagonal
                (_arr[3] == 'X' && _arr[5] == 'X' && _arr[7] == 'X') || // diagonal
                (_arr[7] == 'X' && _arr[8] == 'X' && _arr[9] == 'X') || // top
                (_arr[4] == 'X' && _arr[5] == 'X' && _arr[6] == 'X') || // middle-horizontal
                (_arr[2] == 'X' && _arr[5] == 'X' && _arr[8] == 'X') || // middle-vertical
                (_arr[3] == 'X' && _arr[6] == 'X' && _arr[9] == 'X'))   // right
            {
                Console.WriteLine("First player wins!");
                return true;
            }
            else
            {
                if ((_arr[1] == 'O' && _arr[2] == 'O' && _arr[3] == 'O') || // bottom
                    (_arr[1] == 'O' && _arr[4] == 'O' && _arr[7] == 'O') || // left
                    (_arr[1] == 'O' && _arr[5] == 'O' && _arr[9] == 'O') || // diagonal
                    (_arr[3] == 'O' && _arr[5] == 'O' && _arr[7] == 'O') || // diagonal
                    (_arr[7] == 'O' && _arr[8] == 'O' && _arr[9] == 'O') || // top
                    (_arr[4] == 'O' && _arr[5] == 'O' && _arr[6] == 'O') || // middle-horizontal
                    (_arr[2] == 'O' && _arr[5] == 'O' && _arr[8] == 'O') || // middle-vertical
                    (_arr[3] == 'O' && _arr[6] == 'O' && _arr[9] == 'O'))   // right
                {
                    Console.WriteLine("Second player wins!");
                    return true;
                }
            }

            return false;
        }
    }
}
