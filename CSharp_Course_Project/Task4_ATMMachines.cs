using System;

namespace CSharp_Course_Project
{
    class Task4_ATMMachines
    {
        public static void ValidatePin()
        {
            while (true)
            {
                Console.WriteLine("Enter the 4-digit or 6-digit PIN:");
                string pin = Task4_ATMMachines.InputPin();
                bool isPinNumber = Task4_ATMMachines.IsPinNumber(pin);
                bool correctPinLength = Task4_ATMMachines.CorrectPinLength(pin);
                if (!isPinNumber)
                {
                    Console.WriteLine($"PIN is not a number: {pin}. Try again...");
                    continue;
                }
                else if (!correctPinLength)
                {
                    Console.WriteLine($"Not valid PIN length: {pin}. Try again...");
                    continue;
                }
                else if (isPinNumber || correctPinLength)
                {
                    Console.WriteLine($"Correct PIN format: {pin}");
                    break;
                }
            }
        }

        private static string InputPin()
        {
            string inputPin = Console.ReadLine();

            return inputPin;
        }

        private static bool IsPinNumber(string inputPin)
        {
            bool isPinNumber = Int32.TryParse(inputPin, out int pin);
            if (!isPinNumber)
            {
                isPinNumber = false;
                return isPinNumber;
            }
            else
            {
                isPinNumber = true;
                return isPinNumber;
            }
        }

        private static bool CorrectPinLength(string inputPin)
        {
            bool correctPinLength = true;
            if (inputPin.Length != 4 && inputPin.Length != 6)
            {
                correctPinLength = false;
                return correctPinLength;
            }
            else
            {
                correctPinLength = true;
                return correctPinLength;
            }
        }
    }
}
