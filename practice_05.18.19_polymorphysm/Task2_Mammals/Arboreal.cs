using System;

namespace practice_05._18._19_polymorphysm.Task2_Mammals
{
    public class Arboreal : Mammal
    {
        public Arboreal(double age, double weight) : base(age, weight)
        {
        }

        public override void Eat(int foodAmount)
        {
            if (this.Age <= 2)
                Console.WriteLine($"All {GetType().Name} consume milk up to 2 years");
            else
                Console.WriteLine($"All {GetType().Name} consume meat or plants after 2 years");

            double initialWeight = this.Weight;
            double currentWeight = this.Weight + foodAmount / 10;
            Console.WriteLine($"Initial weight of {GetType().Name} is {initialWeight}. Weight after feeding is {currentWeight}");
        }
    }
}
