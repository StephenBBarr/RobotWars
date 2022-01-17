using static RobotWars.Entities.Properties;

namespace RobotWars.Entities
{
    public class Position : IPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }
    }
}
