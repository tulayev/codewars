using System;

namespace StickGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(10);

            game.OnSticksCountChanged += SticksCountChangedHandler;

            game.Start();

            Console.ReadKey();
        }

        private static void SticksCountChangedHandler(int count)
        {
            Console.WriteLine($"Sticks remained {count}");
            Console.WriteLine();
        }
    }

    class Game
    {
        private PlayerTurns _turns;
        private int _sticksCount;
        private Random _rnd = new Random();
        private bool _gameOver = false;
        public event Action<int> OnSticksCountChanged;

        public Game(int count)
        {
            _sticksCount = count;
        }

        public void Start()
        {
            _turns = PlayerTurns.Player;

            while (!_gameOver)
            {
                switch (_turns)
                {
                    case PlayerTurns.Player:
                        Console.Write("Enter the quantity of sticks you want to take (You can take no more than 3 sticks at once) >> ");
                        int userQty = Int32.Parse(Console.ReadLine());
                        while (userQty > 3 || userQty > _sticksCount)
                        {
                            Console.Write("Enter the quantity of sticks you want to take (You can take no more than 3 sticks at once) >> ");
                            userQty = Int32.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"You took {userQty} stick(s)");
                        _sticksCount -= userQty;

                        if (WinCheck(_sticksCount)) 
                        {
                            Console.WriteLine("AI wins!");
                            _gameOver = true;
                        }

                        OnSticksCountChanged?.Invoke(_sticksCount);
                        _turns = PlayerTurns.AI;
                        break;

                    case PlayerTurns.AI:
                        int aiQty = _rnd.Next(1, 4);
                        while (aiQty > _sticksCount)
                        {
                            aiQty = _rnd.Next(1, 4);
                        }
                        Console.WriteLine($"AI took {aiQty} stick(s)");
                        _sticksCount -= aiQty;

                        if (WinCheck(_sticksCount))
                        {
                            Console.WriteLine("Player wins!");
                            _gameOver = true; 
                        }

                        OnSticksCountChanged?.Invoke(_sticksCount);
                        _turns = PlayerTurns.Player;
                        break;

                    default:
                        throw new Exception();
                }
            }
        }

        private bool WinCheck(int count) => count == 0 || count < 0;
    }

    enum PlayerTurns
    {
        Player,
        AI
    }
}
