using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_05._25._19_interface.Task2_BankAccount
{
    public class CardAccount : BankAccount, IChargeableInterest, IFundsFreeAccess
    {
        private decimal interestRate;

        public CardAccount(decimal currentBalance, string balanceOwner, decimal interestRate)
            : base(currentBalance, balanceOwner)
        {
            this.interestRate = interestRate;
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Interest rate can't be equal to 0");
                else
                    this.interestRate = value;
            }
        }

        public decimal ChargeInterest()
        {
            return this.InterestRate * this.CurrentBalance;
        }

        public decimal DepositFunds(decimal contributedFunds)
        {
            return this.CurrentBalance + contributedFunds;
        }

        public decimal WithdrawFunds(decimal withdrawnFunds)
        {
            return this.CurrentBalance - withdrawnFunds;
        }

        public override string ToString()
        {
            return $"Account Type: {this.GetType().Name}\n" +
                $"Current Balance: {this.CurrentBalance}\n" +
                $"Account Owner: {this.AccountOwner}\n" +
                $"Charged amount with an interest rate of {this.InterestRate}%: {this.ChargeInterest()}";
        }
    }
}