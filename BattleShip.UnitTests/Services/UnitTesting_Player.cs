using BattleShip.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UnitTests.Services
{
    [TestClass]
    public class UnitTesting_Player : BaseUnitTest
    {
        [TestMethod]
        public void UnitTest_Instance()
        {
            // Arrange
            var service = ContainerService.GetService<IPlayer>();

            // Assert
            Assert.IsInstanceOfType(service, typeof(IPlayer));
        }

        [TestMethod]
        public void UnitTest_GetGrid()
        {
            // Arrange
            var service = ContainerService.GetService<IPlayer>();

            // Act
            var _player = service.GetGrid();

            // Assert
            Assert.IsNotNull(_player);
            Assert.IsInstanceOfType(service, typeof(IPlayer));
        }
    }
}
