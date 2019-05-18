using System;

namespace practice_05._18._19_polymorphysm.Task3_Human
{
    public class Ukrainian : Human
    {
        public Ukrainian(string name)
        {
            this.Name = name;
        }

        public override void SayHello()
        {
            Console.WriteLine($"{GetType().Name} says: 'Привiт!'");
        }
    }
}
