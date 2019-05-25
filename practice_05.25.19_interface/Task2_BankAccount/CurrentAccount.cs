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
            return this.currentBalance + contributedFunds;
        }

        public decimal WithdrawFunds(decimal withdrawnFunds)
        {
            return this.currentBalance - withdrawnFunds;
        }
    }
}
