using System;

namespace practice_05._11._19_classes.Task2_Plants
{
    public class Worker
    {
        public void ManagePlant(Plant plant)
        {
            var random = new Random();

            var waterRandom = random.Next(0, 100);
            var mineralRandom = random.Next(0, 20);

            plant.WaterIntake(waterRandom);

            plant.MineralIntake(mineralRandom);

            plant.OxygenRelease(waterRandom, mineralRandom);

            if (plant is Flower flower)
                flower.CollectPollen();
            else if (plant is Tree tree)
                tree.AgeCount();

            Console.WriteLine();
        }
    }
}
