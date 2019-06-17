﻿using System;
using System.Collections.Generic;

namespace practice_05._25._19_interface.Task2_BankAccount
{
    public class Bank
    {
        private readonly List<BankAccount> accounts;

        public Bank()
        {
            accounts = new List<BankAccount>();
        }

        public List<BankAccount> ManageAccount()
        {
            while (true)
            {
                Console.WriteLine("Do you want to add new account? Y/N");
                string action = Console.ReadLine();
                if (action.ToLower() == "y")
                {
                    while (true)
                    {
                        Console.WriteLine("Choose one of the account that you want to add:\n" +
                            "1 - Bank Account\n" +
                            "2 - Deposit Account\n" +
                            "3 - Card Account\n" +
                            "4 - Current Account\n" +
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
                    return accounts;
                }
            }
        }
    }
}
