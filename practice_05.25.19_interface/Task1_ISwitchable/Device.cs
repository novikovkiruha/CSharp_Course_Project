using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_05._25._19_interface.Task1_ISwitchable
{
    public class Device : ISwitchable
    {
        public bool State { get; set; }

        public void SwitchOn()
        {
            this.State = true;
            Console.WriteLine($"{this.GetType().Name} is turning on");
        }

        public void SwitchOff()
        {
            this.State = false;
            Console.WriteLine($"{this.GetType().Name} is turning off");
        }

        public override string ToString()
        {
            if (this.State)
                return $"{this.GetType().Name} is on";
            else
                return $"{this.GetType().Name} is off";
        }
    }
}
