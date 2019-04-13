using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayValues();
        }
        //Создать массив размера N элементов, заполнить его произвольными целыми значениями(размер массива задает пользователь).  
        //Вывести на экран: наибольшее значение массива, наименьшее значение массива, 
        //общую сумму всех элементов, среднее арифметическое всех элементов, вывести все нечетные значения.
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

            foreach (var item in array)
            {
                Console.Write(string.Join(",", item));
            }
            Console.WriteLine();

            int max = array[0];
            int min = array[0];
            int sum = 0;
            int average = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                average = sum / array.Length;
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Avg = {average}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
        }
    }
}