using System;

namespace practice_05._18._19_polymorphysm.Task4_Calculator
{
    public abstract class Operation
    {
        private string action;

        public virtual string Action
        {
            get
            {
                return action = GetType().Name;
            }
        }

        public abstract double Calculate(double firstValue, double secondValue);

        public override string ToString()
        {
            return $"Вычисление происходит с помощью операции {action}";
        }
    }
}
