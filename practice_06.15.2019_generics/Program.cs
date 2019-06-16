using practice_06._15._2019_generics.Task1_MyList;
using practice_06._15._2019_generics.Task2_CarCollection;
using System;

namespace practice_06._15._2019_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Execute().CodeExecute();

            var car = new CarCollection<Car>();
            car.Add(new Car() { CarName = "Suzuki", CarYear = 2000 });
            //car.Contains();
        }
    }
}
