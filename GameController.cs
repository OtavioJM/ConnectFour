namespace ConnectFour
{
    // Controls the game flow
    public class GameController
    {
        private Board _board;
        private GameView _view;
        private Player _player1;
        private Player _player2;
        private Player _currentPlayer;

        public GameController()
        {
            _board = new Board();
            _view = new GameView();
        }

        public void Run()
        {
            _view.ShowWelcome();
            bool running = true;

            while (running)
            {
                _view.ShowMenu();
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    SetupHumanVsHuman();
                    PlayGame();
                }
                else if (choice == "2")
                {
                    SetupHumanVsComputer();
                    PlayGame();
                }
                else if (choice == "3")
                {
                    running = false;
                    _view.ShowMessage("Thanks for playing!");
                }
                else
                {
                    _view.ShowMessage("Invalid option.");
                }
            }
        }

        private void SetupHumanVsHuman()
        {
            string name1 = _view.AskForInput("Enter Player 1 name: ");
            string name2 = _view.AskForInput("Enter Player 2 name: ");

            _player1 = new HumanPlayer(name1, 'X');
            _player2 = new HumanPlayer(name2, 'O');
            _currentPlayer = _player1;
        }

        private void SetupHumanVsComputer()
        {
            string name1 = _view.AskForInput("Enter your name: ");

            _player1 = new HumanPlayer(name1, 'X');
            _player2 = new ComputerPlayer("Computer", 'O');
            _currentPlayer = _player1;
        }

        private void PlayGame()
        {
            _board.Reset();
            bool gameOver = false;

            while (!gameOver)
            {
                _view.ShowBoard(_board);
                _view.ShowTurn(_currentPlayer);

                int column = _currentPlayer.ChooseColumn(_board);
                _board.DropDisc(column, _currentPlayer.Symbol);

                if (_board.CheckWin(_currentPlayer.Symbol))
                {
                    _view.ShowBoard(_board);
                    _view.ShowWinner(_currentPlayer);
                    gameOver = true;
                }
                else if (_board.IsFull())
                {
                    _view.ShowBoard(_board);
                    _view.ShowDraw();
                    gameOver = true;
                }
                else
                {
                    SwitchPlayer();
                }
            }
        }

        private void SwitchPlayer()
        {
            if (_currentPlayer == _player1)
                _currentPlayer = _player2;
            else
                _currentPlayer = _player1;
        }
    }
}