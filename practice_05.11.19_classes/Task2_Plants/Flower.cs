using System;

namespace practice_05._11._19_classes.Task2_Plants
{
    public class Flower : Plant
    {
        public double FlowerSize { get; set; }

        public Flower(string type, double height, ConsoleColor color, double flowerSize) 
            : base(type, height, color)
        {
            this.FlowerSize = flowerSize;
        }

        public void CollectPollen()
        {
            if (this.FlowerSize > 0)
            {
                double pollenCount = this.FlowerSize * 2;
                Console.WriteLine($"{pollenCount}g of pollen was collected from the {this.Type}");
            }
        }

    }
}
