using System;
using System.Threading;

namespace practice_05._18._19_polymorphysm.Task4_Calculator
{
    public class Calculator
    {
        private readonly double firstValue;

        private readonly double secondValue;

        public Calculator(double firstValue, double secondValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
        }

        private Operation[] operations =
        {
            new SumOperation(),
            new SubtractOperation(),
            new MultiplyOperation(),
            new DivideOperation(),
        };

        public void PerformCalculation()
        {
            foreach (var item in operations)
            {
                Console.WriteLine($"{item.GetType().Name} = {item.Calculate(this.firstValue, this.secondValue)}");
            }
        }
    }
}
