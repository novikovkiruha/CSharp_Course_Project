﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_05._25._19_interface.Task2_BankAccount
{
    public interface IFundsFreeAccess
    {
        decimal DepositFunds(decimal contributedFunds);

        decimal WithdrawFunds(decimal withdrawnFunds);
    }
}
