namespace DesignPatterns.Behavioral.Command
{
    public interface ICommand
    {
        void Execute();
    }

    public class Light
    {
        public void TurnOn() => Console.WriteLine("Turn On the lights");
        public void TurnOff() => Console.WriteLine("Turn Off the lights");
    }

    public class TurnOnCommand : ICommand
    {
        private Light _light;
        public TurnOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute() => _light.TurnOn();
    }

    public class TurnOffCommand : ICommand
    {
        private Light _light;
        public TurnOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute() => _light.TurnOff();
    }

    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Execute() => _command.Execute();
    }
}
