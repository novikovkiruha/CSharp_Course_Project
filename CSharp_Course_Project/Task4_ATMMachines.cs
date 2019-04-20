using System;

namespace CSharp_Course_Project
{
    class Task4_ATMMachines
    {
        public static void ValidatePin()
        {
            string pin = InputPin();
            bool isPinNumber = IsPinNumber(pin);
            Console.WriteLine(isPinNumber);
            bool correctPinLength = CorrectPinLength(pin);
            Console.WriteLine(correctPinLength);
            if (isPinNumber == false)
            {
                Console.WriteLine($"PIN is not a number: {pin}");
            }
            else if (correctPinLength == false)
            {
                Console.WriteLine($"Not valid PIN length: {pin}");
            }
            else if (isPinNumber == true || correctPinLength == true)
            {
                Console.WriteLine($"Correct PIN format: {pin}");
            }
        }

        private static string InputPin()
        {
            Console.WriteLine("Enter the 4-digit or 6-digit PIN:");
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
