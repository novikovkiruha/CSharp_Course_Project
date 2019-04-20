using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    class InputValueCheck
    {
        public static bool IsNumber(string inputValue)
        {
            bool isNumber = Double.TryParse(inputValue, out double value);
            return isNumber;
        }
    }
}
