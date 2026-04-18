namespace ConnectFour
{
    // Game board - handles grid state and win checks
    public class Board
    {
        public const int Rows = 6;
        public const int Columns = 7;
        public const char Empty = '.';

        private char[,] _grid;

        public Board()
        {
            _grid = new char[Rows, Columns];
            Reset();
        }

        public void Reset()
        {
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    _grid[r, c] = Empty;
                }
            }
        }

        public char GetCell(int row, int column)
        {
            return _grid[row, column];
        }

        public bool IsColumnFull(int column)
        {
            return _grid[0, column] != Empty;
        }

        public bool IsFull()
        {
            for (int c = 0; c < Columns; c++)
            {
                if (!IsColumnFull(c)) return false;
            }
            return true;
        }

        // Drop a disc in a column, returns true if placed
        public bool DropDisc(int column, char symbol)
        {
            if (column < 0 || column >= Columns) return false;
            if (IsColumnFull(column)) return false;

            for (int r = Rows - 1; r >= 0; r--)
            {
                if (_grid[r, column] == Empty)
                {
                    _grid[r, column] = symbol;
                    return true;
                }
            }
            return false;
        }

        // Check if the given symbol has 4 in a row anywhere
        public bool CheckWin(char symbol)
        {
            // Horizontal
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c <= Columns - 4; c++)
                {
                    if (_grid[r, c] == symbol && _grid[r, c + 1] == symbol &&
                        _grid[r, c + 2] == symbol && _grid[r, c + 3] == symbol)
                        return true;
                }
            }

            // Vertical
            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r <= Rows - 4; r++)
                {
                    if (_grid[r, c] == symbol && _grid[r + 1, c] == symbol &&
                        _grid[r + 2, c] == symbol && _grid[r + 3, c] == symbol)
                        return true;
                }
            }

            // Diagonal down-right
            for (int r = 0; r <= Rows - 4; r++)
            {
                for (int c = 0; c <= Columns - 4; c++)
                {
                    if (_grid[r, c] == symbol && _grid[r + 1, c + 1] == symbol &&
                        _grid[r + 2, c + 2] == symbol && _grid[r + 3, c + 3] == symbol)
                        return true;
                }
            }

            // Diagonal up-right
            for (int r = 3; r < Rows; r++)
            {
                for (int c = 0; c <= Columns - 4; c++)
                {
                    if (_grid[r, c] == symbol && _grid[r - 1, c + 1] == symbol &&
                        _grid[r - 2, c + 2] == symbol && _grid[r - 3, c + 3] == symbol)
                        return true;
                }
            }

            return false;
        }
    }
}