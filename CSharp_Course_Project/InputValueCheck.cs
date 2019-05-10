using System;

namespace CSharp_Course_Project
{
    class InputValueCheck
    {
        public static bool IsNumber(string inputValue)
        {
            return Int32.TryParse(inputValue, out int value);
        }
    }
}
