namespace RobotWars.Entities
{
    public interface IRobot
    {
        public Position Position { get; set; }
        public int Penalties { get; set; }
        public void Move();
        public void Rotate(bool isClockwise);
        public bool RequiresPenalty();
    }
}
