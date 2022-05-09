using BattleShip.Controller;
using BattleShip.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BattleShip
{
    class Program
    {
        private static IServiceProvider serviceProvider;
        private static IConfigurationRoot configurationRoot;
        private static IConfigurationBuilder configurationBuilder;

        static void Main(string[] args) => Run().GetAwaiter().GetResult();

        public static async Task Run()
        {
            try
            {
                configurationBuilder = new ConfigurationBuilder()
                    .AddEnvironmentVariables();

                configurationRoot = configurationBuilder.Build();

                serviceProvider = new ServiceCollection()
                    // add this to enable IOptions
                    .AddOptions()

                    // Set your configuration to be singleton
                    .AddSingleton<IConfiguration>(configurationRoot)

                    // Battleship board service should be the last service in the instantion. This is to ensure that all of its dependencies are already intantiated.
                    .AddSingleton<IBattleBoard, BattleBoard>()
                    .AddSingleton<IBattleShipBoard, BattleShipBoard>()
                    .AddSingleton<IPlayer, Player>()

                    .AddHttpClient()

                    // Add this to show logs on console
                    .AddLogging(configure => configure.AddConsole())
                    .BuildServiceProvider();

                // Start the BattleShip 
                await serviceProvider.GetService<IBattleBoard>().StartAsyc(new CancellationToken());
            }
            catch
            {
                throw;
            }
        }
    }
}