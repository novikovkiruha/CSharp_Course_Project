using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    class Task2_Converter
    {
        public static double Converter()
        {
            double money = InputMoney();
            string currency = InputCurrency();
            double dollar = 28;
            double euro = 30;
            double pound = 32;

            double result = 0;
            switch (currency)
            {
                case "dollar":
                    result = money * dollar;
                    break;
                case "euro":
                    result = money * euro;
                    break;
                case "pound":
                    result = money * pound;
                    break;
                default:
                    Console.WriteLine("Wrong value or currency symbol");
                    break;
            }
            Console.WriteLine($"Converted value in {currency} is {result}");
            return result;
        }

        private static double InputMoney()
        {
            Console.Write("Enter the sum of money in hryvnia: ");
            double money = Convert.ToDouble(Console.ReadLine());
            return money;
        }

        private static string InputCurrency()
        {
            Console.WriteLine("Enter the currency symbol: dollar, euro, pound");
            string currency = Console.ReadLine();
            return currency;
        }
    }
}
