using RobotWars.Entities;

namespace RobotWars.Commands
{
    public class RotateRightCommand : ICommand
    {
        public void Execute(IRobot robot)
        {
            robot.Rotate(true);
        }
    }
}
