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

        public override void DisplayCharacteristics(Vehicle vehicle)
        {
            Console.WriteLine(String.Format("{0, 6} | {1, 10} | {2, 9} | {3, 10} | {4, 8} | {5, 10}",
                        "Wheels",
                        "Color",
                        "Max Speed",
                        "Passengers",
                        "Bicycle",
                        "Break Type"
                        ));
            Console.Write(String.Format("{0, 6} | {1, 10} | {2, 9} | {3, 10} | {4, 8} | {5, 10}",
                    vehicle.WheelCount,
                    vehicle.Color,
                    vehicle.MaxSpeed,
                    vehicle.PassengerCount,
                    this.BicycleType,
                    this.BreakType
                    ));
            Console.WriteLine();
        }
    }

    enum BicycleType
    {
        Road,
        Mountain,
        BMX,
        Tourist
    }

    enum BreakType
    {
        HandBrakes,
        FootBrakes
    }
}
