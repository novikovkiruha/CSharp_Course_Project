using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_05._25._19_interface.Task2_BankAccount
{
    public class DepositAccount : BankAccount, IChargeableInterest
    {
        private decimal interestRate;

        public DepositAccount(decimal currentBalance, string balanceOwner, decimal interestRate) 
            :base(currentBalance, balanceOwner)
        {
            this.interestRate = interestRate;
        }

        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Interest rate can't be equal to 0");
                else
                    interestRate = value;
            }
        }

        public decimal ChargeInterest()
        {
            return this.InterestRate * this.CurrentBalance;
        }

        public override void ShowAccountInformation()
        {
            Console.WriteLine($"Account Type: {this.GetType().Name}\n" +
                $"Current Balance: {this.CurrentBalance}\n" +
                $"Account Owner: {this.AccountOwner}\n" +
                $"Charged amount with an interest rate of {this.InterestRate}: {this.ChargeInterest()}");
        }
    }
}
