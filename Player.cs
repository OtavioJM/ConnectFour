namespace ConnectFour
{
    // Base class for any player
    public abstract class Player
    {
        public string Name { get; set; }
        public char Symbol { get; set; }

        public Player(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        // Each player type decides how to pick a column
        public abstract int ChooseColumn(Board board);

        public override string ToString()
        {
            return Name + " (" + Symbol + ")";
        }
    }
}