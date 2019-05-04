using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task5
{
    class Bicycle : Vehicle
    {
        public BicycleType BicycleType { get; set; }
        public BreakType BreakType { get; set; }

        public Bicycle(BicycleType bicycleType, BreakType breakType,
            int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            :base(wheelCount, color, maxSpeed, passengerCount)
        {
            BicycleType = bicycleType;
            BreakType = breakType;
        }
    }

    enum BicycleType
    {
        RoadBike,
        MountainBike,
        BMX,
        Tourist
    }

    enum BreakType
    {
        HandBrakes,
        FootBrakes
    }
}
