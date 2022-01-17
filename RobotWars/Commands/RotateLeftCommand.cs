using RobotWars.Entities;

namespace RobotWars.Commands
{
    public class RotateLeftCommand : ICommand
    {
        public void Execute(IRobot robot)
        {
            robot.Rotate(false);
        }
    }
}
