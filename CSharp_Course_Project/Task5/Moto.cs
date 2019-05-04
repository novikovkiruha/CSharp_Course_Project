using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task5
{
    class Moto : Vehicle
    {
        public MotoType MotoType { get; set; }

        public Moto(MotoType motoType,
            int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            :base(wheelCount, color, maxSpeed, passengerCount)
        {
            MotoType = motoType;
        }

        public override void DisplayCharacteristics(Vehicle vehicle)
        {
            Console.WriteLine(String.Format("{0, 6} | {1, 10} | {2, 9} | {3, 10} | {4, 10}",
                        "Wheels",
                        "Color",
                        "Max Speed",
                        "Passengers",
                        "Moto Type"
                        ));
            Console.Write(String.Format("{0, 6} | {1, 10} | {2, 9} | {3, 10} | {4, 10}",
                    vehicle.WheelCount,
                    vehicle.Color,
                    vehicle.MaxSpeed,
                    vehicle.PassengerCount,
                    this.MotoType
                    ));
            Console.WriteLine();
        }
    }

    enum MotoType
    {
        Adventure,
        Chopper,
        Cruiser,
        Enduro
    }
}
