namespace ConnectFour
{
    public class GameController
    {
        private Board _board;
        private Player _player1;
        private Player _player2;
        private Player _currentPlayer;

        public GameController()
        {
            _board = new Board();
        }

        public void SetupPlayers()
        {
            Console.Write("Enter Player 1 name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter Player 2 name: ");
            string name2 = Console.ReadLine();

            _player1 = new HumanPlayer(name1, 'X');
            _player2 = new HumanPlayer(name2, 'O');
            _currentPlayer = _player1;
        }

        public void StartGame()
        {
            Console.WriteLine("Game starting...");
            _board.DisplayBoard();
        }

        private void SwitchPlayer()
        {
            _currentPlayer = (_currentPlayer == _player1) ? _player2 : _player1;
        }
    }
}