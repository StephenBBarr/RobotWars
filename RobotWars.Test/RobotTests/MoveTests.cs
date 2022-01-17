using RobotWars.Entities;
using Xunit;

namespace RobotWars.Test.RobotTests
{
    public class MoveTests : RobotTestsBase
    {
        [Fact]
        public void Move_FarLeftBottomDirectionNorth_YPositionIncrementByOnePenaltyNoChange()
        {
            // Arrange
            robot.Position = new Position() { X = 0, Y = 0, Direction = Properties.Direction.North };

            // Act
            robot.Move();

            // Assert
            var expectedResult = new Position() { X = 0, Y = 1, Direction = Properties.Direction.North };
            Assert.Equal(expectedResult.X, robot.Position.X);
            Assert.Equal(expectedResult.Y, robot.Position.Y);
            Assert.Equal(expectedResult.Direction, robot.Position.Direction);
            Assert.Equal(0, robot.Penalties);
        }

        [Fact]
        public void Move_FarLeftTopDirectionNorth_YPositionNoChangePenaltyIncrementByOne()
        {
            // Arrange
            robot.Position = new Position() { X = 0, Y = yScale - 1, Direction = Properties.Direction.North };

            // Act
            robot.Move();

            // Assert
            var expectedResult = new Position() { X = 0, Y = yScale - 1, Direction = Properties.Direction.North };
            Assert.Equal(expectedResult.X, robot.Position.X);
            Assert.Equal(expectedResult.Y, robot.Position.Y);
            Assert.Equal(expectedResult.Direction, robot.Position.Direction);
            Assert.Equal(1, robot.Penalties);
        }

        [Fact]
        public void Move_FarLeftBottomDirectionEast_XPositionIncrementByOnePenaltyNoChange()
        {
            // Arrange
            robot.Position = new Position() { X = 0, Y = 0, Direction = Properties.Direction.East };

            // Act
            robot.Move();

            // Assert
            var expectedResult = new Position() { X = 1, Y = 0, Direction = Properties.Direction.East };
            Assert.Equal(expectedResult.X, robot.Position.X);
            Assert.Equal(expectedResult.Y, robot.Position.Y);
            Assert.Equal(expectedResult.Direction, robot.Position.Direction);
            Assert.Equal(0, robot.Penalties);
        }

        [Fact]
        public void Move_FarRightBottomDirectionEast_XPositionNoChangePenaltyIncrementByOne()
        {
            // Arrange
            robot.Position = new Position() { X = xScale - 1, Y = 0, Direction = Properties.Direction.East };

            // Act
            robot.Move();

            // Assert
            var expectedResult = new Position() { X = xScale - 1, Y = 0, Direction = Properties.Direction.East };
            Assert.Equal(expectedResult.X, robot.Position.X);
            Assert.Equal(expectedResult.Y, robot.Position.Y);
            Assert.Equal(expectedResult.Direction, robot.Position.Direction);
            Assert.Equal(1, robot.Penalties);
        }

        [Fact]
        public void Move_FarRightTopDirectionSouth_YPositionDecrementByOnePenaltyNoChange()
        {
            // Arrange
            robot.Position = new Position() { X = xScale - 1, Y = yScale - 1, Direction = Properties.Direction.South };

            // Act
            robot.Move();

            // Assert
            var expectedResult = new Position() { X = xScale - 1, Y = yScale - 2, Direction = Properties.Direction.South };
            Assert.Equal(expectedResult.X, robot.Position.X);
            Assert.Equal(expectedResult.Y, robot.Position.Y);
            Assert.Equal(expectedResult.Direction, robot.Position.Direction);
            Assert.Equal(0, robot.Penalties);
        }

        [Fact]
        public void Move_FarRightBottomDirectionSouth_YPositionNoChangePenaltyIncrementByOne()
        {
            // Arrange
            robot.Position = new Position() { X = xScale - 1, Y = 0, Direction = Properties.Direction.South };

            // Act
            robot.Move();

            // Assert
            var expectedResult = new Position() { X = xScale - 1, Y = 0, Direction = Properties.Direction.South };
            Assert.Equal(expectedResult.X, robot.Position.X);
            Assert.Equal(expectedResult.Y, robot.Position.Y);
            Assert.Equal(expectedResult.Direction, robot.Position.Direction);
            Assert.Equal(1, robot.Penalties);
        }

        [Fact]
        public void Move_FarRightTopDirectionWest_XPositionDecrementByOnePenaltyNoChange()
        {
            // Arrange
            robot.Position = new Position() { X = xScale - 1, Y = yScale - 1, Direction = Properties.Direction.West };

            // Act
            robot.Move();

            // Assert
            var expectedResult = new Position() { X = xScale - 2, Y = yScale - 1, Direction = Properties.Direction.West };
            Assert.Equal(expectedResult.X, robot.Position.X);
            Assert.Equal(expectedResult.Y, robot.Position.Y);
            Assert.Equal(expectedResult.Direction, robot.Position.Direction);
            Assert.Equal(0, robot.Penalties);
        }

        [Fact]
        public void Move_FarLeftTopDirectionWest_XPositionDecrementByOnePenaltyNoChange()
        {
            // Arrange
            robot.Position = new Position() { X = 0, Y = yScale - 1, Direction = Properties.Direction.West };

            // Act
            robot.Move();

            // Assert
            var expectedResult = new Position() { X = 0, Y = yScale - 1, Direction = Properties.Direction.West };
            Assert.Equal(expectedResult.X, robot.Position.X);
            Assert.Equal(expectedResult.Y, robot.Position.Y);
            Assert.Equal(expectedResult.Direction, robot.Position.Direction);
            Assert.Equal(1, robot.Penalties);
        }
    }
}
