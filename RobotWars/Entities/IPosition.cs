using static RobotWars.Entities.Properties;

namespace RobotWars.Entities
{
    public interface IPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }
    }
}
