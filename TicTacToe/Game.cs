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
        private string _winner;
        private Board _board;
        private GameConsole _gameConsole;

        public Game(Board board, GameConsole gameConsole)
        {
            _winner = "";
            _board = board;
            _gameConsole = gameConsole;
        }

        public bool GotAWinner(string symbol)
        {
            var player = symbol == "x" ? "player1" : "player2";
            _winner = _board.CheckForThreeInARow(symbol) ? player : "";
            return _winner != "" ? true : false;
        }

        public void Run()
        {
            while (_winner == "")
            {
                _gameConsole.Show(_board);
                Console.WriteLine("Skriv inn hvor du vil sette kryss, f.eks \"a2\"");
                var position = Console.ReadLine();
                _board.MarkSquare(position);
                _gameConsole.Show(_board);
                if (GotAWinner("x")) break;
                Thread.Sleep(2000);
                _board.MarkRandomSquare(false);
                if (GotAWinner("o")) break;
            }

            _gameConsole.Show(_board);
            Console.WriteLine($"{_winner} has won!");
            Console.ReadKey(true);
        }
    }
}