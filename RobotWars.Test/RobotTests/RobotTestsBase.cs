using Moq;
using RobotWars.Entities;

namespace RobotWars.Test.RobotTests
{
    public class RobotTestsBase
    {
        protected Mock<IArena> arena;
        protected Robot robot;

        protected const int xScale = 5;
        protected const int yScale = 5;

        public RobotTestsBase()
        {
            arena = new Mock<IArena>();
            arena.SetupGet(x => x.Scale.X).Returns(xScale);
            arena.SetupGet(x => x.Scale.Y).Returns(yScale);

            robot = new Robot(arena.Object);
        }
    }
}
