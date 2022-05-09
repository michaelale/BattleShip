using BattleShip.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleShip.UnitTests.Services
{
    [TestClass]
    public class UnitTest_BattleShipBoard : BaseUnitTest
    {
        [TestMethod]
        public void UnitTest_Instance()
        {
            // Arrange
            var service = ContainerService.GetService<IBattleShipBoard>();

            // Assert
            Assert.IsInstanceOfType(service, typeof(IBattleShipBoard));
        }
    }
}
