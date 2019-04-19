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

        public static void PerfectNumbers()
        {
            for (int i = 2; i <= 1000; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine($"Perfect number: {i}");
                }
            }
        }

        public static char[] Encryption()
        {
            var encryptChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var cipher = new char[11] { ';', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };

            Console.WriteLine("Enter some text:");
            string inputText = Console.ReadLine();
            var inputTextArray = new char[inputText.Length];
            var cipherText = new char[inputText.Length];

            for (int i = 0; i < inputText.Length; i++)
            {
                inputTextArray[i] = inputText[i];
            }

            int counter = 0;
            int increment = 0;
            for (int i = 0; i < inputTextArray.Length; i++)
            {
                for (int j = 0; j < encryptChars.Length; j++)
                {
                    if (inputTextArray[i] == encryptChars[j])
                    {
                        cipherText[increment] = cipher[j];
                        increment++;
                    }
                    else
                    {
                        counter++;
                        if (counter == encryptChars.Length)
                        {
                            cipherText[increment] = cipher[cipher.Length - 1];
                            increment++;
                        }
                    }
                }
                counter = 0;
            }
            Console.WriteLine("Encryption:" + string.Join("", cipherText));

            return cipherText;
        }

        public static void Decryption()
        {
            var encryptChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var cipher = new char[11] { ';', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };

            var cipherText = Encryption();
            var outputTextArray = new char[cipherText.Length];
            int increment = 0;
            int counter = 0;

            for (int i = 0; i < cipherText.Length; i++) // fuck you = f
            {
                for (int j = 0; j < cipher.Length; j++) // ';', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$'
                {
                    if (cipherText[i] == cipher[j] && cipherText[i] != '$')
                    {
                        outputTextArray[increment] = encryptChars[j];
                        Console.WriteLine(outputTextArray[increment]);
                        increment++;
                    }
                    else
                    {
                        counter++;
                        if (counter == cipher.Length)
                        {
                            outputTextArray[increment] = '$';
                            Console.WriteLine(outputTextArray[increment]);
                            increment++;
                        }
                    }
                }
                counter = 0;
            }
            Console.WriteLine("Decryption: " + string.Join("", outputTextArray));
        }

        static void Main(string[] args)
        {
            //BinaryArray();
            //GoodsAndPricesArrays();
            //PerfectNumbers();
            //Encryption();
            Decryption();
        }
    }
}
