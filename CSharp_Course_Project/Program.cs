using System;
using CSharp_Course_Project.Task5;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Task1.TrainScheduler().Execute();
            //new Task2.Handler().Execute();
            //Console.WriteLine(String.Format("{0} | {1} | {2} | {3} | {4} | {5}\n", "Name", "Surname", "Date of Birth", "Age", "School Number", "School Group"));
            //new Task4.PupilList().Execute();

            Task5.Vehicle[] vehicles =
            {
                new Car(4, EngineType.Petrol, Gearbox.Manual, 4, ConsoleColor.Yellow, 180, 4),
                new Car(4, EngineType.Electric, Gearbox.Manual, 4, ConsoleColor.DarkGray, 150, 3),
                new Vehicle(2, ConsoleColor.Blue, 60, 1),
                new Vehicle(2, ConsoleColor.Red, 40, 2),
                new Moto(MotoType.Chopper, 3, ConsoleColor.Cyan, 120, 3),
                new Moto(MotoType.Adventure, 2, ConsoleColor.Magenta, 160, 2)
            };

            foreach (var item in vehicles)
            {
                item.Move(1000);
            }
        }
    }
}