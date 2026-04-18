namespace ConnectFour
{
    // Handles console output - separates UI from game logic
    public class GameView
    {
        public void ShowWelcome()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("     Welcome to Connect Four!    ");
            Console.WriteLine("=================================");
        }

        public void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Human vs Human");
            Console.WriteLine("2 - Human vs Computer");
            Console.WriteLine("3 - Exit");
            Console.Write("Choose an option: ");
        }

        public void ShowBoard(Board board)
        {
            Console.WriteLine();
            Console.WriteLine(" 1 2 3 4 5 6 7");
            for (int r = 0; r < Board.Rows; r++)
            {
                Console.Write("|");
                for (int c = 0; c < Board.Columns; c++)
                {
                    Console.Write(board.GetCell(r, c) + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------");
        }

        public void ShowTurn(Player player)
        {
            Console.WriteLine();
            Console.WriteLine(player.Name + "'s turn (" + player.Symbol + ")");
        }

        public void ShowWinner(Player player)
        {
            Console.WriteLine();
            Console.WriteLine("*** " + player.Name + " wins! ***");
        }

        public void ShowDraw()
        {
            Console.WriteLine();
            Console.WriteLine("*** It's a draw! ***");
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string AskForInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}