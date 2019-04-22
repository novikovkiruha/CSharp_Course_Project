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
            while (true)
            {
                Console.Write("Enter the first argument: ");
                string firstArgString = Console.ReadLine();
                
                Console.Write("Enter the second argument: ");
                string secondArgString = Console.ReadLine();
                
                Console.WriteLine("Enter one of the option: '+' '-' '*' '/'");
                bool isValidSymbol = Char.TryParse(Console.ReadLine(), out char action);
                if (!InputValueCheck.IsPinNumber(firstArgString) || !InputValueCheck.IsPinNumber(secondArgString))
                {
                    Console.WriteLine("Argument is not a number. Try again...");
                    continue;
                }
                else if (!IsValidSymbol(action))
                {
                    Console.WriteLine("Not valid symbol. Try again...");
                    continue;
                }
                double firstArg = Convert.ToDouble(firstArgString);
                double secondArg = Convert.ToDouble(secondArgString);

                double result = GetMathResult(firstArg, secondArg, action);
                Console.WriteLine($"Result: {result}");
                return result;
            }
        }

        private static double GetMathResult(double firstArg, double secondArg, char action)
        {
            double result = 0;
            switch (action)
            {
                case '+':
                    result = Add(firstArg, secondArg);
                    break;
                case '-':
                    result = Sub(firstArg, secondArg);
                    break;
                case '*':
                    result = Mul(firstArg, secondArg);
                    break;
                case '/':
                    result = Div(firstArg, secondArg);
                    break;
                default:
                    break;
            }

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

        private static bool IsValidSymbol(char action)
        {
            char[] symbols = new char[] { '+', '-', '*', '/' };
            bool isValidSymbol = false;
            for (int i = 0; i < symbols.Length; i++)
            {
                if (action == symbols[i])
                {
                    isValidSymbol = true;
                }
            }

            return isValidSymbol;
        }
    }
}
