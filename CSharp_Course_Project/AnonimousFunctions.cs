using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    public class AnonimousFunctions
    {
        public delegate void SomeDelegate(string text);

        public delegate void SomeDelegate2(int arg1, int arg2);

        public delegate int CountIn(int arg1);

        public delegate string StringDelegate(string param);

        public void SomeMethod2(StringDelegate del, string param)
        {
            del.Invoke(param);
        }

        //public static CountIn Counter();
        //{
        //    int sum = 0;

        //    CountIn instance = delegate (int arg1)
        //    {
        //        return suml

        //    };
        //    return instance;
        //}
        public void Execute()
        {
            //SomeMethod2(s => Console.WriteLine(s.Length), "Text");

            // 1
            //SomeDelegate instance = delegate (string text)
            //{
            //    Console.WriteLine(text);
            //};

            //instance("Hi!");


            // 2
            //int arg1 = 1;
            //int arg2 = 2;
            //int sum = 0;
            //SomeDelegate2 delegate2 = delegate (int argument1, int argument2)
            //{
            //    sum = argument1 + argument2; // sum - захваченная
            //};

            //delegate2(arg1, arg2);
            //Console.WriteLine($"Sum: {sum}");
            //arg1 = 5;
            //delegate2(arg1, arg2);
            //Console.WriteLine($"Sum: {sum}");

            // 3
            //CountIn count = Counter();

            //int result = count(3);
            //Console.WriteLine(result);

            // 4
            var numbers = new List<int>{ 1, 5, 0, -6, 10 };
            string[] strings = { "one", "five", "zero", "-six", "ten" };

            var newNumbers = numbers.Where(element => element > 0 || element % 2 == 0);

            var positiveNumbers = new List<int>();
            var evenNumbers = new List<int>();

            foreach (var item in numbers)
            {
                if (GreaterThanZero(item))
                    positiveNumbers.Add(item);
                if (IsEven(item))
                    evenNumbers.Add(item);
            }

            foreach (var item in newNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static bool GreaterThanZero(int number)
        {
            return number > 0;
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
