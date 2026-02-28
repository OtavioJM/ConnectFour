namespace ConnectFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Connect Four!");
            
            GameController game = new GameController();
            game.SetupPlayers();
            game.StartGame();
        }
    }
}