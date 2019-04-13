using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayValues();
            //ArrayDuplicates();
            ArrayIndex();
        }

        public static void ArrayValues()
        {
            Console.Write("Enter the sire of the array: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];
            var randomNubmers = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNubmers.Next(-100, 100);
            }

            int max = array[0];
            int min = array[0];
            int sum = 0;
            int average = array[0];
            int odd = array[0];
            int even = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                average = sum / array.Length;
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
                if (array[i] % 2 == 0) Console.WriteLine($"{array[i]} is even");
                if (array[i] % 2 != 0) Console.WriteLine($"{array[i]} is odd");
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Avg = {average}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
        }

        public static void ArrayDuplicates()
        {
            int[] array = new int[] { 5, 4, 9, 2, 5, 6, 0, 2, 1, 0 };

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine($"Duplicate: {array[i]}");
                        count++;
                    }
                }
            }

            int[] array2 = new int[array.Length - count];
            Console.WriteLine(array2.Length);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        //В массиве определить индексы элементов, значение которых не меньше заданного минимума и не больше заданного максимума.
        public static void ArrayIndex()
        {
            Console.Write("Enter the sire of the array: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];
            var randomNubmers = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNubmers.Next(-100, 100);
            }
            Console.WriteLine(string.Join(",", array));

            int min = -50;
            int max = 50;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min && array[i] < max)
                    Console.WriteLine($"Index of {array[i]} = {i}");
            }
        }
    }
}