using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task5
{
    class Vehicle
    {
        private int wheelCount = 1;

        private int maxSpeed = 1;

        private int passengerCount = 0;

        public ConsoleColor Color { get; set; }

        public int WheelCount
        {
            get
            {
                return wheelCount;
            }
            set
            {
                if (value > 0)
                    wheelCount = value;
            }
        }

        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                if (value > 0)
                    maxSpeed = value;
            }
        }

        public int PassengerCount
        {
            get
            {
                return passengerCount;
            }
            set
            {
                if (value > 0)
                    passengerCount = value;
            }
        }

        public void Move(int meters)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"{GetType().Name} has moved {meters} meters.");
        }

        public Vehicle(int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
        {
            this.wheelCount = wheelCount;
            this.Color = color;
            this.maxSpeed = maxSpeed;
            this.passengerCount = passengerCount;
        }
    }
}
