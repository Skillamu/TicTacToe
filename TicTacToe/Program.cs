using System.Reflection;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            var gameConsole = new GameConsole();
            var game = new Game(board, gameConsole);

            game.Run();
        }
    }
}