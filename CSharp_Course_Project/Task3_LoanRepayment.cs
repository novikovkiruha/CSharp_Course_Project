using System;

namespace CSharp_Course_Project
{
    class Task3_LoanRepayment
    {
        public static double LoanRepaymentStatus()
        {
            double creditAmount = CreditAmount();
            double paymentAmount = PaymentAmount();

            double status = creditAmount - paymentAmount;
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

        private static double CreditAmount()
        {
            Console.WriteLine("Enter the total credit amount:");
            double creditAmount = Convert.ToDouble(Console.ReadLine());
            return creditAmount;
        }

        private static double PaymentAmount()
        {
            Console.WriteLine("Enter the payment amount:");
            double paymentAmount = Convert.ToDouble(Console.ReadLine());
            return paymentAmount;
        }
    }
}
