using System;

namespace practice_05._18._19_polymorphysm.Task4_Calculator
{
    public abstract class Operation
    {
        public string Action { get; set; }

        public abstract double Calculate(double firstValue, double secondValue);
    }
}
