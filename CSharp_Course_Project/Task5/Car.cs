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
    }

    enum EngineType
    {
        Electric,
        Petrol,
        Diesel
    }

    enum Gearbox
    {
        Manual,
        Auto,
        Robotic
    }
}
