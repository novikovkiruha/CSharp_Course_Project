using System;

namespace CSharp_Course_Project
{
    class Task5_TriangleOddNumbers
    {
        public static int GetTriangleRowSum()
        {
            int row = GetInputValue();
            
            return row * row * row;
        }

        public static void PrintTriangleRowSum()
        {
            Console.WriteLine(GetTriangleRowSum());
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
