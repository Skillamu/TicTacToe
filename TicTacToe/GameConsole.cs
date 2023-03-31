using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class GameConsole
    {
        public void Show()
        {
            Console.WriteLine(@"
  a b c
 ┌─────┐
1│o    │
2│    o│
3│× ×  │
 └─────┘
            ");
        }
    }
}
