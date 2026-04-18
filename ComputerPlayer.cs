namespace ConnectFour
{
    // Simple computer player - picks a random valid column
    public class ComputerPlayer : Player
    {
        private Random _random;

        public ComputerPlayer(string name, char symbol) : base(name, symbol)
        {
            _random = new Random();
        }

        public override int ChooseColumn(Board board)
        {
            int column;
            do
            {
                column = _random.Next(0, 7);
            } while (board.IsColumnFull(column));

            Console.WriteLine(Name + " (" + Symbol + ") chose column " + (column + 1) + ".");
            return column;
        }
    }
}