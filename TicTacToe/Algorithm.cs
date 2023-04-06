using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Algorithm
    {
        public bool CheckAllPossibleWinnerOutcomes(Square[] squares, string symbol)
        {
            if (
                CheckForWinnerVertical(squares, symbol) ||
                CheckForWinnerHorizontal(squares, symbol) ||
                CheckForWinnerDiagonal(squares, symbol))
            {
                return true;
            }
            return false;
        }

        private bool CheckForWinnerVertical(Square[] squares, string symbol)
        {
            var nextIndex = 1;

            for (var i = 0; i < squares.Length; i += 3)
            {
                if (squares[i].Symbol() != symbol)
                {
                    if (nextIndex == 3) return false;

                    i = -3 + nextIndex;
                    nextIndex++;
                }
            }
            return true;
        }

        private bool CheckForWinnerHorizontal(Square[] squares, string symbol)
        {
            var nextIndex = 3;
            var maxLength = 3;

            for (var i = 0; i < maxLength; i++)
            {
                if (squares[i].Symbol() != symbol)
                {
                    if (nextIndex == 9) return false;

                    maxLength += 3;
                    i = -1 + nextIndex;
                    nextIndex += 3;
                }
            }
            return true;
        }

        private bool CheckForWinnerDiagonal(Square[] squares, string symbol)
        {
            var nextIndex = 8;
            var maxLength = 2;
            var decrementNum = 2;

            for (var i = 6; i >= maxLength; i -= decrementNum)
            {
                if (squares[i].Symbol() != symbol)
                {
                    if (nextIndex > 8) return false;

                    maxLength = 0;
                    decrementNum = 4;
                    i = 4 + nextIndex;
                    nextIndex += 4;
                }
            }
            return true;
        }
    }
}
