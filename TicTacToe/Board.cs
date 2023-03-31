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

        public Board()
        {
            _squares = new Square[9];

            for (int i = 0; i < _squares.Length; i++)
            {
                _squares[i] = new Square();
            }
        }


    }
}
