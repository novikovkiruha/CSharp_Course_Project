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

        /* В один массив записаны наименования товаров, в другую - их цена.
         * Написать программу, вычисляющую общую стоимость покупки при условии,
         * что пользователь может указывать приобретаемый товар и его количество.*/
        public static void GoodsAndPricesArrays()
        {
            var items = new string[] { "Груши", "Яблоки", "Огурцы", "Помидоры", "Укроп", "Петрушка", "Курица", "Сыр", "Масло", "Молоко" };
            var prices = new double[] { 40.5, 31.2, 21.8, 35, 150, 145, 200, 400, 81.4, 53.35 };

            Console.WriteLine("Available items and their prices:");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]} - {prices[i]}");
            }

            Console.WriteLine("Please, press item number and quantity. Or press '0' to cancel");
            double totalSum = 0;
            while (true)
            {
                Console.Write("Item: ");
                string item = Console.ReadLine();
                bool isItemNumber = Int32.TryParse(item, out int itemNumber);
                if (itemNumber == 0) break;
                if (!isItemNumber || itemNumber < 0)
                {
                    Console.WriteLine("Incorrect value. Try enter the ID of item.");
                    continue;
                }

                Console.Write("Quantity: ");
                string quantity = Console.ReadLine();
                bool isQuantityNumber = Double.TryParse(quantity, out double itemQuantity);
                if (!isQuantityNumber || itemQuantity < 0)
                {
                    Console.WriteLine("Incorrect value. Try enter the weigth or quantity of item.");
                    continue;
                }

                switch (itemNumber)
                {
                    case 1:
                        totalSum += prices[0] * itemQuantity;
                        continue;
                    case 2:
                        totalSum += prices[1] * itemQuantity;
                        continue;
                    case 3:
                        totalSum += prices[2] * itemQuantity;
                        continue;
                    case 4:
                        totalSum += prices[3] * itemQuantity;
                        continue;
                    case 5:
                        totalSum += prices[4] * itemQuantity;
                        continue;
                    case 6:
                        totalSum += prices[5] * itemQuantity;
                        continue;
                    case 7:
                        totalSum += prices[6] * itemQuantity;
                        continue;
                    case 8:
                        totalSum += prices[7] * itemQuantity;
                        continue;
                    case 9:
                        totalSum += prices[8] * itemQuantity;
                        continue;
                    case 10:
                        totalSum += prices[9] * itemQuantity;
                        continue;
                    case 0:
                        break;
                }
            }
            Console.WriteLine($"Total sum of items: {totalSum}");
        }

        static void Main(string[] args)
        {
            //BinaryArray();
            GoodsAndPricesArrays();
        }
    }
}