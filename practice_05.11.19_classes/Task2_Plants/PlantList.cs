using System;

namespace practice_05._11._19_classes.Task2_Plants
{
    public static class PlantList
    {
        public static Plant[] GetPlantList()
        {
            Plant[] plants =
            {
                new Flower("Violet", 7, ConsoleColor.Magenta, 5),
                new Flower("Pion", 30, ConsoleColor.White, 10),
                new Tree("Oak tree", 300, ConsoleColor.Green, 30),
                new Tree("Birch tree", 150, ConsoleColor.Green, 10),
            };

            return plants;
        }
    }
}
