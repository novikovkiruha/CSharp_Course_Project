using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_05._18._19_polymorphysm.Task4_Calculator
{
    public class MultiplyOperation : Operation
    {
        private string action;

        public override string Action
        {
            get
            {
                return action = GetType().Name;
            }
        }

        public override double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
