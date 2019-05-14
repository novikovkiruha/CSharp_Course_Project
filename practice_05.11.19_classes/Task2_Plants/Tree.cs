using System;

namespace practice_05._11._19_classes.Task2_Plants
{
    public class Tree : Plant
    {
        public int RingNumber { get; set; }

        public Tree(string type, double height, ConsoleColor color, int ringNumber) : base(type, height, color)
        {
            this.RingNumber = ringNumber;
        }

        public void AgeCount()
        {
            Console.WriteLine($"Age of the {this.Type} is {this.RingNumber}");
        }
    }
}
