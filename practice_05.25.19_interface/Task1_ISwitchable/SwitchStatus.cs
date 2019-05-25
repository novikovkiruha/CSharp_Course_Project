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
            Console.WriteLine("Enter '1' to turn on or enter '0' to turn off the device");
            var state = Console.ReadLine();

            var device = new Device();

            if (state == "1")
                device.SwitchOn();
            else if (state == "0")
                device.SwitchOff();

            Console.WriteLine(device.ToString());
        }
    }
}
