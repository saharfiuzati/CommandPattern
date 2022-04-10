using CommandPattern.DataAccess;

namespace CommandPattern.Command
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On = true;
        }

        public void UnExecute()
        {
            _light.On = false;
        }
    }
}
