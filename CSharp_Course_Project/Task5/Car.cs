using System;

namespace CSharp_Course_Project.Task5
{
    class Car : Vehicle
    {
        private int doorsCount;
        public EngineType EngineType { get; set; }
        public Gearbox Gearbox { get; set; }

        public Car(int doorsCount, EngineType engineType, Gearbox gearbox,
            int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            :base(wheelCount, color, maxSpeed, passengerCount)
        {
            this.doorsCount = doorsCount;
            EngineType = engineType;
            Gearbox = gearbox;
        }

        public int DoorsCount
        {
            get
            {
                return doorsCount;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Should be more or equal to 0");
                else
                    doorsCount = value;
            }
        }

        public override void DisplayCharacteristics(Vehicle vehicle)
        {
            Console.WriteLine(String.Format("{0, 6} | {1, 10} | {2, 9} | {3, 10} | {4, 5} | {5, 10} | {6, 10}",
                        "Wheels",
                        "Color",
                        "Max Speed",
                        "Passengers",
                        "Doors",
                        "Engine",
                        "Gearbox"
                        ));
            Console.Write(String.Format("{0, 6} | {1, 10} | {2, 9} | {3, 10} | {4, 5} | {5, 10} | {6, 10}",
                    vehicle.WheelCount,
                    vehicle.Color,
                    vehicle.MaxSpeed,
                    vehicle.PassengerCount,
                    this.doorsCount,
                    this.EngineType,
                    this.Gearbox
                    ));
            Console.WriteLine();
        }
    }

    enum EngineType
    {
        Electric,
        Petrol,
        Diesel,
        Gasoline
    }

    enum Gearbox
    {
        Manual,
        Auto,
        Robotic,
        Hybrid
    }
}
