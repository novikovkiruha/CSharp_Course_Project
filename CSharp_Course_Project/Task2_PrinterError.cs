using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    class Task2_PrinterError
    {
        public static void PrinterError()
        {
            string controlString = GetControlString();
            double errorCounter = GetErrorCounter();

            Console.WriteLine(controlString);
            Console.WriteLine($"{errorCounter} / {controlString.Length}");
            double result = errorCounter / controlString.Length;
            Console.WriteLine($"The error rate = {result}");
        }

        private static string GetControlString()
        {
            var random = new Random();
            int randomNumber = random.Next(10, 50);

            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] printerColors = new char[randomNumber];

            for (int i = 0; i < printerColors.Length; i++)
            {
                printerColors[i] = chars[random.Next(chars.Length)];
            }
            Array.Sort(printerColors);
            string controlString = string.Join("", printerColors);

            return controlString;
        }

        private static double GetErrorCounter()
        {
            string controlString = GetControlString();
            string goodControlString = "abcdefghijklm";
            int counter = 0;
            for (int i = 0; i < controlString.Length; i++)
            {
                for (int j = 0; j < goodControlString.Length; j++)
                {
                    if (controlString[i] == goodControlString[j])
                        counter++;
                }
            }

            return controlString.Length - counter;
        }
    }
}
