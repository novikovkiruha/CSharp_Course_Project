using System;

namespace practice_05._11._19_classes.Task2_Plants
{
    public class Plant
    {
        public string Type { get; set; }

        public double Height { get; set; }

        public ConsoleColor Color { get; set; }

        public Plant(string type, double height, ConsoleColor color)
        {
            this.Type = type;
            this.Height = height;
            this.Color = color;
        }

        public void WaterIntake(double waterCount)
        {
            this.Height += waterCount;
            Console.WriteLine($"The plant {this.Type} was watered by {waterCount} liters of water and grew by {this.Height} cm.");
        }

        public void MineralIntake(double mineralCount)
        {
            ConsoleColor startColor = this.Color;
            ConsoleColor changedColor = ++this.Color;
            Console.WriteLine($"The plant {this.Type} changed color from {startColor} to {changedColor}");
        }

        public void OxygenRelease(double waterCount, double mineralCount)
        {
            double oxygenCount = waterCount + mineralCount;
            if (waterCount > 0 && mineralCount > 0)
                Console.WriteLine($"The plant {this.Type} allocated {oxygenCount} grams of oxygen");
        }
    }
}
