using RobotWars.Entities;
using Xunit;

namespace RobotWars.Test.RobotTests
{
    public class RotateTests : RobotTestsBase
    {
        [Fact]
        public void Rotate_ClockwiseFromFacingNorth_FacingEast()
        {
            // Arrange
            robot.Position = new Position() { X = 0, Y = 0, Direction = Properties.Direction.North };

            // Act
            robot.Rotate(true);

            // Assert
            var expectedResult = Properties.Direction.East;
            Assert.Equal(expectedResult, robot.Position.Direction);
        }

        [Fact]
        public void Rotate_CounterClockwiseFromFacingNorth_FacingWest()
        {
            // Arrange
            robot.Position = new Position() { X = 0, Y = 0, Direction = Properties.Direction.North };

            // Act
            robot.Rotate(false);

            // Assert
            var expectedResult = Properties.Direction.West;
            Assert.Equal(expectedResult, robot.Position.Direction);
        }


        [Fact]
        public void Rotate_ClockwiseFromFacingEast_FacingSouth()
        {
            // Arrange
            robot.Position = new Position() { X = 0, Y = 0, Direction = Properties.Direction.East };

            // Act
            robot.Rotate(true);

            // Assert
            var expectedResult = Properties.Direction.South;
            Assert.Equal(expectedResult, robot.Position.Direction);
        }

        [Fact]
        public void Rotate_CounterClockwiseFromFacingEast_FacingNorth()
        {
            // Arrange
            robot.Position = new Position() { X = 0, Y = 0, Direction = Properties.Direction.East };

            // Act
            robot.Rotate(false);

            // Assert
            var expectedResult = Properties.Direction.North;
            Assert.Equal(expectedResult, robot.Position.Direction);
        }


        [Fact]
        public void Rotate_ClockwiseFromFacingSouth_FacingWest()
        {
            // Arrange
            robot.Position = new Position() { X = 0, Y = 0, Direction = Properties.Direction.South };

            // Act
            robot.Rotate(true);

            // Assert
            var expectedResult = Properties.Direction.West;
            Assert.Equal(expectedResult, robot.Position.Direction);
        }

        [Fact]
        public void Rotate_CounterClockwiseFromFacingSouth_FacingEast()
        {
            // Arrange
            robot.Position = new Position() { X = 0, Y = 0, Direction = Properties.Direction.South };

            // Act
            robot.Rotate(false);

            // Assert
            var expectedResult = Properties.Direction.East;
            Assert.Equal(expectedResult, robot.Position.Direction);
        }


        [Fact]
        public void Rotate_ClockwiseFromFacingWest_FacingNorth()
        {
            // Arrange
            robot.Position = new Position() { X = 0, Y = 0, Direction = Properties.Direction.West };

            // Act
            robot.Rotate(true);

            // Assert
            var expectedResult = Properties.Direction.North;
            Assert.Equal(expectedResult, robot.Position.Direction);
        }

        [Fact]
        public void Rotate_CounterClockwiseFromFacingWest_FacingSouth()
        {
            // Arrange
            robot.Position = new Position() { X = 0, Y = 0, Direction = Properties.Direction.West };

            // Act
            robot.Rotate(false);

            // Assert
            var expectedResult = Properties.Direction.South;
            Assert.Equal(expectedResult, robot.Position.Direction);
        }
    }
}
