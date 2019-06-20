using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_05._25._19_interface.Task2_BankAccount
{
    public class AccountList
    {
        public List<BankAccount> ShowAccountInformation(List<BankAccount> accounts)
        {
            foreach (var item in accounts)
            {
                try
                {
                    Console.WriteLine(item.ToString());
                }
                catch (NullReferenceException)
                {
                    throw new NullReferenceException();
                }
                
                Console.WriteLine();
            }

            return accounts;
        }
    }
}
