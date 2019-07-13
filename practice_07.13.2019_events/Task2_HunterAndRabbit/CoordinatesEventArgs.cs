using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_07._13._2019_events.Task2_HunterAndRabbit
{
    public class CoordinatesEventArgs
    {
        public int FirstCoordinate { get; set; }

        public int SecondCoordinate { get; set; }

        public CoordinatesEventArgs(int firstCoordinate, int secondCoordinate)
        {
            this.FirstCoordinate = firstCoordinate;
            this.SecondCoordinate = secondCoordinate;
        }
    }
}
