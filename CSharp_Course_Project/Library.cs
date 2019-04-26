using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    class Library
    {
        public static string GetText()
        {
            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();

            return text;
        }

        public static string[] ExtraSpacesDeleting(string text)
        {
            string[] textWithoutExtraSpaces = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return textWithoutExtraSpaces;
        }
    }
}
