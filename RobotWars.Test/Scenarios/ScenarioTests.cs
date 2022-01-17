using Xunit;

namespace RobotWars.Test.Scenarios
{
    public class ScenarioTests : ScenarioBase
    {
        [Fact]
        public void Scenario1()
        {
            // Arrange
            robot.Position = new Entities.Position() { X = 0, Y = 2, Direction = Entities.Properties.Direction.East };

            // Act
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('L');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('R');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('R');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('R');
            inputHandler.HandleInput('R');

            // Assert
            var expectedResult = new Entities.Position() { X = 4, Y = 1, Direction = Entities.Properties.Direction.North };
            Assert.Equal(expectedResult.X, robot.Position.X);
            Assert.Equal(expectedResult.Y, robot.Position.Y);
            Assert.Equal(expectedResult.Direction, robot.Position.Direction);
            Assert.Equal(0, robot.Penalties);
        }

        [Fact]
        public void Scenario2()
        {
            // Arrange
            robot.Position = new Entities.Position() { X = 4, Y = 4, Direction = Entities.Properties.Direction.South };

            // Act
            inputHandler.HandleInput('L');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('L');
            inputHandler.HandleInput('L');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('L');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('R');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');

            // Assert
            var expectedResult = new Entities.Position() { X = 0, Y = 1, Direction = Entities.Properties.Direction.West };
            Assert.Equal(expectedResult.X, robot.Position.X);
            Assert.Equal(expectedResult.Y, robot.Position.Y);
            Assert.Equal(expectedResult.Direction, robot.Position.Direction);
            Assert.Equal(1, robot.Penalties);
        }

        [Fact]
        public void Scenario3()
        {
            // Arrange
            robot.Position = new Entities.Position() { X = 2, Y = 2, Direction = Entities.Properties.Direction.West };

            // Act
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('L');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('L');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('L');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('R');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('R');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('R');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('R');
            inputHandler.HandleInput('M');

            // Assert
            var expectedResult = new Entities.Position() { X = 2, Y = 2, Direction = Entities.Properties.Direction.North };
            Assert.Equal(expectedResult.X, robot.Position.X);
            Assert.Equal(expectedResult.Y, robot.Position.Y);
            Assert.Equal(expectedResult.Direction, robot.Position.Direction);
            Assert.Equal(0, robot.Penalties);
        }

        [Fact]
        public void Scenario4()
        {
            // Arrange
            robot.Position = new Entities.Position() { X = 1, Y = 3, Direction = Entities.Properties.Direction.North };

            // Act
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('L');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('L');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');
            inputHandler.HandleInput('M');

            // Assert
            var expectedResult = new Entities.Position() { X = 0, Y = 0, Direction = Entities.Properties.Direction.South };
            Assert.Equal(expectedResult.X, robot.Position.X);
            Assert.Equal(expectedResult.Y, robot.Position.Y);
            Assert.Equal(expectedResult.Direction, robot.Position.Direction);
            Assert.Equal(3, robot.Penalties);
        }
    }
}
