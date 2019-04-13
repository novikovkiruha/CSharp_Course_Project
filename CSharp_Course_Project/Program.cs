using System;

namespace CSharp_Course_Project
{
    class Program
    {
        public static int[] getArray()
        {
            Console.Write("Enter the sire of the array: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];
            var randomNubmers = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNubmers.Next(0, 10);
            }

            return array;
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

        // note: сделать с запоминанием индекса и пропускать индекс, если 
        public static void ArrayDuplicates(int[] array)
        {
            int[] arrayWtDuplicates = new int[array.Length];
            arrayWtDuplicates[0] = array[0];

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < arrayWtDuplicates.Length; j++)
                {
                    if (array[i] != arrayWtDuplicates[j])
                        arrayWtDuplicates[j] = array[i];
                    else
                    {
                        Console.WriteLine($"Duplicate: {array[i]}");
                        continue;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in arrayWtDuplicates)
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

            int min = -5;
            int max = 5;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min && array[i] < max)
                    Console.WriteLine($"Index of {array[i]} = {i}");
            }
        }

        //Дан одномерный массив. Найти среднее арифметическое его элементов. 
        //Вывести на экран только те элементы массива, которые больше найденного среднего арифметического.
        public static void ArrayAverage()
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

            int average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            average /= array.Length;
            Console.WriteLine(average);
        }
        //Создать метод MyReverse(int [] array), 
        //который принимает в качестве аргумента массив целочисленных элементов и возвращает инвертированный массив 
        //(элементы массива в обратном порядке).
        public static void MyReverse(int[] array)
        {
            Console.WriteLine("First array");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            int getLastElement = array.Length;
            int[] invertedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                array[i] = invertedArray[getLastElement - 1 - i];
                invertedArray[getLastElement - 1 - i] = temp;
            }
            Console.WriteLine();

            Console.WriteLine("Inverted array");
            foreach (var item in invertedArray)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            //ArrayValues();
            //ArrayDuplicates(getArray());
            //ArrayIndex();
            //ArrayAverage();
            MyReverse(getArray());
        }
    }
}