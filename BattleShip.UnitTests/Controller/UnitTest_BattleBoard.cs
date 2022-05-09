using BattleShip.Controller;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleShip.UnitTests.Controller
{
    [TestClass]
    public class UnitTest_BattleBoard : BaseUnitTest
    {
        [TestMethod]
        public void UnitTest_BattleBoard_Instance()
        {
            // Arrange
            var method = ActivatorUtilities.CreateInstance<BattleBoard>(ContainerService);

            // Assert
            Assert.IsNotNull(method);
            Assert.IsInstanceOfType(method, typeof(BattleBoard));
        }
    }
}
