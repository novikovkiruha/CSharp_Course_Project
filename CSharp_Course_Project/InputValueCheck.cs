﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    class InputValueCheck
    {
        private static bool IsPinNumber(string inputValue)
        {
            bool isNumber = Int32.TryParse(inputValue, out int pin);
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