using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_06._28._2019_delegates.Task1_Calculator
{
    //public delegate double Calculate(double firstArgument, double secondArgument);

    public class Calculator
    {
        public double Add(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }

        public double Subtract(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }

        public double Multiply(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }

        public double Divide(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }

    public class Helper
    {
        public void PrintResult(Func<double,double,double> action)
        {
            double firstArgument = 10;
            double secondArgument = 20;

            var calculationResult = action(firstArgument, secondArgument);

            Console.WriteLine(calculationResult);
        }
    }

    public class Execution
    {
        public void Execute()
        {
            var helper = new Helper();
            var calculator = new Calculator();

            helper.PrintResult(calculator.Add);
            helper.PrintResult(calculator.Subtract);
            helper.PrintResult(calculator.Multiply);
            helper.PrintResult(calculator.Divide);
        }
    }
}
