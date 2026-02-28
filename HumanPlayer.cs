namespace ConnectFour
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, char symbol) : base(name, symbol)
        {
        }

        public override int ChooseColumn(Board board)
        {
            Console.Write($"{Name}, choose a column (1-7): ");
            int column = int.Parse(Console.ReadLine());
            return column;
        }
    }
}