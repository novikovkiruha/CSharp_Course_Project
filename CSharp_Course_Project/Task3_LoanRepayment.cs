using System;

namespace CSharp_Course_Project
{
    class Task3_LoanRepayment
    {
        public static decimal LoanRepaymentStatus()
        {
            Console.WriteLine("Enter the total credit amount:");
            decimal creditAmount = Task3_LoanRepayment.CreditAmount();
            Console.WriteLine("Enter the payment amount:");
            decimal paymentAmount = Task3_LoanRepayment.PaymentAmount();

            decimal status = creditAmount - paymentAmount;
            if (status == 0)
            {
                Console.WriteLine($"The client paid off the entire loan");
            }
            else if (status > 0)
            {
                Console.WriteLine($"Client has amount of debt: {Math.Abs(status)}");
            }
            else if (status < 0)
            {
                Console.WriteLine($"Client has amount of overpayment: {Math.Abs(status)}");
            }

            return status;
        }

        private static decimal CreditAmount()
        {
            decimal creditAmount = Convert.ToDecimal(Console.ReadLine());

            return creditAmount;
        }

        private static decimal PaymentAmount()
        {
            decimal paymentAmount = Convert.ToDecimal(Console.ReadLine());

            return paymentAmount;
        }
    }
}
