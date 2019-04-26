using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    class Task7_CamelCase
    {
        public static void ToCamelCase()
        {
            while (true)
            {
                Console.WriteLine("Enter some text with dashes:");
                string inputText = Console.ReadLine();

                if (inputText.Contains("-"))
                {
                    string[] splittedTextArray = Task7_CamelCase.TextSplitting(inputText);
                    string camelCaseText = Task7_CamelCase.GetCamelCaseText(splittedTextArray);
                    Console.WriteLine(camelCaseText);
                    break;
                }
                else
                {
                    Console.WriteLine("Your text doesn't contain any dashes. Try again...");
                    continue;
                }
            }
        }

        public static string[] TextSplitting(string text)
        {
            string[] splittedTextArray = text.Split('-');

            return splittedTextArray;
        }

        public static string GetCamelCaseText(string[] array)
        {
            string camelCaseText = "";
            string[] inputTextCamelCaseArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                inputTextCamelCaseArray[i] = array[i].Substring(0, 1).ToUpper() + array[i].Substring(1, array[i].Length - 1);
            }
            camelCaseText = string.Join("_", inputTextCamelCaseArray);

            return camelCaseText;
        }
    }
}
