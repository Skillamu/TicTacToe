﻿using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool IsPlayer1()
        {
            return _content == 1;
        }

        public void Mark(bool player1)
        {
            if (!IsEmpty()) return;

            _content = player1 ? 1 : 2;
            var symbol = player1 ? "x" : "o";
            Console.WriteLine(symbol);
        }
    }
}
