using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_05._25._19_interface.Task2_BankAccount
{
    public class CurrentAccount : BankAccount, IFundsFreeAccess
    {
        public CurrentAccount(decimal currentBalance, string balanceOwner) 
            :base(currentBalance, balanceOwner)
        {
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
                $"Account Owner: {this.AccountOwner}";
        }
    }
}
