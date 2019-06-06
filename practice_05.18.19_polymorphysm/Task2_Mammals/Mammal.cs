using System;

namespace practice_05._18._19_polymorphysm.Task2_Mammals
{
    public abstract class Mammal
    {
        public double Age { get; private set; }

        public double Weight { get; private set; }

        public Mammal(double age, double weight)
        {
            Age = age;
            Weight = weight;
        }

        public abstract void Eat(int foodAmount);
    }
}