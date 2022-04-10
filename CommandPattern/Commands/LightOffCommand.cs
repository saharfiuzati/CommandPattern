using CommandPattern.DataAccess;

namespace CommandPattern.Command
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On = false;
        }

        public void UnExecute()
        {
            _light.On = true;
        }
    }
}
