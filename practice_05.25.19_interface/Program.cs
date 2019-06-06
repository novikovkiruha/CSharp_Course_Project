using practice_05._25._19_interface.Task1_ISwitchable;
using practice_05._25._19_interface.Task2_BankAccount;
using System;

namespace practice_05._25._19_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //new SwitchStatus().Switch();
            new AccountList().ShowAccountInformation(new Bank().ManageAccount());
        }
    }
}
