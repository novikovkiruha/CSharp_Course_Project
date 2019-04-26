using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    class Task2_Converter
    {
        public static decimal Converter()
        {
            Console.Write("Enter the sum of money in hryvnia: ");
            decimal money = Task2_Converter.InputMoney();
            Console.WriteLine("Enter the currency symbol: dollar, euro, pound");
            string currency = Task2_Converter.InputCurrency();
            decimal dollar = 28;
            decimal euro = 30;
            decimal pound = 32;

            decimal result = 0;
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

        private static decimal InputMoney()
        {
            decimal money = Convert.ToDecimal(Console.ReadLine());

            return money;
        }

        private static string InputCurrency()
        {
            string currency = Console.ReadLine();

            return currency;
        }
    }
}
