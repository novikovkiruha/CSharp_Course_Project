using System;

namespace practice_05._25._19_interface.Task2_BankAccount
{
    public class BankAccount
    {
        private decimal currentBalance;

        protected string AccountOwner { get; }

        public BankAccount(decimal currentBalance, string balanceOwner)
        {
            this.currentBalance = currentBalance;
            this.AccountOwner = balanceOwner;
        }

        protected decimal CurrentBalance
        {
            get
            {
                return currentBalance;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                else
                    currentBalance = value;
            }
        }

        public decimal CloseAccount()
        {
            decimal returnedBalance = this.currentBalance;
            this.currentBalance = 0;

            return returnedBalance;
        }

        public override string ToString()
        {
            return $"Account Type: {this.GetType().Name}\n" +
                $"Current Balance: {this.CurrentBalance}\n" +
                $"Account Owner: {this.AccountOwner}";
        }
    }
}
