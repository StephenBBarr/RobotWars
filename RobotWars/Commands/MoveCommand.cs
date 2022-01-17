using RobotWars.Entities;

namespace RobotWars.Commands
{
    public class MoveCommand : ICommand
    {
        public void Execute(IRobot robot)
        {
            robot.Move();
        }
    }
}
