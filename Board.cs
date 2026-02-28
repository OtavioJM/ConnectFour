namespace ConnectFour
{
    public class Board
    {
        public const int Rows = 6;
        public const int Columns = 7;

        private char[,] _grid;

        public Board()
        {
            _grid = new char[Rows, Columns];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int r = 0; r < Rows; r++)
                for (int c = 0; c < Columns; c++)
                    _grid[r, c] = '.';
        }

        public void DisplayBoard()
        {
            Console.WriteLine("\n 1 2 3 4 5 6 7");
            Console.WriteLine("---------------");
            for (int r = 0; r < Rows; r++)
            {
                Console.Write("|");
                for (int c = 0; c < Columns; c++)
                    Console.Write(_grid[r, c] + "|");
                Console.WriteLine();
            }
            Console.WriteLine("---------------");
        }

        public bool DropDisc(int column, char symbol)
        {
            return false;
        }

        public bool CheckWin(char symbol)
        {
            return false;
        }

        public bool IsFull()
        {
            return false;
        }

        public void Reset()
        {
            InitializeBoard();
        }
    }
}