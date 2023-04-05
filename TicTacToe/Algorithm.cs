using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Algorithm
    {
        public bool CheckAllPossibleWinnerOutcomes(Square[] board, string symbol)
        {
            if (
                CheckForWinnerVertical(board, symbol) ||
                CheckForWinnerHorizontal(board, symbol) ||
                CheckForWinnerDiagonal(board, symbol))
            {
                return true;
            }
            return false;
        }

        private bool CheckForWinnerVertical(Square[] board, string symbol)
        {
            var nextIndex = 1;

            for (var i = 0; i < board.Length; i += 3)
            {
                if (board[i].Symbol() != symbol)
                {
                    if (nextIndex == 3) return false;

                    i = -3 + nextIndex;
                    nextIndex++;
                }
            }
            return true;
        }

        private bool CheckForWinnerHorizontal(Square[] board, string symbol)
        {
            var nextIndex = 3;
            var maxLength = 3;

            for (var i = 0; i < maxLength; i++)
            {
                if (board[i].Symbol() != symbol)
                {
                    if (nextIndex == 9) return false;

                    maxLength += 3;
                    i = -1 + nextIndex;
                    nextIndex += 3;
                }
            }
            return true;
        }

        private bool CheckForWinnerDiagonal(Square[] board, string symbol)
        {
            var nextIndex = 8;
            var maxLength = 2;
            var decrementNum = 2;

            for (var i = 6; i >= maxLength; i -= decrementNum)
            {
                if (board[i].Symbol() != symbol)
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
