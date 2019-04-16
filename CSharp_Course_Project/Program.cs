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

        //
        // Method for filling two-dimensional array
        //
        public static int[,] getTwoDimArray()
        {
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] twoDimArray = new int[rows, columns];

            var random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    twoDimArray[i, j] = random.Next(-20, 20);
                }
            }
            Console.WriteLine();
            return twoDimArray;
        }

        public static void ArrayValues(int[] array) // 1
        {
            int max = array[0];
            int min = array[0];
            int sum = 0;
            int average = array[0];
            string odd = "Odd: ";
            string even = "Even: ";
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                average = sum / array.Length;
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
                if (array[i] % 2 == 0) even += $"{array[i]}, ";
                if (array[i] % 2 != 0) odd += $"{array[i]}, ";
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Avg = {average}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine(odd);
            Console.WriteLine(even);
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

        public static void ArrayIndex(int[] array) // 3
        {
            Console.WriteLine(string.Join(", ", array));
            int min = -5;
            int max = 5;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min && array[i] < max)
                    Console.WriteLine($"Index of {array[i]} in range ({min}; {max}) = {i}");
            }
        }

        public static void ArrayAverage(int[] array) // 4
        {
            Console.WriteLine(string.Join(", ", array));
            int average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            average /= array.Length;
            Console.WriteLine($"Average value of array: {average}");
        }

        public static void MyReverse(int[] array) // 5
        {
            Console.WriteLine("Input array:\t" + string.Join(" , ", array));
            int getLastElement = array.Length;
            int[] invertedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                array[i] = invertedArray[getLastElement - 1 - i];
                invertedArray[getLastElement - 1 - i] = temp;
            }
            Console.WriteLine("Inverted array:\t" + string.Join(" , ", invertedArray));
        }

        public static int[] SubArray(int[] array, int index, int count) // 6
        {
            Console.WriteLine("Input array:\t" + string.Join(" , ", array));

            int totalArrayLength = index + count;
            int[] partialArray = new int[count];
            for (int i = 0; i < partialArray.Length; i++)
            {
                if (totalArrayLength <= array.Length)
                    partialArray[i] = array[index + i];
                else
                {
                    while (index + i < array.Length)
                    {
                        partialArray[i] = array[index + i];
                        i++;
                    }
                }
            }

            if (totalArrayLength > array.Length)
            {
                int zeroNumber = index + count - array.Length;
                int zeroIndexInArray = partialArray.Length - zeroNumber;
                for (int i = zeroIndexInArray; i < partialArray.Length; i++)
                {
                    if (partialArray[i] == 0) partialArray[i] = 1;
                }
            }
            Console.WriteLine("Partial array:\t" + string.Join(" , ", partialArray));

            return partialArray;
        }

        public static int[] ArrayLengthIncreasing(int[] array) // 7
        {
            Console.WriteLine("Input array: " + string.Join(", ", array));

            int[] increasedArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
                increasedArray[i] = array[i];

            Console.WriteLine("Increased array: " + string.Join(", ", increasedArray));

            return increasedArray;
        }

        public static int[] SecondArgumentAdding(int[] array, int value) // 7
        {
            Console.WriteLine("Input array: " + string.Join(", ", array));

            int[] arrayWithNewArgument = new int[array.Length + 1];
            arrayWithNewArgument[0] = value;
            for (int i = 1; i < arrayWithNewArgument.Length; i++)
                arrayWithNewArgument[i] = array[i - 1];

            Console.WriteLine("Increased array with argument: " + string.Join(", ", arrayWithNewArgument));

            return arrayWithNewArgument;
        }

        public static void RequiredElementInTwoDimensionalArray(int x) // 8
        {
            int[,] twoDimArray = new int[2, 3] { { 5, 3, 7 }, { 7, 3, 5 } };

            int rows = twoDimArray.GetLength(0);
            int columns = twoDimArray.GetLength(1);
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (twoDimArray[i, j] == x) count++;
                }
            }
            Console.WriteLine($"{x} element occurs {count} time(s)");
        }

        public static void SwappedNumbersInTwoDimensionalArray(int firstRow = 0, int secondRow = 1) // 9
        {
            int[,] twoDimArray = getTwoDimArray();
            int rows = twoDimArray.GetLength(0);
            int columns = twoDimArray.GetLength(1);

            //
            // Array display
            //
            Console.WriteLine("Original array");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{twoDimArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //
            // Array swapped rows
            //
            for (int i = 0; i < columns; i++)
            {
                int temp = twoDimArray[firstRow, i];
                twoDimArray[firstRow, i] = twoDimArray[secondRow, i];
                twoDimArray[secondRow, i] = temp;
            }

            //
            // Array display
            //
            Console.WriteLine($"Array with swapped {firstRow + 1} and {secondRow + 1} rows");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{twoDimArray[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //ArrayValues(getArray());
            //ArrayDuplicates(getArray());
            //ArrayIndex(getArray());
            //ArrayAverage(getArray());
            //MyReverse(getArray());
            //SubArray(getArray(), 5, 10);
            //ArrayLengthIncreasing(getArray());
            //SecondArgumentAdding(getArray(), 5);
            //RequiredElementInTwoDimensionalArray(5);
            SwappedNumbersInTwoDimensionalArray();
        }
    }
}