using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    class Task1_Calculation
    {
        public static double Calculation()
        {
            Console.Write("Enter the first argument: ");
            double firstArg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second argument: ");
            double secondArg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter one of the option: '+' '-' '*' '/'");
            string action = Console.ReadLine();

            double result = 0;
            switch (action)
            {
                case "+":
                    result = Add(firstArg, secondArg);
                    break;
                case "-":
                    result = Sub(firstArg, secondArg);
                    break;
                case "*":
                    result = Mul(firstArg, secondArg);
                    break;
                case "/":
                    result = Div(firstArg, secondArg);
                    break;
                default:
                    Console.WriteLine("Wrong symbol. Try again...");
                    break;
            }
            Console.WriteLine($"Result: {result}");
            return result;
        }

        private static double Add(double firstArg, double secondArg)
        {
            return firstArg + secondArg;
        }
        private static double Sub(double firstArg, double secondArg)
        {
            return firstArg - secondArg;
        }
        private static double Mul(double firstArg, double secondArg)
        {
            return firstArg * secondArg;
        }
        private static double Div(double firstArg, double secondArg)
        {
            return firstArg / secondArg;
        }
    }
}
