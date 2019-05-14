using System;

namespace practice_05._11._19_classes.Task2_Plants
{
    public class Gallery
    {
        private Plant[] plants = PlantList.GetPlantList();

        private Worker worker;

        public Gallery(Plant[] plants, Worker worker)
        {
            this.plants = plants;
            this.worker = worker;
        }

        public void Manage()
        {
            foreach (var item in plants)
            {
                Console.WriteLine($"{this.worker.GetType().Name} manage {item.Type}");
            }
        }
    }
}
