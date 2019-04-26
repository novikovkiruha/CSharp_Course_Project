using System;

namespace CSharp_Course_Project
{
    class Task5_TriangleOddNumbers
    {
        public static int GetTriangleRowSum()
        {
            int row = Task5_TriangleOddNumbers.GetInputValue();
            
            return row * row * row;
        }

        public static void PrintTriangleRowSum()
        {
            Console.WriteLine($"Sum of input row = {Task5_TriangleOddNumbers.GetTriangleRowSum()}");
        }

        public static int GetInputValue()
        {
            while (true)
            {
                Console.Write("Enter the number of row: ");
                string inputValue = Console.ReadLine();
                if (!InputValueCheck.IsNumber(inputValue))
                {
                    Console.WriteLine("Not a number. Try again...");
                    continue;
                }
                int number = Convert.ToInt32(inputValue);

                return number;
            }
        }
    }
}
