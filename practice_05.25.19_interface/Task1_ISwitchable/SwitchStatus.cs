using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_05._25._19_interface.Task1_ISwitchable
{
    public class SwitchStatus
    {
        public void Switch()
        {
            Console.WriteLine("Enter 1 to turn on or enter 2 to turn off the device");
            var action = Console.ReadLine();

            var device = new Device();

            if (action == "1")
            {
                device.SwitchOn();
            }
            else if (action == "2")
            {
                device.SwitchOff();
            }
        }
    }
}
