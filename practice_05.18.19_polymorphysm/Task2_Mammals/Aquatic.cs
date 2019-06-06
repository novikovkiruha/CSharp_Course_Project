using System;

namespace practice_05._18._19_polymorphysm.Task2_Mammals
{
    public class Aquatic : Mammal
    {
        public Aquatic(double age, double weight) : base(age, weight)
        {
        }

        public override void Eat(int foodAmount)
        {
            if (this.Age <= 1)
                Console.WriteLine($"All {GetType().Name} consume milk up to 1 year");
            else
                Console.WriteLine($"All {GetType().Name} consume meat or plants after 1 year");

            double initialWeight = this.Weight;
            double currentWeight = this.Weight + foodAmount / 5;
            Console.WriteLine($"Initial weight of {GetType().Name} is {initialWeight}. Weight after feeding is {currentWeight}");
        }
    }
}
