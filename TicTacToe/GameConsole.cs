using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class GameConsole
    {
        public void Show(Board board)
        {
            Console.WriteLine(@$"
  a b c
 ┌─────┐
1│{board.Square(0)} {board.Square(1)} {board.Square(2)}│
2│{board.Square(3)} {board.Square(4)} {board.Square(5)}│
3│{board.Square(6)} {board.Square(7)} {board.Square(8)}│
 └─────┘
            ");
        }
    }
}
