using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        private Board _board;
        private GameConsole _gameConsole;
        private string _outcome;

        public Game(Board board, GameConsole gameConsole)
        {
            _board = board;
            _gameConsole = gameConsole;
            _outcome = "";
        }

        public bool WinOrTie()
        {
            _outcome = _board.CheckForWinner("x") ? "Player1 vant!" :
                       _board.CheckForWinner("o") ? "Player2 vant!" :
                       _board.CheckForTie() ? "Det ble uavgjort..." : "";

            return _outcome != "" ? true : false;
        }

        public void Run()
        {
            while (true)
            {
                _gameConsole.Show(_board);
                Console.WriteLine("Skriv inn hvor du vil sette kryss, f.eks \"a2\"");
                var position = Console.ReadLine();
                _board.MarkSquare(position);
                _gameConsole.Show(_board);
                if (WinOrTie()) break;
                Console.WriteLine("Motstanderen velger rute...");
                Thread.Sleep(3000);
                _board.MarkRandomSquare(false);
                if (WinOrTie()) break;
            }

            _gameConsole.Show(_board);
            Console.WriteLine(_outcome);
            Console.ReadKey(true);
        }
    }
}