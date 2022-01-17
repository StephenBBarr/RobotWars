using System;
using static RobotWars.Entities.Properties;

namespace RobotWars.Entities
{
    public class Robot : IRobot
    {
        private const int _turnDegrees = 90;

        private readonly IArena _arena;

        public Robot(IArena arena)
        {
            _arena = arena;
        }

        public Position Position { get; set; }

        public int Penalties { get; set; }

        public void Move()
        {
            switch (Position.Direction)
            {
                case Direction.North:
                    Position.Y++;
                    break;
                case Direction.East:
                    Position.X++;
                    break;
                case Direction.South:
                    Position.Y--;
                    break;
                case Direction.West:
                    Position.X--;
                    break;
                default:
                    break;
            }

            if (RequiresPenalty())
            {
                Penalties++;
                Position.X = Math.Clamp(Position.X, 0, _arena.Scale.X - 1);
                Position.Y = Math.Clamp(Position.Y, 0, _arena.Scale.Y - 1);
            }
        }

        public void Rotate(bool isClockwise)
        {
            if (isClockwise)
            {
                Position.Direction = Position.Direction == Direction.West ?
                    Direction.North :
                    (Direction)((int)Position.Direction + _turnDegrees);
            }
            else
            {
                Position.Direction = Position.Direction == Direction.North ?
                    Direction.West :
                    (Direction)((int)Position.Direction - _turnDegrees);
            }
        }

        public bool RequiresPenalty()
        {
            return (Position.X < 0 || Position.X >= _arena.Scale.X) ||
                   (Position.Y < 0 || Position.Y >= _arena.Scale.Y);
        }
    }
}
