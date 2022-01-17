using RobotWars.Entities;

namespace RobotWars.Commands
{
    public interface ICommand
    {
        public void Execute(IRobot robot);
    }
}
