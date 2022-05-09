using BattleShip.Services;

namespace BattleShip.Controller
{
    public class BattleBoard : IBattleBoard
    {
        private readonly IBattleShipBoard _battleshipboard;
        private readonly IPlayer _player;

        public BattleBoard(IBattleShipBoard battleshipboard, IPlayer player)
        {
            _battleshipboard = battleshipboard;
            _player = player;
        }

        public async Task StartAsyc(CancellationToken cancellationToken)
        {
            try
            {
                Console.Title = "BattleShip!";
                Console.WriteLine("Welcome to Battleship!\r\n\r\n");
                Console.WriteLine("Enter player 1 name:");
                string playername1 = Console.ReadLine();
                Console.WriteLine();

                _player.Randomize();
                while (_player.GetHitCount() < 10)
                {
                    _battleshipboard.DisplayBoard(_player.GetGrid());
                    _player.ShipCoordinates();
                }

                Console.WriteLine("Congratulations, " + playername1 + "! You Win!\r\n");
                Console.WriteLine("You missed: " + _player.GetMissCount() + " times\r\n");
                Console.WriteLine("Thanks for playing Battleship. Press enter to quit.");
                Console.ReadLine();
            }
            catch
            {
                throw;
            }
        }
    }
}
