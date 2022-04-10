using CommandPattern.Command;
using CommandPattern.DataAccess;
using CommandPattern.Invokers;
using Microsoft.AspNetCore.Components;

namespace CommandPattern.Pages
{
    public class RoomBase : ComponentBase
    {
        private readonly Light _light;
        private readonly PhilipsHue _philipsHue;

        public RoomBase()
        {
            _light = new Light();
            _philipsHue = new PhilipsHue(new LightOnCommand(_light), new LightOffCommand(_light));

        }
        public bool LightOn { get; set; }

        public void On()
        {
            _philipsHue._lightOn.Execute();
            LightOn = _light.On;
        }

        public void Off()
        {
            _philipsHue._lightOff.Execute();
            LightOn = _light.On;
        }
    }
}
