using Microsoft.SPOT;
using Gadgeteer.Modules.GHIElectronics;

namespace HelloButtonModule
{
    public partial class Program
    {
        void ProgramStarted()
        {
            Debug.Print("Program Started");
            button.ButtonPressed += button_ButtonPressed;
            button.ButtonReleased += button_ButtonReleased;
        }

        void button_ButtonReleased(Button sender, Button.ButtonState state)
        {
            button.TurnLEDOff();
        }

        void button_ButtonPressed(Button sender, Button.ButtonState state)
        {
            button.TurnLEDOn();
        }
    }
}
