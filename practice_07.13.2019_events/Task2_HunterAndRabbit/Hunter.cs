using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_07._13._2019_events.Task2_HunterAndRabbit
{
    public class Hunter
    {
        public void PrintRabbitLocation(int coordinateX, int coordinateY)
        {
            Console.WriteLine($"Rabbit was catched on coordinates{Environment.NewLine}" +
                $"X: {coordinateX}{Environment.NewLine}" +
                $"Y: {coordinateY}{Environment.NewLine}");
        }
    }
}
