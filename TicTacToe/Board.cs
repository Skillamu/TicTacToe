using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Board
    {
        private Square[] _squares;
        private Random _random;
        private Algorithm _algorithm;

        public Board()
        {
            _squares = new Square[9];
            for (int i = 0; i < _squares.Length; i++)
            {
                _squares[i] = new Square();
            }

            _random = new Random();
            _algorithm = new Algorithm();
        }

        public string Square(int index)
        {
            return _squares[index].Symbol();
        }

        public void MarkSquare(string position)
        {
            char[] columns = {'a', 'b', 'c'};
            char[] rows = { '1', '2', '3' };

            var columnIndex = Array.IndexOf(columns, position[0]);
            var rowIndex = Array.IndexOf(rows, position[1]);
            var index = columnIndex + (rowIndex * 3);
            _squares[index].Mark(true);
        }

        public void MarkRandomSquare(bool player)
        {
            var randomIndex = _random.Next(0, 9);
            while (!_squares[randomIndex].IsEmpty())
            {
                randomIndex = _random.Next(0, 9);
            }
            _squares[randomIndex].Mark(player);
        }

        public bool CheckForWinner(string symbol)
        {
            return _algorithm.CheckAllPossibleWinnerOutcomes(_squares, symbol);
        }

        public bool CheckForTie()
        {
            var occupiedSquares = 0;

            foreach (var square in _squares)
            {
                if (!square.IsEmpty()) occupiedSquares++;
            }
            return occupiedSquares == 9 ? true : false;
        }
    }
}
