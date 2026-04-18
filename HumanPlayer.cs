namespace ConnectFour
{
    // Human player - picks column from console input
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, char symbol) : base(name, symbol)
        {
        }

        public override int ChooseColumn(Board board)
        {
            while (true)
            {
                Console.Write(Name + " (" + Symbol + "), choose a column (1-7): ");
                string input = Console.ReadLine();

                int column;
                if (!int.TryParse(input, out column))
                {
                    Console.WriteLine("Please type a number.");
                    continue;
                }

                if (column < 1 || column > 7)
                {
                    Console.WriteLine("Column must be between 1 and 7.");
                    continue;
                }

                if (board.IsColumnFull(column - 1))
                {
                    Console.WriteLine("That column is full. Try another one.");
                    continue;
                }

                return column - 1;
            }
        }
    }
}