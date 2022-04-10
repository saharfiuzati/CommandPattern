using CommandPattern.Command;

namespace CommandPattern.Invokers
{
    public class PhilipsHue
    {
        public ICommand _lightOn;
        public ICommand _lightOff;

        public PhilipsHue(ICommand lightOn, ICommand lightOff)
        {
            _lightOn = lightOn;
            _lightOff = lightOff;
        }
    }
}
