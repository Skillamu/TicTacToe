namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            var gameConsole = new GameConsole();
            while (true)
            {
                gameConsole.Show(board);
                Console.WriteLine("Skriv inn hvor du vil sette kryss, f.eks \"a2\"");
                var position = Console.ReadLine();
                board.MarkSquare(position);
                gameConsole.Show(board);
                Thread.Sleep(2000);
                board.MarkRandomSquare(false);
            }
        }
    }
}

// test commit again