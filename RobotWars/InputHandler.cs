using RobotWars.Commands;
using RobotWars.Entities;
using System;

namespace RobotWars
{
    public class InputHandler : IInputHandler
    {
        private char _userInput;
        private readonly IRobot _actingRobot;
        private readonly ICommand _rKey;
        private readonly ICommand _lKey;
        private readonly ICommand _mKey;

        public InputHandler(IRobot robot)
        {
            _actingRobot = robot;
            _lKey = new RotateLeftCommand();
            _rKey = new RotateRightCommand();
            _mKey = new MoveCommand();
        }

        public void HandleInput(char? input = null)
        {
            GetInput(input);
            ICommand activeCommand = PerformAction();
            activeCommand.Execute(_actingRobot);
        }

        private void GetInput(char? input)
        {
            _userInput = input == null ?
                Console.ReadKey().KeyChar :
                input.Value;
        }

        private bool IsKeyPressed(char character)
        {
            return char.ToUpper(_userInput) == character;
        }

        private ICommand PerformAction()
        {
            if (IsKeyPressed((char)ConsoleKey.L)) { return _lKey; }
            else if (IsKeyPressed((char)ConsoleKey.R)) { return _rKey; }
            else if (IsKeyPressed((char)ConsoleKey.M)) { return _mKey; }

            return null;
        }
    }
}
