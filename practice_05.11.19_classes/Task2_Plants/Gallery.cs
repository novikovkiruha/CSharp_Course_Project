using System;

namespace practice_05._11._19_classes.Task2_Plants
{
    public class Gallery
    {
        private Plant[] plants;

        private Worker worker;

        public Gallery(Plant[] plants, Worker worker)
        {
            this.plants = plants;
            this.worker = worker;
        }

        public void Manage()
        {
            var random = new Random();
            foreach (var item in this.plants)
            {
                Console.WriteLine($"{this.worker.GetType().Name} manage {item.Type}");
                worker.ManagePlant(item);
            }
        }
    }
}
