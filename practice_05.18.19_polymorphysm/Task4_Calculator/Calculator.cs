using System;
using System.Threading;

namespace practice_05._18._19_polymorphysm.Task4_Calculator
{
    public class Calculator
    {
        private Operation[] operations =
        {
            new SumOperation(),
            new SubtractOperation(),
            new MultiplyOperation(),
            new DivideOperation(),
        };

        public void PerformCalculation(double firstValue, double secondValue)
        {
            foreach (var item in operations)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.GetType().Name} = {item.Calculate(firstValue, secondValue)}");
            }
        }
    }
}
