using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_05._25._19_interface.Task1_ISwitchable
{
    public class Device : ISwitchable
    {
        public void SwitchOn()
        {
            Console.WriteLine("Device was turned on");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Device was turned off");
        }
    }
}
