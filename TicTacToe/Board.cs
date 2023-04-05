using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Board
    {
        private Square[] _board;
        private Random _random;
        private Algorithm _algorithm;

        public Board()
        {
            _board = new Square[9];
            for (int i = 0; i < _board.Length; i++)
            {
                _board[i] = new Square();
            }

            _random = new Random();
            _algorithm = new Algorithm();
        }

        public string Square(int index)
        {
            return _board[index].Symbol();
        }

        public void MarkSquare(string position)
        {
            char[] columns = {'a', 'b', 'c'};
            char[] rows = { '1', '2', '3' };

            var columnIndex = Array.IndexOf(columns, position[0]);
            var rowIndex = Array.IndexOf(rows, position[1]);
            var index = columnIndex + (rowIndex * 3);
            _board[index].Mark(true);
        }

        public void MarkRandomSquare(bool player)
        {
            var randomIndex = _random.Next(0, 9);
            _board[randomIndex].Mark(player);
        }

        public bool CheckForThreeInARow(string symbol)
        {
            return _algorithm.CheckAllPossibleWinnerOutcomes(_board, symbol);
        }
    }
}
