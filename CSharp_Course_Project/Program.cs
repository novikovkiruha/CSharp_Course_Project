using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            now.AddDays(5);
            Console.WriteLine(now.ToShortDateString());

            TimeSpan ts = new TimeSpan(2, 0, 0, 0, 0);
            Console.WriteLine(now.Add(ts));

            var now2 = now.Subtract(ts);
            Console.WriteLine(now2);

            TimeSpan ts2 = TimeSpan.FromDays(2.5);
            Console.WriteLine(ts2);

            Console.WriteLine(now.ToUniversalTime().Ticks);

            DateTimeOffset dto = DateTimeOffset.Now;
            Console.WriteLine(dto);

            Console.WriteLine(now.Equals(now2));
        }
    }
}