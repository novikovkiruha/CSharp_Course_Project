using System;

namespace CSharp_Course_Project.Task5
{
    class VehicleList
    {
        public Vehicle[] vehicles;

        public void Execute()
        {
            Vehicle[] vehicles =
                {
                new Car(4, EngineType.Petrol, Gearbox.Manual, 4, ConsoleColor.Yellow, 180, 4),
                new Car(4, EngineType.Electric, Gearbox.Auto, 4, ConsoleColor.DarkGray, 150, 3),
                new Bicycle(BicycleType.Mountain, BreakType.HandBrakes, 2, ConsoleColor.Blue, 60, 1),
                new Bicycle(BicycleType.Tourist, BreakType.FootBrakes, 2, ConsoleColor.Red, 40, 2),
                new Moto(MotoType.Chopper, 3, ConsoleColor.Cyan, 120, 3),
                new Moto(MotoType.Adventure, 2, ConsoleColor.Magenta, 160, 2)
                };

            foreach (var item in vehicles)
            {
                item.Move(1000);
                item.DisplayCharacteristics(item);
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
