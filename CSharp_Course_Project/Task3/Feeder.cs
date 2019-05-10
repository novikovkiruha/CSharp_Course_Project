using System;
using System.Threading;

namespace CSharp_Course_Project.Task3
{
    static class Feeder
    {
        public static void Feed()
        {
            Mammal[] mammals =
            {
                new Aquatic(2, 4),
                new Aquatic(20, 1000),
                new Arboreal(0.5, 1),
                new Arboreal(0.1, 2),
                new Subterranean(0.8, 1.5),
                new Subterranean(0.3, 4),
                new Terrestrial(7, 60),
                new Terrestrial(0.9, 7)
            };

            for (int i = 0; i < mammals.Length; i++)
            {
                var randomFoodAmount = new Random().Next(1, 20);
                Thread.Sleep(50);
                mammals[i].Eat(randomFoodAmount);
            }
        }
    }
}
