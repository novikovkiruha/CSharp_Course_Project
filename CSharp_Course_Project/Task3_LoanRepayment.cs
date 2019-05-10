using System;

namespace CSharp_Course_Project
{
    class Task3_LoanRepayment
    {
        public static decimal LoanRepaymentStatus()
        {
            Console.WriteLine("Enter the total credit amount:");
            decimal creditAmount = Task3_LoanRepayment.GetCreditAmount();
            Console.WriteLine("Enter the payment amount:");
            decimal paymentAmount = Task3_LoanRepayment.GetPaymentAmount();

            decimal status = creditAmount - paymentAmount;
            decimal zero = decimal.Zero;
            if (status == zero)
            {
                Console.WriteLine($"The client paid off the entire loan");
            }
            else if (status > zero)
            {
                Console.WriteLine($"Client has amount of debt: {Math.Abs(status)}");
            }
            else if (status < zero)
            {
                Console.WriteLine($"Client has amount of overpayment: {Math.Abs(status)}");
            }

            return status;
        }

        private static decimal GetCreditAmount()
        {
            decimal creditAmount = Convert.ToDecimal(Console.ReadLine());

            return creditAmount;
        }

        private static decimal GetPaymentAmount()
        {
            decimal paymentAmount = Convert.ToDecimal(Console.ReadLine());

            return paymentAmount;
        }
    }
}
