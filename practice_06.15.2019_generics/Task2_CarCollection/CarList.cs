using System;

namespace practice_06._15._2019_generics.Task2_CarCollection
{
    public class CarList
    {
        public void CarDisplay()
        {
            var cars = new CarCollection<Car>();
            cars.Add(new Car() { CarName = "Suzuki", CarYear = 2000 });
            cars.Add(new Car() { CarName = "Toyota", CarYear = 2005 });
            cars.Add(new Car() { CarName = "Subaru", CarYear = 2010 });

            Console.WriteLine(cars.ToString());
            cars.Clear();
            Console.WriteLine(cars.ToString());
        }
    }
}
