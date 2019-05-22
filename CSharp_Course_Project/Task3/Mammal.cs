using System;

namespace CSharp_Course_Project.Task3
{
    public class Mammal
    {
        public double Age { get; }

        public double Weight { get; private set; }

        public Mammal(double age, double weight)
        {
            Age = age;
            Weight = weight;
        }

        public void Eat(int foodAmount)
        {
            if (this.Age <= 1)
            {
                Console.WriteLine("All mammals consume milk up to 1 year");
            }
            else
            {
                Console.WriteLine("All mammals consume meat or plants after 1 year");
            }

            double initialWeight = this.Weight;
            this.Weight += foodAmount / 5;
            Console.WriteLine($"Initial weight of {this.GetType().Name} is {initialWeight}. Weight after feeding is {this.Weight}");
        }
    }
}
