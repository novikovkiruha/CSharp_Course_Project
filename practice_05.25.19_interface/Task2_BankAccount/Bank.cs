using System;
using System.Collections.Generic;

namespace practice_05._25._19_interface.Task2_BankAccount
{
    public class Bank
    {
        private readonly List<BankAccount> accounts;

        public Bank()
        {
            this.accounts = new List<BankAccount>();
        }

        public void ManageAccount()
        {
            new Bank().AccomplishAccountAction(new AccountList().ShowAccountInformation(new Bank().AddNewAccount()));
        }

        public List<BankAccount> AddNewAccount()
        {
            while (true)
            {
                Console.WriteLine("Do you want to add new account? Y/N");
                string action = Console.ReadLine();
                if (action.ToLower() == "y")
                {
                    while (true)
                    {
                        Console.WriteLine($"Choose one of the account that you want to add:{Environment.NewLine}" +
                            $"1 - Bank Account{Environment.NewLine}" +
                            $"2 - Deposit Account{Environment.NewLine}" +
                            $"3 - Card Account{Environment.NewLine}" +
                            $"4 - Current Account{Environment.NewLine}" +
                            "0 - to return in previous menu");
                        string accountType = Console.ReadLine();
                        switch (accountType)
                        {
                            case "1":
                                this.accounts.Add(new BankAccount(10000, "John"));
                                break;
                            case "2":
                                this.accounts.Add(new DepositAccount(5000, "Lesley", 20));
                                break;
                            case "3":
                                this.accounts.Add(new CardAccount(3500, "David", 5));
                                break;
                            case "4":
                                this.accounts.Add(new CurrentAccount(200000, "Wilson"));
                                break;
                            case "0":
                                break;
                            default:
                                Console.WriteLine("You use wrong number. Please, try again...");
                                continue;
                        }
                        break;
                    }
                }
                else
                {
                    return this.accounts;
                }
            }
        }

        public void AccomplishAccountAction(List<BankAccount> accounts)
        {
            foreach (var account in accounts)
            {
                while (true)
                {
                    Console.WriteLine($"Choose action for {account.GetType().Name}:{Environment.NewLine}" +
                    $"1 - Deposit money{Environment.NewLine}" +
                    $"2 - Withdraw money{Environment.NewLine}" +
                    "3 - Close account");
                    string action = Console.ReadLine();

                    if (action == "1")
                    {
                        if (account is IFundsFreeAccess newAccount)
                        {
                            newAccount.DepositFunds(4000);
                            Console.WriteLine(account.ToString());
                        }
                        else
                            break;
                    }
                    else if (action == "2")
                    {
                        if (account is IFundsFreeAccess newAccount)
                        {
                            newAccount.WithdrawFunds(4000);
                            Console.WriteLine(account.ToString());
                        }
                        else
                            break;
                    }
                    else if (action == "3")
                    {
                        decimal returnedBalance = account.CloseAccount();
                        Console.WriteLine($"{account.GetType().Name} was closed. The returned amount = {returnedBalance}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong action. Try again...{Environment.NewLine}");
                        continue;
                    }
                }
                //
                // error for newAccount variable
                //
                //switch (action)
                //{
                //    case "1":
                //        if (account is IFundsFreeAccess newAccount)
                //            newAccount.DepositFunds(4000);
                //        break;
                //    case "2":
                //        if (account is IFundsFreeAccess newAccount)
                //            newAccount.DepositFunds(4000);
                //        break;
                //    case "3":
                //        if (account is IChargeableInterest newAccount)
                //            newAccount.DepositFunds(4000);
                //        break;
                //    default:
                //        break;
                //}
            }
        }
    }
}
