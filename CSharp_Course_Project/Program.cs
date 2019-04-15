using System;

namespace CSharp_Course_Project
{
    class Program
    {
        public static void BinaryArray() // 1
        {
            Console.Write("Enter the size of the array: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];

            Console.Write("Enter array values: ");
            for (int i = 0; i < array.Length; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(string.Join(",", array));

            for (int i = 0; i < array.Length; i++)
            {
                if (array[0] != 0)
                {
                    for (int j = 0; j < array[i]; j++)
                    {
                        if (i % 2 == 0)
                            Console.Write("0");
                        else
                            Console.Write("1");
                    }
                }
                else
                {
                    for (int j = 0; j < array[i]; j++)
                    {
                        if (i % 2 == 0)
                            Console.Write("0");
                        else
                            Console.Write("1");
                    }
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            BinaryArray();
        }
    }
}