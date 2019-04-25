using System;

namespace CSharp_Course_Project
{
    class InputValueCheck
    {
        public static bool IsNumber(string inputValue)
        {
            bool isNumber = Int32.TryParse(inputValue, out int value);
            if (!isNumber)
            {
                isNumber = false;
                return isNumber;
            }
            else
            {
                isNumber = true;
                return isNumber;
            }
        }
    }
}
