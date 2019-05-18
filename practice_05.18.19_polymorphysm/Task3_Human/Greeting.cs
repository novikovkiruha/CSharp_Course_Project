using System;

namespace practice_05._18._19_polymorphysm.Task3_Human
{
    public class Greeting
    {
        public void HumanGreeting()
        {
            Human[] humans =
            {
                new Ukrainian("Vasya"),
                new American("John"),
            };

            foreach (var item in humans)
            {
                item.SayHello();
            }
        }
    }
}
