using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Square
    {
        private int _content; // 0 = empty, 1 = player1, 2 = player2

        public bool IsEmpty()
        {
            return _content == 0;
        }

        private bool IsPlayer1()
        {
            return _content == 1;
        }

        public void Mark(bool player)
        {
            if (IsEmpty()) _content = player ? 1 : 2;
        }

        public string Symbol()
        {
            return IsEmpty() ? " " : 
                   IsPlayer1() ? "x" : "o";
        }
    }

}
