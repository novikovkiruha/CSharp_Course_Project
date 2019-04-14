using System;

namespace CSharp_Course_Project
{
    class Program
    {
        //
        // Method for filling array
        //
        public static int[] getArray()
        {
            Console.Write("Enter the size of the array: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];
            var randomNubmers = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNubmers.Next(-10, 10);
            }
            return array;
        }

        public static void ArrayValues() // 1
        {
            Console.Write("Enter the size of the array: ");
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

        public static void ArrayDuplicates(int[] array) // 2
        {
            Console.WriteLine("The input array: " + string.Join(", ", array));
            var arrayWithoutDuplicates = new int[array.Length];
            arrayWithoutDuplicates[0] = array[0];
            int position = 1;

            var isDuplicate = false;
            bool isContainZero = false;
            int zeroCount = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == 0)
                    isContainZero = true;

                for (int j = 0; j < position + 1; j++)
                {
                    if (array[i] == arrayWithoutDuplicates[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    arrayWithoutDuplicates[position] = array[i];
                    position++;
                }
                isDuplicate = false;
            }

            for (int i = 0; i < arrayWithoutDuplicates.Length; i++)
            {
                if (arrayWithoutDuplicates[i] == 0)
                {
                    zeroCount++;
                }
            }

            if (isContainZero) zeroCount--;

            int[] arrayWithoutZero = new int[arrayWithoutDuplicates.Length - zeroCount];
            position = 0;
            for (int i = 0; i < arrayWithoutDuplicates.Length; i++)
            {
                if (arrayWithoutDuplicates[i] != 0)
                {
                    arrayWithoutZero[position] = arrayWithoutDuplicates[i];
                }
                position++;
            }

            Console.WriteLine("Array without duplicates: " + string.Join(", ", arrayWithoutDuplicates));
            Console.WriteLine("Array without zeros " + string.Join(", ", arrayWithoutZero));
        }

        //В массиве определить индексы элементов, значение которых не меньше заданного минимума и не больше заданного максимума.
        public static void ArrayIndex() // 3
        {
            Console.Write("Enter the size of the array: ");
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
        public static void ArrayAverage() // 4
        {
            Console.Write("Enter the size of the array: ");
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
        public static void MyReverse(int[] array) // 5
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

        /*
        Создайте метод int[] SubArray(int[] array, int index, int count). 
        Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции указанной в аргументе index, 
        размерностью, которая соответствует значению аргумента count.

        Если аргумент count содержит значение больше чем количество элементов, 
        которые входят в выбираемую часть исходного массива (от указанного индекса index, 
        до индекса последнего элемента), то при формировании нового массива размерностью в count, 
        заполните единицами те элементы, которые не были скопированы из исходного массива.
        */
        public static int[] SubArray(int[] array, int index, int count) // 6
        {
            foreach (var item in array)
                Console.WriteLine(item);
            Console.WriteLine();

            int[] partialArray = new int[count];
            for (int i = 0; i < partialArray.Length; i++)
            {
                partialArray[i] = array[index + i];
            }

            foreach (var item in partialArray)
                Console.WriteLine(item);

            return partialArray;
        }

        static void Main(string[] args)
        {
            //ArrayValues();
            ArrayDuplicates(getArray());
            //ArrayIndex();
            //ArrayAverage();
            //MyReverse(getArray());
            //SubArray(getArray(), 1, 3);
        }
    }
}