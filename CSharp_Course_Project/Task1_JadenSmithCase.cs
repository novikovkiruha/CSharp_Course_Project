using System;

namespace CSharp_Course_Project
{
    class Task1_JadenSmithCase
    {
        public static void JadenSmithCase()
        {
            var jadenCasedText = Task1_JadenSmithCase.FirstLetterToUpperCase();
            Console.WriteLine(string.Join(" ", jadenCasedText));
        }

        public static string[] GetInputTextArray()
        {
            Console.WriteLine("Enter some text:");
            string text = Library.GetText();
            string[] textArray = Library.ExtraSpacesDeleting(text);

            return textArray;
        }

        public static string[] FirstLetterToUpperCase()
        {
            var textArray = Task1_JadenSmithCase.GetInputTextArray();
            string[] upperCaseArray = new string[textArray.Length];
            for (int i = 0; i < upperCaseArray.Length; i++)
            {
                upperCaseArray[i] = textArray[i].Substring(0, 1).ToUpper() + textArray[i].Substring(1, textArray[i].Length - 1);
            }

            return upperCaseArray;
        }
    }
}
