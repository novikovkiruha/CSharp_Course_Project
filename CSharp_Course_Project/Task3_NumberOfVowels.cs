using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    class Task3_NumberOfVowels
    {
        public static void NumberOfVowels()
        {
            string text = Library.GetText();
            int vowelsCount = Task3_NumberOfVowels.GetVowelsNumber(text);
            Console.WriteLine($"\"{text}\" - {vowelsCount} vowels");
        }

        private static int GetVowelsNumber(string text)
        {
            char[] vowels = "aeiou".ToCharArray();
            int vowelsCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (text[i] == vowels[j])
                    {
                        vowelsCount++;
                    }
                }
            }

            return vowelsCount;
        }
    }
}
