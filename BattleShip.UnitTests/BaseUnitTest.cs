using BattleShip.Controller;
using BattleShip.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleShip.UnitTests
{
    [TestClass]
    public abstract class BaseUnitTest
    {
        public ServiceProvider ContainerService;

        [TestInitialize]
        public void Setup()
        {
            var services = new ServiceCollection();
            var test_config = new ConfigurationBuilder().Build();

            services.AddSingleton<IConfiguration>(test_config);

            services.AddTransient<IBattleBoard, BattleBoard>();
            services.AddTransient<IBattleShipBoard, BattleShipBoard>();
            services.AddTransient<IPlayer, Player>();

            services.AddLogging();
            ContainerService = services.BuildServiceProvider();
        }

        [TestCleanup]
        public void Cleanup()
        {
            
        }
    }
}